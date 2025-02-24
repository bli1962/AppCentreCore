using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Interface.Dashboard;
using mhcb.Syd.Models.Dashboard;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Transactions;

namespace mhcb.Syd.Business.Repository.Dashboard
{
    public class SIFCountRepository : ISettlementInfCount
	{
		private readonly GUIDEDbContext appDbContext;
		private readonly IConfiguration _configuration;
		private readonly ILogger<SIFCountRepository> _logger;

		public SIFCountRepository(ILogger<SIFCountRepository> logger,
										IConfiguration configuration,
										GUIDEDbContext appDbContext)
		{
			this._logger = logger;
			this.appDbContext = appDbContext;
			this._configuration = configuration;
		}

        // This is the first method
        public List<StatusCounterDTO> GetSIFStatusCount()
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
            var query = (from s in appDbContext.SettlementInfs
                         join f in appDbContext.Fxfswifts on s.SifId equals f.SifId into fullFxfSwifts
                         from s1 in fullFxfSwifts.DefaultIfEmpty()
                         where s1.CcyCd != ""
                         select new         //SIFSelectDTO()
                         {
                             Status = (s.DeletionStatus == "D" && s.Status == "F") ? "C"
                                     : (s.DeletionStatus == "D" && s.Status != "F") ? "D"
                                     : (s.Status == "S" && (s.GipStatus != "8" || s.GipStatus != "15")) ? "E"
                                     : s.Status,
                             Description = s.GipDescription,
                             s.SifId
                         });
						 //.ToList();

            // To grouping of "Status"
            var queryGroup = (from b in query.ToList()
                              group b by b.Status into statusGroup
                              select new        //StatusCounterDTO
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
                           })
                          .ToList();

            scope.Complete();

            stopwatch.Stop();

            //Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds} ms");
            _logger.LogInformation($"Execution Time of GetSIFStatusCount(): {stopwatch.ElapsedMilliseconds} ms");

            return results.ToList().ConvertAll(i => (StatusCounterDTO)i);
        }


        // This is the second method to get the count by status
        public List<StatusCounterDTO> CountSIFSInStatusArchiveArchive()
		{
			var transOptions = new TransactionOptions() { IsolationLevel = IsolationLevel.ReadUncommitted };

			using (var scope = new TransactionScope(TransactionScopeOption.Required, transOptions))
			{
				var list = new List<StatusCounterDTO>();

				list.Add(new StatusCounterDTO
				{
					Count = GetSIFCountByStatus("A").Count,
					Status = "A",
					Description = "Authorise"
				});

				list.Add(new StatusCounterDTO
				{
					Count = GetSIFCountByStatus("M").Count,
					Status = "M",
					Description = "Modify"
				});

				list.Add(new StatusCounterDTO
				{
					Count = GetSIFCountByStatus("D").Count,
					Status = "D",
					Description = "Delete Pending"
				});

				var errorsQueue = GetSIFCountByStatus("E");
				list.Add(new StatusCounterDTO
				{
					Count = errorsQueue.Count,
					Status = "E",
					Description = "Error"
				});

				var submitQueue = GetSIFCountByStatus("S");
				//Remove errors from submit queue display
				//submitQueue.RemoveAll(mainList => errors.Exists(errorList => errorList.SifId == mainList.SifId));
				submitQueue.Except(errorsQueue).ToList();

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

		private List<SelectedSIFDTO> GetSIFCountByStatus(string cStatus)
		{

			var entry = (from s in appDbContext.SettlementInfs
						 join f in appDbContext.Fxfswifts on s.SifId equals f.SifId into fullFxfSwifts
						 from s1 in fullFxfSwifts.DefaultIfEmpty()
						 join y in appDbContext.Fxfccies on s1.CcyCd equals y.CcyCd into fullFxfSwiftsCcy
						 from y1 in fullFxfSwiftsCcy.DefaultIfEmpty()
						 select new //SIFSelectDTO()
						 {
							 Status = (s.DeletionStatus == "D" && s.Status == "F") ? "C"
									 : (s.DeletionStatus == "D" && s.Status != "F") ? "D"
									 : (s.Status == "S" && (s.GipStatus != "8" || s.GipStatus != "15")) ? "E"
									 : s.Status,
							 Description = s.GipDescription,
							 s.SifId
						 }).Distinct();

			var results = (from s in entry
						   where (s.Status == cStatus)
						   select new SelectedSIFDTO()
						   {
                               Status = s.Status,
                               Description = s.Description,
							   SifId = s.SifId,
                           })
						   .ToList();

			return results;
		}
	}
}
