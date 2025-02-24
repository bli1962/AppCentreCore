using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Models.Dashboard;
using mhcb.Syd.Interface.Dashboard;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;

namespace mhcb.Syd.Business.Repository.Dashboard
{
    public class DomesticClearingCountRepository : IDomesticClearingCount
    {
        private readonly GUIDEDbContext appDbContext;
        private readonly IConfiguration _configuration;
        private readonly ILogger<DomesticClearingCountRepository> _logger;

        public DomesticClearingCountRepository(ILogger<DomesticClearingCountRepository> logger,
                                        IConfiguration configuration,
                                        GUIDEDbContext appDbContext)
        {
            this._logger = logger;
            this.appDbContext = appDbContext;
            this._configuration = configuration;
        }


        //--BECS Value Today
        //Select[StatusId], [PreviousStatusId], *  FROM[Guide].[dbo].[DomesticClearing_Payment]
        //		where datediff(day, ValueDate, getdate()) = 0  
        //and(statusid = 2  -- System pending
        //or statusid = 22, 8  -- Action Pending
        //or statusid = 5)  -- final status

        //--BECS Created Today
        //Select[StatusId], [PreviousStatusId],  *  FROM[Guide].[dbo].[DomesticClearing_Payment]
        //		where datediff(day, CreatedWhen, getdate()) = 0  
        //and(statusid = 2  -- System pending
        //or statusid = 22, 8  -- Action Pending
        //or statusid = 5)  -- final status

        //--Return Processed Today
        //Select[StatusId], [PreviousStatusId], *  FROM[Guide].[dbo].[DomesticClearing_Payment]
        //		where datediff(day, [ProcessDate], getdate()) = 0
        //and(statusid = 2  -- System pending
        //or statusid = 22  -- Action Pending
        //or statusid = 33)  -- Return Completed

        //--Pending Prior to Today
        //Select[StatusId], [PreviousStatusId], *  FROM[Guide].[dbo].[DomesticClearing_Payment]
        //		where datediff(day, CreatedWhen, getdate()) >0
        //and statusid = 2  -- System pending
        //or statusid  = 22,8  -- Action Pending

        //--Static Data
        //Select[StatusId], [PreviousStatusId], *   FROM[Guide].[dbo].[DomesticClearing_Payment]
        //		where
        //statusid =    22-- Authorise Pending
        //or statusid = 24-- Authorise Deletion


        // 2 - validated, 5 - Completed, 10 - Fee calculated,
        // 22 - Authorise Pending, 24 - Authorise Deletion
        // 33 - Return completed

        public List<StatusCounterDTO> GetDomesticClearingStatusCount(string strDate)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            DateTime? date = DateTime.Parse(strDate);

            //List<int> expectedStatus1 = new() { 2, 5, 10, 22, 8 };  //BECS Value Today
            //List<int> expectedStatus2 = new() { 2, 5, 10, 22, 8 };  //BECS Created Today
            //List<int> expectedStatus3 = new() { 2, 22, 33 };     //Return Processed Today
            //List<int> expectedStatus4 = new() { 2, 10, 22 };     //Pending Prior to Today
            //List<int> expectedStatus5 = new() { 22, 24 };         //Static Data

            List<string> SystemPending = new() { "SS003441", "MHCB\\svcguide" };   // 2, 6, 10, 29, 32, 37, 39 
            List<int> FinalStatusId = new() { 5, 33, 41 };
            List<int> ErrorStatusId = new() { 8, 34, 38 };
            List<int> PendingStatusId = new() {22 };

            List<int> ExcludedStatusId = new() {32, 37, 39};

            var results = new List<StatusCounterDTO>();

            //1. BECS Value Today
            var query = from p in appDbContext.DomesticClearingPayments
                        where EF.Functions.DateDiffDay(p.ValueDate, date) == 0
                         && !ExcludedStatusId.Contains((int)p.StatusId)
                        join s in appDbContext.DomesticClearingStatuses on p.StatusId equals s.StatusId
                        where s.UpdatedWho != null
                        select new { 
                                p.StatusId,
                                s.UpdatedWho
                         }; 
            //int systemPending = query.Count(x => (x.StatusId == 2 || x.StatusId == 10));
            //int actionPending = query.Count(x => (x.StatusId == 8 || x.StatusId == 22));
            //int final = query.Count(x => (x.StatusId == 5));
            int systemPending = query.Count(x => SystemPending.Contains(x.UpdatedWho) 
                                                && !FinalStatusId.Contains((int)x.StatusId)
                                                );
            int actionPending = query.Count(x => !SystemPending.Contains(x.UpdatedWho)
                                                && !FinalStatusId.Contains((int)x.StatusId));
            int final = query.Count(x => FinalStatusId.Contains((int)x.StatusId));

            results.Add(new StatusCounterDTO() { Status = "BECS Value Today", Description = "System Pending", Count = systemPending });
            results.Add(new StatusCounterDTO() { Status = "BECS Value Today", Description = "Action Pending", Count = actionPending });
            results.Add(new StatusCounterDTO() { Status = "BECS Value Today", Description = "Final status", Count = final });


