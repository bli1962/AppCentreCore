using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Models.Dashboard;
using Microsoft.EntityFrameworkCore;
using mhcb.Syd.Interface.Dashboard;
using System;
using System.Diagnostics;

namespace mhcb.Syd.Business.Repository.Dashboard
{
	public class DistributionCountRepository : IDistributionCount
	{
		private readonly eDistributionContext appDbContext;
		private readonly IConfiguration _configuration;
		private readonly ILogger<DistributionCountRepository> _logger;

		public DistributionCountRepository(ILogger<DistributionCountRepository> logger,
										IConfiguration configuration,
										eDistributionContext appDbContext)
		{
			this._logger = logger;
			this.appDbContext = appDbContext;
			this._configuration = configuration;
		}

		public List<StatusCounterDTO> GetDistributionsStatusCount(string strDate)
		{
			
			DateTime dtDate = DateTime.Parse(strDate);

			List<StatusCounterDTO> statues = new()
						{
							new StatusCounterDTO() {Count = 0, Status = "H", Description = "Held"},
							new StatusCounterDTO() {Count = 0, Status = "S", Description = "Sent"},
							new StatusCounterDTO() {Count = 0, Status = "C", Description = "Cancelled"},
							new StatusCounterDTO() {Count = 0, Status = "D", Description = "Deleted"},
							new StatusCounterDTO() {Count = 0, Status = "E", Description = "Error"},
							new StatusCounterDTO() {Count = 0, Status = "P", Description = "Pending"}
						};

			var transOptions = new TransactionOptions() { IsolationLevel = IsolationLevel.ReadUncommitted };

            using var scope = new TransactionScope(TransactionScopeOption.Required, transOptions);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var list = new List<StatusCounterDTO>();

            var query = from d in appDbContext.Distributions
                        where (
                                ((d.Status == "H") || (d.Status == "P")) ||
                                ((d.Status == "S" || d.Status == "C") && EF.Functions.DateDiffDay(d.DateSent, dtDate) == 0) ||
                                (d.Status == "D" && EF.Functions.DateDiffDay(d.DateDeleted, dtDate) == 0) ||
                                (d.Status == "E" && EF.Functions.DateDiffDay(d.DateAvailable, dtDate) == 0)
                                )
                        group d by d.Status
                        into g
                        select new //StatusCounterDTO 
                        {
                            Status = g.Key,
                            Count = g.Count()
                        };

            // make sure that if there is no statuses then they return the statuses with a result of 0.
            var results = from s in statues
                          join g in query.ToList() on s.Status equals g.Status into completeList
                          from g in completeList.DefaultIfEmpty()
                          select new StatusCounterDTO
                          {
                              Status = s.Status,
                              Description = s.Description,
                              Count = (g == null) ? 0 : g.Count
                          };

            scope.Complete();

            stopwatch.Stop();

            //Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds} ms");
            _logger.LogInformation($"Execution Time of GetDistributionsStatusCount(): {stopwatch.ElapsedMilliseconds} ms");

            return results.ToList().ConvertAll(i => (StatusCounterDTO)i);

        }
	}
}
