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
    public class BIFCountRepository : IBankInfCount
	{
		private readonly GUIDEDbContext appDbContext;
		private readonly IConfiguration _configuration;
		private readonly ILogger<BIFCountRepository> _logger;

		public BIFCountRepository(ILogger<BIFCountRepository> logger,
										IConfiguration configuration,
										GUIDEDbContext appDbContext)
		{
			this._logger = logger;
			this.appDbContext = appDbContext;
			this._configuration = configuration;
		}

		// This is the first method
		public List<StatusCounterDTO> GetBIFStatusCount()
		{
			List<StatusCounterDTO> lstStatus = new()
						{
							//new StatusCounterDTO() {Count = 0, Status = "V", Description = "Verify"},
							new StatusCounterDTO() {Count = 0, Status = "A", Description = "Authorise"},
							new StatusCounterDTO() {Count = 0, Status = "M", Description = "Modify"},
							//new StatusCounterDTO() {Count = 0, Status = "C", Description = "Deleted"},
							new StatusCounterDTO() {Count = 0, Status = "D", Description = "Delete Pending"},
							new StatusCounterDTO() {Count = 0, Status = "E", Description = "Error"},
							new StatusCounterDTO() {Count = 0, Status = "S", Description = "Submit"}
						};

			var transOptions = new TransactionOptions() { IsolationLevel = IsolationLevel.ReadUncommitted };

            using var scope = new TransactionScope(TransactionScopeOption.Required, transOptions);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var list = new List<StatusCounterDTO>();

            // To translate the logic of "Status"
            var query = (from b in appDbContext.BankInfs
                         select new //BIFSelectDTO()
                         {
                             Status = (b.DeletionStatus == "D" && b.Status == "F") ? "C"
                                     : (b.DeletionStatus == "D" && b.Status != "F") ? "D"
                                     : b.Status,
                             Description = b.GipDescription,
                             b.DeletionStatus,
                             b.GipStatus,
                             b.SwiftId
                         });
						//.ToList();

            // To grouping of "Status"
            var queryGroup = (from b in query.ToList()
                              group b by b.Status into statusGroup
                              select new //StatusCounterDTO
                              {
                                  Status = statusGroup.Key,
                                  Count = (statusGroup == null) ? 0 : statusGroup.Count()
                              });

            // make sure that if there is no statuses then they return the statuses with a result of 0.
            var results = (from s in lstStatus
                           join q in queryGroup.ToList() on s.Status equals q.Status into completeList
                           from leftJoinQuery in completeList.DefaultIfEmpty()
                           select new StatusCounterDTO
                           {
                               Status = s.Status,
                               Description = s.Description,
                               Count = (leftJoinQuery == null) ? 0 : leftJoinQuery.Count
                           });

            scope.Complete();

            stopwatch.Stop();

            //Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds} ms");
            _logger.LogInformation($"Execution Time of GetBIFStatusCount(): {stopwatch.ElapsedMilliseconds} ms");

            return results.ToList().ConvertAll(i => (StatusCounterDTO)i);
        }


        // This is the method way to get the count by status
        public List<StatusCounterDTO> CountBIFSInStatusArchive()
		{
			var transOptions = new TransactionOptions() { IsolationLevel = IsolationLevel.ReadUncommitted };

			using (var scope = new TransactionScope(TransactionScopeOption.Required, transOptions))
			{
				var list = new List<StatusCounterDTO>();

				list.Add(new StatusCounterDTO
				{
					Count = GetBIFCountByStatus("A").Count(),
					Status = "A",
					Description = "Authorise"
				});

				list.Add(new StatusCounterDTO
				{
					Count = GetBIFCountByStatus("M").Count(),
					Status = "M",
					Description = "Modify"
				});

				list.Add(new StatusCounterDTO
				{
					Count = GetBIFCountByStatus("D").Count(),
					Status = "D",
					Description = "Delete Pending"
				});

				var errors = GetBIFCountByStatus("E");
				list.Add(new StatusCounterDTO
				{
					Count = errors.Count,
					Status = "E",
					Description = "Error"
				});


				var submitQueue = GetBIFCountByStatus("S");

				//Remove errors from submit queue display
				//submitQueue.RemoveAll(mainList => errors.Exists(errorList => errorList.SwiftId == mainList.SwiftId));
				submitQueue.Except(errors).ToList();

				list.Add(new StatusCounterDTO
				{
					Count = submitQueue.Count,
					Status = "S",
					Description = "Submit"
				});

				scope.Complete();
				return list;
			}
		}


		private List<SelectedBIFDTO> GetBIFCountByStatus(string cStatus)
		{
			var entry = (from b in appDbContext.BankInfs
						 select new //BIFSelectDTO()
						 {
							 Status = (b.DeletionStatus == "D" && b.Status == "F") ? "C"
									 : (b.DeletionStatus == "D" && b.Status != "F") ? "D"
									 : (b.Status == "S" && (b.GipStatus != "8" || b.GipStatus != "15")) ? "E"
									 : b.Status,
							 Description = b.GipDescription,
                             b.SwiftId
						 }).Distinct();

			var results = (from s in entry
						  where (s.Status == cStatus)
						  select new SelectedBIFDTO ()
						  {
                              Status = s.Status,
                              Description = s.Description,
                              SwiftId = s.SwiftId
                          })
						  .ToList();

			return results;
		}
	}
}
