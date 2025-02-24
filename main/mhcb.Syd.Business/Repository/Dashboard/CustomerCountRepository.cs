using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Models.Dashboard;
using mhcb.Syd.Interface.Dashboard;
using System.Diagnostics;

namespace mhcb.Syd.Business.Repository.Dashboard
{
	public class CustomerCountRepository : ICustomerCount
	{
		private readonly GUIDEDbContext appDbContext;
		private readonly IConfiguration _configuration;
		private readonly ILogger<CustomerCountRepository> _logger;

		public CustomerCountRepository(ILogger<CustomerCountRepository> logger,
										IConfiguration configuration,
										GUIDEDbContext appDbContext)
		{
			this._logger = logger;
			this.appDbContext = appDbContext;
			this._configuration = configuration;
		}

		public List<StatusCounterDTO> GetCustomerStatusCount()
		{
			var transOptions = new TransactionOptions() { IsolationLevel = IsolationLevel.ReadUncommitted };

            using var scope = new TransactionScope(TransactionScopeOption.Required, transOptions);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var list = new List<StatusCounterDTO>();

            list.Add(new StatusCounterDTO
            {
                Count = GetFXCustomerCountByStatus("M").Count(),
                Status = "M",
                Description = "FX Cust Modify"
            });


            list.Add(new StatusCounterDTO
            {
                Count = GetFXCustomerCountByStatus("A").Count(),
                Status = "A",
                Description = "FX Cust Authorise"
            });

            list.Add(new StatusCounterDTO
            {
                Count = GetFXCustomerCountByStatus("D").Count(),
                Status = "D",
                Description = "FX Cust Delete Pending"
            });

            list.Add(new StatusCounterDTO
            {
                Count = GetMXCustomerCountByStatus("P").Count(),
                Status = "P",
                Description = "MX Cust Upload Pending"
            });

            list.Add(new StatusCounterDTO
            {
                Count = GetMXCustomerCountByStatus("F").Count(),
                Status = "F",
                Description = "MX Cust Upload Fail"
            });

            scope.Complete();

            stopwatch.Stop();

            //Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds} ms");
            _logger.LogInformation($"Execution Time of GetCustomerStatusCount(): {stopwatch.ElapsedMilliseconds} ms");

            return list;
        }

		private List<SelectedCustomerDTO> GetFXCustomerCountByStatus(string cStatus)
		{
			var entry = (from fx in appDbContext.Fxfcusts
						 join cm in appDbContext.CustomerMasters on fx.Code equals cm.CustCode
						 where (cm.StatusCd != "C")
						 select new			//CustomerSelectDTO()
						 {
							 Status = (fx.DeletionStatus == "D" && fx.Status == "F") ? "C"
									 : (fx.DeletionStatus == "D" && fx.Status != "F") ? "D"
									 : fx.Status,
							 Description = cm.GipDescription,
							 cm.CustCode
						 }).Distinct();

			var results = (from s in entry
						   where (s.Status == cStatus)
						   select new SelectedCustomerDTO()
						   {
							   Status = s.Status,
							   Description = s.Description,
							   CustCode = s.CustCode
						   })						   
						   .ToList();

			return results;

		}

		private List<SelectedCustomerDTO> GetMXCustomerCountByStatus(string cStatus)
		{

			var entry = (from fx in appDbContext.Fxfcusts
						 join cm in appDbContext.CustomerMasters on fx.Code equals cm.CustCode
						 join mxdetail in appDbContext.MxGuideCustDetails on fx.MxGuideCustDetailId equals mxdetail.Id into MxCustGroup
						 from mx in MxCustGroup.DefaultIfEmpty()
						 where (cm.StatusCd != "C")
							  && (fx.MxGuideCustDetailId != null)
							  && (mx.MxCustomerStatus != null)
						 select new //CustomerSelectDTO()
						 {
							 Status = (fx.Status == "F" && fx.DeletionStatus == "" && mx.MxCustomerStatus == 1) ? "S"
									: (mx.MxCustomerStatus == 2  ) ? "F"
									: (mx.MxCustomerStatus == 3 ) ? "P"
									: fx.Status,
							 Description = (fx.Status == "F" && fx.DeletionStatus == "" && mx.MxCustomerStatus == 1) ? "Success"
									 : (mx.MxCustomerStatus == 2 ) ? "Fail"
									 : (mx.MxCustomerStatus == 3 ) ? "Pending"
									 : "",
							 cm.CustCode
						 }).Distinct();

			var results = (from s in entry
						   where (s.Status == cStatus)
						   select new SelectedCustomerDTO()
						   {
                               Status = s.Status,
                               Description = s.Description,
                               CustCode = s.CustCode
                           })					   						   
						   .ToList();

			return results;
		}
	}
}