            //2. BECS Created Today
            //query = appDbContext.DomesticClearingPayments.Where(x => EF.Functions.DateDiffDay(x.CreatedWhen, date) == 0);
            query = from p in appDbContext.DomesticClearingPayments
                    where EF.Functions.DateDiffDay(p.CreatedWhen, date) == 0
                     && !ExcludedStatusId.Contains((int)p.StatusId)
                    join s in appDbContext.DomesticClearingStatuses on p.StatusId equals s.StatusId
                    where s.UpdatedWho != null
                    select new
                    {
                        p.StatusId,
                        s.UpdatedWho
                    };
            //systemPending = query.Count(x => (x.StatusId == 2 || x.StatusId == 10));
            //actionPending = query.Count(x => (x.StatusId == 8 || x.StatusId == 22));
            //final = query.Count(x => (x.StatusId == 5 || x.StatusId == 33));
            systemPending = query.Count(x => SystemPending.Contains(x.UpdatedWho)
                                             && !FinalStatusId.Contains((int)x.StatusId)
                                             );
            actionPending = query.Count(x => !SystemPending.Contains(x.UpdatedWho)
                                             && !FinalStatusId.Contains((int)x.StatusId));
            final = query.Count(x => FinalStatusId.Contains((int)x.StatusId));

            results.Add(new StatusCounterDTO() { Status = "BECS Created Today", Description = "System Pending", Count = systemPending });
            results.Add(new StatusCounterDTO() { Status = "BECS Created Today", Description = "Action Pending", Count = actionPending });
            results.Add(new StatusCounterDTO() { Status = "BECS Created Today", Description = "Final status", Count = final });



            // 3. Return Processed Today
            //query = appDbContext.DomesticClearingPayments.Where(x => EF.Functions.DateDiffDay(x.ProcessDate, date) == 0);
            query = from p in appDbContext.DomesticClearingPayments
                    where EF.Functions.DateDiffDay(p.ProcessDate, date) == 0
                     && !ExcludedStatusId.Contains((int)p.StatusId)
                    join s in appDbContext.DomesticClearingStatuses on p.StatusId equals s.StatusId
                    where s.UpdatedWho != null
                    select new
                    {
                        p.StatusId,
                        s.UpdatedWho
                    };
            //systemPending = query.Count(x => (x.StatusId == 2));
            //actionPending = query.Count(x => (x.StatusId == 22));
            //final = query.Count(x => (x.StatusId == 33));
            systemPending = query.Count(x => SystemPending.Contains(x.UpdatedWho)
                                           && !FinalStatusId.Contains((int)x.StatusId)
                                           );
            actionPending = query.Count(x => !SystemPending.Contains(x.UpdatedWho)
                                            && !FinalStatusId.Contains((int)x.StatusId)
                                            );
            
            final = query.Count(x => !SystemPending.Contains(x.UpdatedWho)
                                    && FinalStatusId.Contains((int)x.StatusId)
                                    );

            results.Add(new StatusCounterDTO() { Status = "Return Processed Today", Description = "System Pending", Count = systemPending });
            results.Add(new StatusCounterDTO() { Status = "Return Processed Today", Description = "Final status", Count = final });



            // 4. Pending Prior to Today
            //query = appDbContext.DomesticClearingPayments.Where(x => EF.Functions.DateDiffDay(x.CreatedWhen, date) > 0);
            query = from p in appDbContext.DomesticClearingPayments
                    where EF.Functions.DateDiffDay(p.CreatedWhen, date) > 0
                     && !ExcludedStatusId.Contains((int)p.StatusId)
                    join s in appDbContext.DomesticClearingStatuses on p.StatusId equals s.StatusId
                    where s.UpdatedWho != null
                    select new
                    {
                        p.StatusId,
                        s.UpdatedWho
                    };
            //systemPending = query.Count(x => (x.StatusId == 2 || x.StatusId == 10));
            systemPending = query.Count(x => SystemPending.Contains(x.UpdatedWho)
                                           && !FinalStatusId.Contains((int)x.StatusId)
                                           && !ExcludedStatusId.Contains((int)x.StatusId));
            //actionPending = query.Count(x => (ErrorStatusId.Contains((int)x.StatusId) || PendingStatusId.Contains((int)x.StatusId)));
            actionPending = query.Count(x => !SystemPending.Contains(x.UpdatedWho)
                                          && !FinalStatusId.Contains((int)x.StatusId)
                                          && !ExcludedStatusId.Contains((int)x.StatusId));

            results.Add(new StatusCounterDTO() { Status = "Pending Prior to Today", Description = "System Pending", Count = systemPending });
            results.Add(new StatusCounterDTO() { Status = "Pending Prior to Today", Description = "Action Pending", Count = actionPending });



