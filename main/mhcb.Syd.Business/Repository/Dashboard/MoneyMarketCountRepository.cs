using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using mhcb.Syd.DataAccess.Repository;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using mhcb.Syd.Models.Dashboard;
using System.Transactions;
using mhcb.Syd.Interface.Dashboard;
using System.Diagnostics;

namespace mhcb.Syd.Business.Repository.Dashboard
{
    public class MoneyMarketCountRepository : IMoneyMarketCount
	{
		private readonly GUIDEDbContext appDbContext;
		private readonly IConfiguration _configuration;
		private readonly ILogger<MoneyMarketCountRepository> _logger;

		public MoneyMarketCountRepository(ILogger<MoneyMarketCountRepository> logger,
										IConfiguration configuration,
										GUIDEDbContext appDbContext)
		{
			this._logger = logger;
			this.appDbContext = appDbContext;
			this._configuration = configuration;
		}

		public List<StatusCounterSameDayDTO> GetMMTicketStatusCount(string strDate)
		{		
			DateTime? dtDate = DateTime.Parse(strDate);

			List<StatusCounterDTO> lstStatus = new()
						{
							new StatusCounterDTO() {Count = 0, Status = "New", Description = "New", Order = 1},
							new StatusCounterDTO() {Count = 0, Status = "Error", Description = "Error", Order = 2},
							new StatusCounterDTO() {Count = 0, Status = "Inputted", Description = "Inputted",  Order = 3},
							new StatusCounterDTO() {Count = 0, Status = "Finalised", Description = "Finalised", Order = 4},
							new StatusCounterDTO() {Count = 0, Status = "Deleted", Description = "Deleted", Order = 5},
							new StatusCounterDTO() {Count = 0, Status = "Processing", Description = "Processing", Order = 6}
						};

			var transOptions = new TransactionOptions() { IsolationLevel = IsolationLevel.ReadUncommitted };

            using var scope = new TransactionScope(TransactionScopeOption.Required, transOptions);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var query = (from s in lstStatus
                         let OperationDateCount = (from p1 in appDbContext.MoneyMarketTickets
                                                   join p2 in appDbContext.MoneyMarketTicketExts on p1.MmticketId equals p2.MmticketId
                                                   where s.Status == p2.Status
                                                   && (!dtDate.HasValue || EF.Functions.DateDiffDay(p1.OperationDate, dtDate) == 0)
                                                   select 1).Count()

                         let sameDayCount = (from p1 in appDbContext.MoneyMarketTickets
                                             join p2 in appDbContext.MoneyMarketTicketExts on p1.MmticketId equals p2.MmticketId
                                             where s.Status == p2.Status
                                             && (!dtDate.HasValue || EF.Functions.DateDiffDay(p1.OperationDate, dtDate) == 0)
                                             && (!dtDate.HasValue || EF.Functions.DateDiffDay(p1.ValueDate, dtDate) == 0)
                                             select 1).Count()
                         orderby s.Order
                         select new StatusCounterSameDayDTO()
                         {
                             Status = s.Status,
                             Description = s.Description,
                             SameDayCount = sameDayCount,
                             Count = OperationDateCount
                         })
                    .ToList();

            scope.Complete();

            stopwatch.Stop();

            //Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds} ms");
            _logger.LogInformation($"Execution Time of GetMMTicketStatusCount(): {stopwatch.ElapsedMilliseconds} ms");

            return query.ToList().ConvertAll(i => (StatusCounterSameDayDTO)i);
        }

