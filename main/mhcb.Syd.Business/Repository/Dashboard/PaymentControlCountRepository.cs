using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using mhcb.Syd.DataAccess.Repository;
using System;
using Microsoft.EntityFrameworkCore;
using mhcb.Syd.Interface.Dashboard;
using mhcb.Syd.Models.Dashboard;
using static Dapper.SqlMapper;
using System.Diagnostics;

namespace mhcb.Syd.Business.Repository.Dashboard
{
    public class PaymentControlCountRepository : IPaymentControlCount
	{
		private readonly GUIDEDbContext appDbContext;
		private readonly IConfiguration _configuration;
		private readonly ILogger<PaymentControlCountRepository> _logger;

		public PaymentControlCountRepository(ILogger<PaymentControlCountRepository> logger,
										IConfiguration configuration,
										GUIDEDbContext appDbContext)
		{
			this._logger = logger;
			this.appDbContext = appDbContext;
			this._configuration = configuration;
		}

		// this is the first method
		public IEnumerable<StatusCounterSameDayDTO> GetPaymentControlStatusCount(string strDate)
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();

			DateTime? dtDate = DateTime.Parse(strDate);

			var query1 = (from payment in appDbContext.PaymentControlPayments
						  where //payment.StatusId == status.StatusId
							(!dtDate.HasValue || EF.Functions.DateDiffDay(payment.ReleaseDate, dtDate) == 0)
						  group payment by payment.StatusId into queryGroup
						  select new
						  {
							  StatusId = queryGroup.Key,
							  TotalStatus = queryGroup.Count()
						  });

			var query2 = (from payment in appDbContext.PaymentControlPayments
						  where //payment.StatusId == status.StatusId
						  (!dtDate.HasValue || EF.Functions.DateDiffDay(payment.ValueDate, dtDate) == 0)
						  && (!dtDate.HasValue || EF.Functions.DateDiffDay(payment.ReleaseDate, dtDate) == 0)
						  group payment by payment.StatusId into queryGroup
						  select new
						  {
							  StatusId = queryGroup.Key,
							  TotalStatus = queryGroup.Count()
						  });

			var query = (from status in appDbContext.PaymentControlStatuses
						 join q1 in query1 on status.StatusId equals q1.StatusId into completeList1
						 from leftJoinQuery1 in completeList1.DefaultIfEmpty()
						 join q2 in query2 on status.StatusId equals q2.StatusId into completeList2
						 from leftJoinQuery2 in completeList2.DefaultIfEmpty()
						 where -1 != status.Order
						 orderby status.Order
						 select new StatusCounterSameDayDTO()
						 {
							 Status = status.StatusId.ToString(),
							 Description = status.Description,
							 Count = (leftJoinQuery2.StatusId == null) ? 0 : leftJoinQuery2.TotalStatus,
                             SameDayCount = (leftJoinQuery1.StatusId == null) ? 0 : leftJoinQuery1.TotalStatus,
						 })
						 .ToList();

			stopwatch.Stop();

			//Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds} ms");
			_logger.LogInformation($"Execution Time of GetPaymentControlStatusCount(): {stopwatch.ElapsedMilliseconds} ms");

			return query;
		}


        // this is the second method, I think it is less performance than the first way
        public IEnumerable<StatusCounterSameDayDTO> CountPaymentControlInStatus1(string strDate)
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			DateTime? date = DateTime.Parse(strDate);

			var query = (from status in appDbContext.PaymentControlStatuses
						 where -1 != status.Order
						 let paymentCount = (from payment in appDbContext.PaymentControlPayments
											 where payment.StatusId == status.StatusId
											 && (!date.HasValue || EF.Functions.DateDiffDay(payment.ReleaseDate, date) == 0)
											 select 1).Count()

						 let sameDayCount = (from payment in appDbContext.PaymentControlPayments
											 where payment.StatusId == status.StatusId
											 && (!date.HasValue || EF.Functions.DateDiffDay(payment.ValueDate, date) == 0)
											 && (!date.HasValue || EF.Functions.DateDiffDay(payment.ReleaseDate, date) == 0)
											 select 1).Count()
						 orderby status.Order
						 select new StatusCounterSameDayDTO()
						 {
							 Status = status.StatusId.ToString(),
							 Description = status.Description,
                             Count = paymentCount,
                             SameDayCount = sameDayCount,							
						 })
						.ToList();

			stopwatch.Stop();

			Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds} ms");
			_logger.LogInformation($"Execution Time of CountPaymentControlInStatus(): {stopwatch.ElapsedMilliseconds} ms");

			return query;
		}


	}
}