            // 5. Static Data
            //query = appDbContext.DomesticClearingPayments;
            query = from p in appDbContext.DomesticClearingPayments
                    join s in appDbContext.DomesticClearingStatuses on p.StatusId equals s.StatusId
                    where !FinalStatusId.Contains((int)p.StatusId)
                    select new
                    {
                        p.StatusId,
                        s.UpdatedWho
                    };
            systemPending = query.Count(x => (x.StatusId == 22 || x.StatusId == 37));
            actionPending = query.Count(x => (x.StatusId == 24));
            final = 0;
            results.Add(new StatusCounterDTO() { Status = "Static Data", Description = "Authorise Pending", Count = systemPending });
            results.Add(new StatusCounterDTO() { Status = "Static Data", Description = "Authorise Deletion", Count = actionPending });


            stopwatch.Stop();

            //Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds} ms");
            _logger.LogInformation($"Execution Time of GetDomesticClearingStatusCount(): {stopwatch.ElapsedMilliseconds} ms");

            return results;
        }


        public List<StatusCounterDomesticClearingDTO> GetDomesticClearingStatusCount2(string strDate)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            DateTime? date = DateTime.Parse(strDate);

            List<int> expectedStatus1 = new() { 2, 5, 10, 22 };  //BECS Value Today
            List<int> expectedStatus2 = new() { 2, 5, 10, 22 };  //BECS Created Today
            List<int> expectedStatus3 = new() { 2, 22, 33 };     //Return Processed Today
            List<int> expectedStatus4 = new() { 2, 10, 22 };     //Pending Prior to Today
            List<int> expectedStatus5 = new() { 22, 24 };         //Static Data

            var query1 = (from status in appDbContext.DomesticClearingStatuses
                          where expectedStatus1.Contains(status.StatusId)
                          let PaymentCount = (from payment in appDbContext.DomesticClearingPayments
                                              where payment.StatusId == status.StatusId
                                              && (!date.HasValue || EF.Functions.DateDiffDay(payment.ValueDate, date) == 0)
                                              select 1).Count()
                          orderby status.Order
                          select new StatusCounterDomesticClearingDTO()
                          {
                              StatusID = status.StatusId.ToString(),
                              Status = "BECS Value Today",
                              Description = status.Description,
                              Count = PaymentCount,
                          })
                        .ToList();

            var query2 = (from status in appDbContext.DomesticClearingStatuses
                          where expectedStatus2.Contains(status.StatusId)
                          let PaymentCount = (from payment in appDbContext.DomesticClearingPayments
                                              where payment.StatusId == status.StatusId
                                              && (!date.HasValue || EF.Functions.DateDiffDay(payment.CreatedWhen, date) == 0)
                                              select 1).Count()
                          orderby status.Order
                          select new StatusCounterDomesticClearingDTO()
                          {
                              StatusID = status.StatusId.ToString(),
                              Status = "BECS Created Today",
                              Description = status.Description,
                              Count = PaymentCount,
                          })
                         .ToList();

            var query3 = (from status in appDbContext.DomesticClearingStatuses
                          where expectedStatus3.Contains(status.StatusId)
                          let PaymentCount = (from payment in appDbContext.DomesticClearingPayments
                                              where payment.StatusId == status.StatusId
                                              && (!date.HasValue || EF.Functions.DateDiffDay(payment.ProcessDate, date) == 0)
                                              select 1).Count()
                          orderby status.Order
                          select new StatusCounterDomesticClearingDTO()
                          {
                              StatusID = status.StatusId.ToString(),
                              Status = "Return Processed Today",
                              Description = status.Description,
                              Count = PaymentCount,
                          })
                        .ToList();

            var query4 = (from status in appDbContext.DomesticClearingStatuses
                          where expectedStatus4.Contains(status.StatusId)
                          let PaymentCount = (from payment in appDbContext.DomesticClearingPayments
                                              where payment.StatusId == status.StatusId
                                              && (!date.HasValue || EF.Functions.DateDiffDay(payment.CreatedWhen, date) > 0)
                                              select 1).Count()
                          orderby status.Order
                          select new StatusCounterDomesticClearingDTO()
                          {
                              StatusID = status.StatusId.ToString(),
                              Status = "Pending Prior to Today",
                              Description = status.Description,
                              Count = PaymentCount,
                          })
                          .ToList();

            var query5 = (from status in appDbContext.DomesticClearingStatuses
                          where expectedStatus5.Contains(status.StatusId)
                          let PaymentCount = (from payment in appDbContext.DomesticClearingPayments
                                              where payment.StatusId == status.StatusId
                                              select 1).Count()
                          orderby status.Order
                          select new StatusCounterDomesticClearingDTO()
                          {
                              StatusID = status.StatusId.ToString(),
                              Status = status.Description,
                              Description = "Static Data",
                              Count = PaymentCount,
                          })
                        .ToList();

            stopwatch.Stop();

            var results = new List<StatusCounterDomesticClearingDTO>();
            results.AddRange(query1);
            results.AddRange(query2);
            results.AddRange(query3);
            results.AddRange(query4);
            results.AddRange(query5);

            //Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds} ms");
            _logger.LogInformation($"Execution Time of GetDomesticClearingStatusCount(): {stopwatch.ElapsedMilliseconds} ms");

            return results;
        }
 
    }

}