		public List<StatusCounterDTO> CountMMTicketInStatusV1(string strDate)
		{
			DateTime dtDate = DateTime.Parse(strDate);

			List<StatusCounterDTO> lstStatus = new List<StatusCounterDTO>()
						{
							new StatusCounterDTO() {Count = 0, Status = "New", Description = "New"},
							new StatusCounterDTO() {Count = 0, Status = "Error", Description = "Error"},
							new StatusCounterDTO() {Count = 0, Status = "Inputted", Description = "Inputted"},
							new StatusCounterDTO() {Count = 0, Status = "Finalised", Description = "Finalised"},
							new StatusCounterDTO() {Count = 0, Status = "Deleted", Description = "Deleted"},
							new StatusCounterDTO() {Count = 0, Status = "Processing", Description = "Processing"}
						};

			var transOptions = new TransactionOptions() { IsolationLevel = IsolationLevel.ReadUncommitted };

			using (var scope = new TransactionScope(TransactionScopeOption.Required, transOptions))
			{
				// To grouping of "Status"
				var queryGroup = appDbContext.MoneyMarketTicketExts
					 .Join(appDbContext.MoneyMarketTickets.Where(t => EF.Functions.DateDiffDay(t.ValueDate, dtDate) == 0),
							mmt => mmt.MmticketId,
							mm => mm.MmticketId,
							(mmt, mm) => new
								{
									mm.MmticketId,
									mmt.Status,
									mm.ValueDate,

									mm.OperationDate,
									mmt.DeletionStatus,
									mmt.GipStatus,
									mmt.GipDescription,
									mmt.TranNo
								}
							)
					.GroupBy(x => x.Status)
					.Select(g => new StatusCounterDTO
					{
						Status = g.Key,
						Count = g.Count(),
					});
					//.ToList();


				// make sure that if there is no statuses then they return the statuses with a result of 0.
				var results = (from s in lstStatus
							   join q in queryGroup.ToList() on s.Status equals q.Status into completeList
							   from leftJoinQuery in completeList.DefaultIfEmpty()
							   select new StatusCounterDTO
							   {
								   Status = s.Status,
								   Description = s.Description,
								   Count = (leftJoinQuery == null) ? 0 : leftJoinQuery.Count
							   })
							  .ToList();

				scope.Complete();
				return results.ToList().ConvertAll(i => (StatusCounterDTO)i);

				//List<string> expectedStatus = new List<string>() { "New", "Error", "Inputted", "Finalised", "Deleted", "Processing" };
				//foreach (var o in expectedStatus)
				//{
				//	var item = new StatusCounterDTO() { Status = o,  Description = "", Count = 0 };
				//	if (!query.Any(p => p.Status == item.Status)) query.Add(item);
				//}

				//var results = expectedStatus.Select(status => query.FirstOrDefault(q => status == q.Status) ?? new { Status = status, OperationToday = 0, OperationValueToday = 0 }).ToList();
				//return query;
			}
		}


		// To archive only
		public List<StatusCounterDTO> CountMMTicketInStatus_Archive(string strDate)
		{
			var orders = new[] { "New", "Error", "Inputted", "Finalised", "Deleted" };

			var transOptions = new TransactionOptions() { IsolationLevel = IsolationLevel.ReadUncommitted };

			using (var scope = new TransactionScope(TransactionScopeOption.Required, transOptions))
			{
				var list = new List<StatusCounterDTO>();

				list.Add(new StatusCounterDTO
				{
					Count = GetMMTransByStatus("New", strDate).Count(),
					Status = "New",
					Description = "New"
				});

				list.Add(new StatusCounterDTO
				{
					Count = GetMMTransByStatus("Error", strDate).Count(),
					Status = "Error",
					Description = "Error"
				});

				list.Add(new StatusCounterDTO
				{
					Count = GetMMTransByStatus("Inputted", strDate).Count(),
					Status = "Inputted",
					Description = "Inputted"
				});

				list.Add(new StatusCounterDTO
				{
					Count = GetMMTransByStatus("Finalised", strDate).Count(),
					Status = "Finalised",
					Description = "Finalised"
				});

				list.Add(new StatusCounterDTO
				{
					Count = GetMMTransByStatus("Deleted", strDate).Count(),
					Status = "Deleted",
					Description = "Deleted"
				});

				scope.Complete();
				return list;
			}
		}

		public IEnumerable<SelectedMMDTO> GetMMTransByStatus(string cStatus, string strDate)
		{
			DateTime dtDate = DateTime.Parse(strDate);

			var order = new[] { "New", "Error", "Inputted", "Finalised", "Deleted" };

			var query = (from mm in appDbContext.MoneyMarketTickets
						 join mmt in appDbContext.MoneyMarketTicketExts on mm.MmticketId equals mmt.MmticketId
						 where (mmt.Status == cStatus)
							&& (EF.Functions.DateDiffDay(mm.ValueDate, dtDate) == 0)
						 select new SelectedMMDTO
						 {
							 MmticketId = mm.MmticketId,
                             Status = mmt.Status,
                             GipDescription = mmt.GipDescription,
						 })
						 .ToList();
			return query;
		}	
	}
}
