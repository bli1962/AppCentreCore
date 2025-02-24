using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Interface.Dashboard;
using mhcb.Syd.Models.Dashboard;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Transactions;

namespace mhcb.Syd.Business.Repository.Dashboard
{
    public class FxConfirmationCountRepository : IFXConfirmationCount
    {
        private readonly GUIDEDbContext appDbContext;
        private readonly IConfiguration _configuration;
        private readonly ILogger<FxConfirmationCountRepository> _logger;

        public FxConfirmationCountRepository(ILogger<FxConfirmationCountRepository> logger,
                                            IConfiguration configuration,
                                            GUIDEDbContext appDbContext)
        {
            this._logger = logger;
            this.appDbContext = appDbContext;
            this._configuration = configuration;
        }

        //1
        public List<StatusCounterSameDayDTO> CountFxConfirmationStatus(string strDate)
        {
            if (!(strDate != null)) return new List<StatusCounterSameDayDTO>();
            DateTime dtDate = DateTime.Parse(strDate);

            // Create a new Stopwatch instance
            Stopwatch stopwatch = new Stopwatch();

            // Start the Stopwatch before executing the query
            stopwatch.Start();


            DateTime targetDate = DateTime.Parse(strDate);

            var allTransactions = 
                        from fx in appDbContext.FxTransactions
                        join mg in appDbContext.MgeBtransactionConfirmations on fx.RefNo equals mg.ReferenceNumber
                        where (fx.TransCode == 4
                                && fx.DeletionStatus != "D"
								&& mg.DeleteDate == null
								&& EF.Functions.DateDiffDay(fx.ContractDateOpe, targetDate) == 0
                                )
                        select new
                        {
                        fx.RefNo,
                        };

            var todayTransactions = 
                        from fx in appDbContext.FxTransactions
                        join mg in appDbContext.MgeBtransactionConfirmations on fx.RefNo equals mg.ReferenceNumber
                        where (fx.TransCode == 4
                                && fx.DeletionStatus != "D"
								&& mg.DeleteDate == null
								&& EF.Functions.DateDiffDay(fx.ContractDateOpe, targetDate) == 0
                                && EF.Functions.DateDiffDay(fx.DelivaryDate, targetDate) == 0
                               )
                        select new
                        {
                            fx.RefNo,
                        };

            var lastLogID = from log in appDbContext.FxConfirmationLogs
                            where EF.Functions.DateDiffDay(log.AddDate, targetDate) == 0
                             group log by log.ReferenceNumber into g
                             select new
                             {
                                 ReferenceNumber = g.Key,
                                 LogId = g.Max(x => x.Id)
                                 
                             };

            var groupQuery1 = from lastLog in lastLogID
                          join mg in allTransactions on lastLog.ReferenceNumber equals mg.RefNo
                          join log in appDbContext.FxConfirmationLogs on lastLog.LogId equals log.Id
                          group log by log.FxConfirmationStatusId into statusGroup
                          select new
                          {
                               StatusId = statusGroup.Key,
                               TotalStatus = statusGroup.Count()
                          };

            var groupQuery2 = from lastLog in lastLogID
                              join mg in todayTransactions on lastLog.ReferenceNumber equals mg.RefNo
                              join log in appDbContext.FxConfirmationLogs on lastLog.LogId equals log.Id
                              group log by log.FxConfirmationStatusId into statusGroup
                              select new
                              {
                                  StatusId = statusGroup.Key,
                                  TotalStatus = statusGroup.Count()
                              };

            List<int> expectedStatus = new() { 1, 2, 3, 4 };

            var results = (from status in appDbContext.FxConfirmationStatuses
                         where expectedStatus.Contains(status.Id)
                         join q1 in groupQuery1 on status.Id equals q1.StatusId into completeList1
                         from leftJoinQuery1 in completeList1.DefaultIfEmpty()
                         join q2 in groupQuery2 on status.Id equals q2.StatusId into completeList2
                         from leftJoinQuery2 in completeList2.DefaultIfEmpty()

                         orderby status.Id
                         select new StatusCounterSameDayDTO()
                         {
                             Status = status.Status,
                             Description = status.Description,
                             Count = (leftJoinQuery1.StatusId == null) ? 0 : leftJoinQuery1.TotalStatus,
                             SameDayCount = (leftJoinQuery2.StatusId == null) ? 0 : leftJoinQuery2.TotalStatus,
  
                         })
                         .ToList();

            // Stop the Stopwatch after the query execution
            stopwatch.Stop();

            _logger.LogInformation($"Execution Time of CountFxConfirmationStatus(): {stopwatch.ElapsedMilliseconds} ms");

            results.Add(CountFxUnconfirmatedStatus(strDate));
            return results;
        }


		public StatusCounterSameDayDTO CountFxUnconfirmatedStatus(string strDate)
		{
			if (!(strDate != null)) return new StatusCounterSameDayDTO();

			DateTime dtDate = DateTime.Parse(strDate);

			// Create a new Stopwatch instance
			Stopwatch stopwatch = new Stopwatch();

			// Start the Stopwatch before executing the query
			stopwatch.Start();

			DateTime targetDate = DateTime.Parse(strDate);

            // Part1 : Non deletion trans
			var allWithMgebTransactions =
						from fx in appDbContext.FxTransactions
						join mg in appDbContext.MgeBtransactionConfirmations on fx.RefNo equals mg.ReferenceNumber
						where (fx.TransCode == 4
								&& fx.DeletionStatus != "D"
								&& mg.DeleteDate == null
								&& EF.Functions.DateDiffDay(fx.ContractDateOpe, targetDate) == 0
								)
						select new
						{
							fx.RefNo,
						};

			var todayWithMgebTransactions =
						from fx in appDbContext.FxTransactions
						join mg in appDbContext.MgeBtransactionConfirmations on fx.RefNo equals mg.ReferenceNumber
						where (fx.TransCode == 4
								&& fx.DeletionStatus != "D"
								&& mg.DeleteDate == null
								&& EF.Functions.DateDiffDay(fx.ContractDateOpe, targetDate) == 0
								&& EF.Functions.DateDiffDay(fx.DelivaryDate, targetDate) == 0
							   )
						select new
						{
							fx.RefNo,
						};


			var AllTranslastLogID = from log in appDbContext.FxConfirmationLogs
									join fx in allWithMgebTransactions on log.ReferenceNumber equals fx.RefNo
									group log by log.ReferenceNumber into g
									select new
									{
										ReferenceNumber = g.Key,
										LogId = g.Max(x => x.Id)

									};

			var TodayTranslastLogID = from log in appDbContext.FxConfirmationLogs
									  join fx in todayWithMgebTransactions on log.ReferenceNumber equals fx.RefNo
									  group log by log.ReferenceNumber into g
									  select new
									  {
										  ReferenceNumber = g.Key,
										  LogId = g.Max(x => x.Id)
									  };

			// for log with "MGeBPending", "Sent", "MGeBReject"
			List<string> expectedStatus = new() { "MGeBPending", "Sent", "MGeBReject" };
			var AllCount123 = (from l in appDbContext.FxConfirmationLogs
                           join lastId in AllTranslastLogID on l.Id equals lastId.LogId
                           join s in appDbContext.FxConfirmationStatuses on l.FxConfirmationStatusId equals s.Id
                           where expectedStatus.Contains(s.Status)
						   select l.Id).Count();


			var TodayCount123 = (from l in appDbContext.FxConfirmationLogs
						   join lastId in AllTranslastLogID on l.Id equals lastId.LogId
						   join s in appDbContext.FxConfirmationStatuses on l.FxConfirmationStatusId equals s.Id
						   where expectedStatus.Contains(s.Status)
						   select l.Id).Count();



            // Part II -  for No confirmation logs
            var AllCount4 = (from fx in appDbContext.FxTransactions
                             join l in appDbContext.FxConfirmationLogs on fx.RefNo equals l.ReferenceNumber
                             where (fx.TransCode == 4
                                 && fx.DeletionStatus != "D"
                                 && l.Id == null
                                 && EF.Functions.DateDiffDay(fx.ContractDateOpe, targetDate) == 0
                              )
                            select fx.RefNo).Count();


			var TodayCount4 = (from fx in appDbContext.FxTransactions
							join l in appDbContext.FxConfirmationLogs on fx.RefNo equals l.ReferenceNumber
							where (fx.TransCode == 4
								&& fx.DeletionStatus != "D"
								&& l.Id == null
								&& EF.Functions.DateDiffDay(fx.ContractDateOpe, targetDate) == 0
								&& EF.Functions.DateDiffDay(fx.DelivaryDate, targetDate) == 0
							   )
							   select fx.RefNo).Count();


			// Part III : without Mgeb confirmation
			var allWithoutMgebTransactions =
						from fx in appDbContext.FxTransactions
						join mg in appDbContext.MgeBtransactionConfirmations on fx.RefNo equals mg.ReferenceNumber
						where (fx.TransCode == 4
								&& fx.DeletionStatus != "D"
								&& mg.Id == null
								)
						select new
						{
							fx.RefNo,
						};

			var todayWithoutMgebTransactions =
						from fx in appDbContext.FxTransactions
						join mg in appDbContext.MgeBtransactionConfirmations on fx.RefNo equals mg.ReferenceNumber
						where (fx.TransCode == 4
								&& fx.DeletionStatus != "D"
								&& mg.Id == null
								&& EF.Functions.DateDiffDay(fx.DelivaryDate, targetDate) == 0
							   )
						select new
						{
							fx.RefNo,
						};

			var AllWithoutTranslastLogID = from log in appDbContext.FxConfirmationLogs
									join fx in allWithMgebTransactions on log.ReferenceNumber equals fx.RefNo
									group log by log.ReferenceNumber into g
									select new
									{
										ReferenceNumber = g.Key,
										LogId = g.Max(x => x.Id)

									};

			var TodayWithoutTranslastLogID = from log in appDbContext.FxConfirmationLogs
									  join fx in todayWithMgebTransactions on log.ReferenceNumber equals fx.RefNo
									  group log by log.ReferenceNumber into g
									  select new
									  {
										  ReferenceNumber = g.Key,
										  LogId = g.Max(x => x.Id)
									  };

			// for FinalStatus='Pending' and no MgebConfirm
			var AllCount5 = (from l in appDbContext.FxConfirmationLogs
							 join lastId in AllWithoutTranslastLogID on l.Id equals lastId.LogId
							 join s in appDbContext.FxConfirmationStatuses on l.FxConfirmationStatusId equals s.Id
                             where s.FinalStatus == "Pending"
							 select l.Id).Count();

			var TodayCount5 = (from l in appDbContext.FxConfirmationLogs
							 join lastId in TodayWithoutTranslastLogID on l.Id equals lastId.LogId
							 join s in appDbContext.FxConfirmationStatuses on l.FxConfirmationStatusId equals s.Id
							 where s.FinalStatus == "Pending"
							 select l.Id).Count();

            var AllTotal = AllCount123 + AllCount4 + AllCount5;
            var TodayTotal = TodayCount123 + TodayCount4 + TodayCount5;


            var results = new StatusCounterSameDayDTO()
            {
				Status = "Unconfirmaed",
				Description = "Unconfirmaed",
				Count = AllTotal,
                SameDayCount = TodayTotal
			};

			// Stop the Stopwatch after the query execution
			stopwatch.Stop();

			//Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds} ms");
			_logger.LogInformation($"Execution Time of CountFxUnconfirmatedStatus(): {stopwatch.ElapsedMilliseconds} ms");

			return results;
        }


	

        // This is the original codes extracted from GUIDE FXtranaction business class
        // Reference only
        // Abandon!!! - Over complicated, Embended SQL with some of bugs
        // B. Ll
        public List<TransactionConfirmationStatusCountDTO> CountTransactionConfirmationStatus(DateTime targetDate)
        {
            //int threshold = 30; // minutes

            var transOptions = new TransactionOptions()
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            };

            using var scope = new TransactionScope(TransactionScopeOption.Required, transOptions);
            using var guideContext = appDbContext;

            var mgebContractDateQuery = string.Format(@"
                        select *
						from FxConfirmationLog l (nolock)
						where l.id in ( 
							select max(id) 
							from FxConfirmationLog (nolock)
							where ReferenceNumber in ( 
								select m.ReferenceNumber 
								from FX_TRANSACTION fx (nolock)
								join MGeBTransactionConfirmation m (nolock) on fx.REF_NO = m.ReferenceNumber and m.DeleteDate is null
								where fx.TransCode=4
								and fx.DELETION_STATUS != 'D'
								and fx.CONTRACT_DATE_OPE = @targetDate 
						)
						group by ReferenceNumber )");

            //var mgebContractDateResults = guideContext.FxConfirmationLogs.SqlQuery(mgebContractDateQuery, new SqlParameter("@targetDate", targetDate)).ToList();

            //int mgebPendingContractTodayCount = mgebContractDateResults.Count(c => c.FxConfirmationStatusID == (int)FxConfirmationStatusType.MGeBPending);
            //int mgebSentContractTodayCount = mgebContractDateResults.Count(c => c.FxConfirmationStatusID == (int)FxConfirmationStatusType.Sent);
            //int mgebAcceptContractTodayCount = mgebContractDateResults.Count(c => c.FxConfirmationStatusID == (int)FxConfirmationStatusType.MGeBAccept);
            //int mgebRejectContractTodayCount = mgebContractDateResults.Count(c => c.FxConfirmationStatusID == (int)FxConfirmationStatusType.MGeBReject);

            var mgebDeliveryDateQuery = string.Format(@"
                        select *
						from FxConfirmationLog l (nolock)
						where l.id in ( 
							select max(id) 
							from FxConfirmationLog (nolock)
							where ReferenceNumber in ( 
								select m.ReferenceNumber 
								from FX_TRANSACTION fx (nolock)
								join MGeBTransactionConfirmation m (nolock) on fx.REF_NO = m.ReferenceNumber and m.DeleteDate is null
								where fx.TransCode=4
								and fx.DELETION_STATUS != 'D'
								and fx.CONTRACT_DATE_OPE = @targetDate 
								and fx.DELIVARY_DATE = @targetDate 
						)
						group by ReferenceNumber )");

            //var mgebDeliveryDateResults = guideContext.FxConfirmationLogs.SqlQuery(mgebDeliveryDateQuery, new SqlParameter("@targetDate", targetDate)).ToList();
            //int mgebPendingDeliveryTodayCount = mgebDeliveryDateResults.Count(c => c.FxConfirmationStatusID == (int)FxConfirmationStatusType.MGeBPending);
            //int mgebSentDeliveryTodayCount = mgebDeliveryDateResults.Count(c => c.FxConfirmationStatusID == (int)FxConfirmationStatusType.Sent);
			//int mgebRejectDeliveryTodayCount = mgebDeliveryDateResults.Count(c => c.FxConfirmationStatusID == (int)FxConfirmationStatusType.MGeBReject);



			//int mgebAcceptDeliveryTodayCount = mgebDeliveryDateResults.Count(c => c.FxConfirmationStatusID == (int)FxConfirmationStatusType.MGeBAccept);
        

            var nonMgebPendingDeliveryDateQuery = string.Format(@"
                            select *
							from FX_TRANSACTION fx (nolock)
							left join FxConfirmationLog l (nolock) on fx.REF_NO = l.ReferenceNumber
							where fx.TransCode=4
							and fx.DELETION_STATUS != 'D'
							and l.ID is null
							and fx.DELIVARY_DATE = @targetDate");

            //int nonMgebPendingDeliveryDateCount = guideContext.FXTransactions.SqlQuery(nonMgebPendingDeliveryDateQuery, new SqlParameter("@targetDate", targetDate)).Count();


            var nonMgebPendingDeliveryDateWithStatusQuery = string.Format(@"
						select l.*
						from FxConfirmationLog l
						join FxConfirmationStatus s on s.ID = l.FxConfirmationStatusID
						where s.FinalStatus = 'Pending'
						and l.id in (
						    select max(l.id)
						    from FX_TRANSACTION fx (nolock)
						    left join MGeBTransactionConfirmation m (nolock) on m.ReferenceNumber = fx.REF_NO
						    join FxConfirmationLog l (nolock) on fx.REF_NO = l.ReferenceNumber
						    where fx.TransCode = 4
						    and fx.DELETION_STATUS != 'D'
						    and m.ID is null
						    and fx.DELIVARY_DATE = @targetDate
						    group by l.ReferenceNumber
						)");

            //int nonMgebPendingDeliveryDateWithStatuscount = guideContext.FxConfirmationLogs.SqlQuery(nonMgebPendingDeliveryDateWithStatusQuery, new SqlParameter("@targetDate", targetDate)).Count();


            //nonMgeb that don't have status override
            var nonMgebPendingAllTimeQuery = string.Format(@"
                            select *
							from FX_TRANSACTION fx (nolock)
							left join FxConfirmationLog l (nolock) on fx.REF_NO = l.ReferenceNumber
							where fx.TransCode=4
							and fx.DELETION_STATUS != 'D'
							and l.ID is null");

            //int nonMgebPendingAllTimeCount = guideContext.FXTransactions.SqlQuery(nonMgebPendingAllTimeQuery).Count();


            //mgeb + nonMgeb that had status override
            var mGeBNonMGeBPendingAllTimeQuery = string.Format(@"
                                select g.*
								from FxConfirmationLog g (nolock)
								join FxConfirmationStatus s (nolock)on g.FxConfirmationStatusID = s.ID
								where g.id in (
										select max(l.ID)
										from FX_TRANSACTION fx (nolock)
										join FxConfirmationLog l (nolock) on fx.REF_NO = l.ReferenceNumber
										where fx.TransCode=4
										and fx.DELETION_STATUS!='D'
										group by fx.REF_NO
									)
								and s.FinalStatus='Pending'");

            // int mGeBNonMGeBPendingAllTimeCount = guideContext.FxConfirmationLogs.SqlQuery(mGeBNonMGeBPendingAllTimeQuery).Count();

            // int unconfirmedTradesAllTimeCount = nonMgebPendingAllTimeCount + mGeBNonMGeBPendingAllTimeCount;

			//int unconfirmedDeliveryTodayCount = mgebPendingDeliveryTodayCount + mgebSentDeliveryTodayCount 
           //                                             + mgebRejectDeliveryTodayCount 
           //                                             + nonMgebPendingDeliveryDateCount 
           //                                             + nonMgebPendingDeliveryDateWithStatuscount;



            //string mgebPendingContractTodaySearchCriteria =
            //    string.Format("channel={0}&fxStatuses={1}&fromContractDate={2}&toContractDate={2}",
            //    (int)DistributionChannelType.MGeB,
            //    (int)FxConfirmationStatusType.MGeBPending,
            //    targetDate.ToString("dd-MM-yyyy"));

            //string mgebSentContractTodaySearchCriteria =
            //    string.Format("channel={0}&fxStatuses={1}&fromContractDate={2}&toContractDate={2}",
            //                    (int)DistributionChannelType.MGeB,
            //                    (int)FxConfirmationStatusType.Sent,
            //                    targetDate.ToString("dd-MM-yyyy"));
            //string mgebAcceptContractTodaySearchCriteria =
            //    string.Format("channel={0}&fxStatuses={1}&fromContractDate={2}&toContractDate={2}",
            //                    (int)DistributionChannelType.MGeB,
            //                    (int)FxConfirmationStatusType.MGeBAccept,
            //                    targetDate.ToString("dd-MM-yyyy"));
            //string mgebRejectContractTodaySearchCriteria =
            //    string.Format("channel={0}&fxStatuses={1}&fromContractDate={2}&toContractDate={2}",
            //                    (int)DistributionChannelType.MGeB,
            //                    (int)FxConfirmationStatusType.MGeBReject,
            //                    targetDate.ToString("dd-MM-yyyy"));
            //string mgebPendingDeliveryTodaySearchCriteria =
            //    string.Format("channel={0}&fxStatuses={1}&fromContractDate={2}&toContractDate={2}&fromValueDate={2}&toValueDate={2}",
            //                    (int)DistributionChannelType.MGeB,
            //                    (int)FxConfirmationStatusType.MGeBPending,
            //                    targetDate.ToString("dd-MM-yyyy"));
            //string mgebSentDeliveryTodaySearchCriteria =
            //    string.Format("channel={0}&fxStatuses={1}&fromContractDate={2}&toContractDate={2}&fromValueDate={2}&toValueDate={2}",
            //                    (int)DistributionChannelType.MGeB,
            //                    (int)FxConfirmationStatusType.Sent,
            //                    targetDate.ToString("dd-MM-yyyy"));
            //string mgebAcceptDeliveryTodaySearchCriteria =
            //    string.Format("channel={0}&fxStatuses={1}&fromContractDate={2}&toContractDate={2}&fromValueDate={2}&toValueDate={2}",
            //                    (int)DistributionChannelType.MGeB,
            //                    (int)FxConfirmationStatusType.MGeBAccept,
            //                    targetDate.ToString("dd-MM-yyyy"));
            //string mgebRejectDeliveryTodaySearchCriteria =
            //    string.Format("channel={0}&fxStatuses={1}&fromContractDate={2}&toContractDate={2}&fromValueDate={2}&toValueDate={2}",
            //                    (int)DistributionChannelType.MGeB,
            //                    (int)FxConfirmationStatusType.MGeBReject,
            //                    targetDate.ToString("dd-MM-yyyy"));

            //string unconfirmedTradesAllTimeSearchCriteria = "finalStatus=P";

            string unconfirmedDeliveryTodaySearchCriteria =
                    string.Format("finalStatus=P&fromValueDate={0}&toValueDate={0}",
                                  targetDate.ToString("dd-MM-yyyy"));


            var results = new List<TransactionConfirmationStatusCountDTO>();

            //var s1 = new TransactionConfirmationStatusCountDTO()
            //{
            //    StatusId = (int)FxConfirmationStatusType.MGeBPending,
            //    StatusCode = "MGeB Pending",
            //    Channel = (int)DistributionChannelType.MGeB,
            //    Status_1_Count = mgebPendingContractTodayCount,
            //    Status_2_Count = mgebPendingDeliveryTodayCount,
            //    Status_1_SearchCriteria = mgebPendingContractTodaySearchCriteria,
            //    Status_2_SearchCriteria = mgebPendingDeliveryTodaySearchCriteria
            //};
            //results.Add(s1);

            //var s2 = new TransactionConfirmationStatusCountDTO()
            //{
            //    StatusId = (int)FxConfirmationStatusType.Sent,
            //    StatusCode = "MGeB Sent",
            //    Channel = (int)DistributionChannelType.MGeB,
            //    Status_1_Count = mgebSentContractTodayCount,
            //    Status_2_Count = mgebSentDeliveryTodayCount,
            //    Status_1_SearchCriteria = mgebSentContractTodaySearchCriteria,
            //    Status_2_SearchCriteria = mgebSentDeliveryTodaySearchCriteria
            //};
            //results.Add(s2);

            //var s3 = new TransactionConfirmationStatusCountDTO()
            //{
            //    StatusId = (int)FxConfirmationStatusType.MGeBReject,
            //    StatusCode = "MGeB Rejected",
            //    Channel = (int)DistributionChannelType.MGeB,
            //    Status_1_Count = mgebRejectContractTodayCount,
            //    Status_2_Count = mgebRejectDeliveryTodayCount,
            //    Status_1_SearchCriteria = mgebRejectContractTodaySearchCriteria,
            //    Status_2_SearchCriteria = mgebRejectDeliveryTodaySearchCriteria
            //};
            //results.Add(s3);

            //var s4 = new TransactionConfirmationStatusCountDTO()
            //{
            //    StatusId = (int)FxConfirmationStatusType.MGeBAccept,
            //    StatusCode = "MGeB Accepted",
            //    Channel = (int)DistributionChannelType.MGeB,
            //    Status_1_Count = mgebAcceptContractTodayCount,
            //    Status_2_Count = mgebAcceptDeliveryTodayCount,
            //    Status_1_SearchCriteria = mgebAcceptContractTodaySearchCriteria,
            //    Status_2_SearchCriteria = mgebAcceptDeliveryTodaySearchCriteria
            //};
            //results.Add(s4);

            //var s5 = new TransactionConfirmationStatusCountDTO()
            //{
            //    StatusCode = "Unconfirmed Trades (All)",
            //    FinalStatus = "P",
            //    Status_1_Count = unconfirmedTradesAllTimeCount,
            //    Status_2_Count = unconfirmedDeliveryTodayCount,
            //    Status_1_SearchCriteria = unconfirmedTradesAllTimeSearchCriteria,
            //    Status_2_SearchCriteria = unconfirmedDeliveryTodaySearchCriteria
            //};
            //results.Add(s5);

            scope.Complete();

            return results;
        }







        // The following 6 functions are from online converter between SQL query and EF & Linq
        // Do not use please
        //1
        //public List<TransactionConfirmationStatusCountDTO> mgebContractDateQuery(DateTime targetDate)
        //{
        //    var referenceNumbers = appDbContext.FxTransactions
        //                            .Where(fx => fx.TransCode == 4
        //                                    && fx.DeletionStatus != "D"
        //                                    && fx.ContractDateOpe == targetDate)
        //                            .Join(appDbContext.MgeBtransactionConfirmations
        //                                .Where(mg => mg.DeleteDate == null), fx => fx.RefNo, mg => mg.ReferenceNumber,
        //                                            (fx, mg) => mg.ReferenceNumber)
        //                            .Distinct();

        //   var maxIds = appDbContext.FxConfirmationLogs
        //            .Where(fxLog => referenceNumbers.Contains(fxLog.ReferenceNumber))
        //            .GroupBy(fxLog => fxLog.ReferenceNumber)
        //            .Select(g => g.OrderByDescending(fxLog => fxLog.Id).FirstOrDefault().Id);

        //  var result = appDbContext.FxConfirmationLogs
        //            .Where(fxLog => maxIds.Contains(fxLog.Id))
        //            .ToList();

        //    return new List<TransactionConfirmationStatusCountDTO>();
        //}

        //2
        //public List<TransactionConfirmationStatusCountDTO> mgebDeliveryDateQuery(DateTime targetDate)
        //{
        //    var query = from fx in appDbContext.FxTransactions
        //                join m in appDbContext.MgeBtransactionConfirmations on fx.RefNo equals m.ReferenceNumber
        //                where m.DeleteDate == null
        //                    && fx.TransCode == 4
        //                    && fx.DeletionStatus != "D"
        //                    && fx.ContractDateOpe == targetDate
        //                    && fx.DelivaryDate == targetDate
        //                select m.ReferenceNumber;

        //    var referenceNumbers = query.Distinct();

        //    var maxIds = from fxLog in appDbContext.FxConfirmationLogs
        //                 where referenceNumbers.Contains(fxLog.ReferenceNumber)
        //                 group fxLog by fxLog.ReferenceNumber into g
        //                 select new
        //                 {
        //                     ReferenceNumber = g.Key,
        //                     MaxId = g.Max(x => x.Id)
        //                 };

        //    var result = from fxLog in appDbContext.FxConfirmationLogs
        //                 where maxIds.Select(x => x.MaxId).Contains(fxLog.Id)
        //                 select fxLog;

        //    return new List<TransactionConfirmationStatusCountDTO>();
        //}


        //3
        //public List<TransactionConfirmationStatusCountDTO> nonMgebPendingDeliveryDateQuery(DateTime targetDate)
        //{
        //    var result = appDbContext.FxConfirmationLogs
        //                .Where(l => appDbContext.FxConfirmationLogs
        //                .Where(l2 => appDbContext.FxTransactions
        //                .Join(appDbContext.MgeBtransactionConfirmations,
        //                            fx => fx.RefNo,
        //                            m => m.ReferenceNumber,
        //                            (fx, m) => new { fx, m })
        //                .Where(joined => joined.fx.TransCode == 4
        //                && joined.fx.DeletionStatus != "D"
        //                && joined.fx.ContractDateOpe == targetDate
        //                && joined.fx.DelivaryDate == targetDate
        //                && joined.m.DeleteDate == null)
        //                .Select(joined => joined.m.ReferenceNumber)
        //                .Contains(l2.ReferenceNumber))
        //                .GroupBy(l2 => l2.ReferenceNumber)
        //                .Select(g => g.Max(l2 => l2.Id))
        //                .Contains(l.Id))
        //                .ToList();
        //    return new List<TransactionConfirmationStatusCountDTO>();
        //}


        // 4
        //public List<TransactionConfirmationStatusCountDTO> nonMgebPendingDeliveryDateWithStatusQuery(DateTime targetDate)
        //{
        //    var subquery = from fx in appDbContext.FxTransactions
        //                   .Where(fx => fx.TransCode == 4 && fx.DeletionStatus != "D" && fx.DelivaryDate == targetDate)
        //                   join mg in appDbContext.MgeBtransactionConfirmations on fx.RefNo equals mg.ReferenceNumber into mGroup
        //                   from mg in mGroup.DefaultIfEmpty()
        //                   where mg.Id == null
        //                   group fx by fx.RefNo into g
        //                   select g.OrderByDescending(fx => fx.ID).FirstOrDefault().Id;

        //    var result = from l in appDbContext.FxConfirmationLogs
        //                 join s in appDbContext.FxConfirmationStatuses on l.FxConfirmationStatusId equals s.Id
        //                 where s.FinalStatus == "Pending" && subquery.Contains(l.Id)
        //                 select l;

        //    return result.ToList();

        //    return new List<TransactionConfirmationStatusCountDTO>();
        //}


        // 5
        //public List<TransactionConfirmationStatusCountDTO> nonMgebPendingAllTimeQuery(DateTime targetDate)
        //{
        //    var result = from fx in appDbContext.FxTransactions
        //                 join l in appDbContext.FxConfirmationLogs
        //                 on fx.RefNo equals l.ReferenceNumber into leftJoin
        //                 from l in leftJoin.DefaultIfEmpty() // This performs the left join
        //                 where fx.TransCode == 4
        //                 && fx.DeletionStatus != "D"
        //                 && l.Id == null // This checks for nulls in the left join
        //                 select fx; // Select the FX_TRANSACTION entity

        //    var transactions = result.ToList();
        //    return new List<TransactionConfirmationStatusCountDTO>();
        //}


        //6
        //public List<TransactionConfirmationStatusCountDTO> mGeBNonMGeBPendingAllTimeQuery(DateTime targetDate)
        //{
        //    var query = from g in appDbContext.FxConfirmationLogs
        //                join s in appDbContext.FxConfirmationStatuses on g.FxConfirmationStatusId equals s.Id
        //                where g.Id == (from l in appDbContext.FxConfirmationLogs
        //                               join fx in appDbContext.FxTransactions on l.ReferenceNumber equals fx.RefNo
        //                               where fx.TransCode == 4 && fx.DeletionStatus != "D"
        //                               group l by fx.RefNo into grouped
        //                               select grouped.Max(x => x.ID)
        //                       )
        //                        && s.FinalStatus == "Pending"
        //                select g;

        //    var result = query.ToList();
        //    return new List<TransactionConfirmationStatusCountDTO>();
        //}


























        //public object GetFxConfirmationStatuses()
        //{
        //    //using (var guideContext = new GUIDEEntities())
        //    //{
        //    //[Table("FX_TRANSACTION_Confirmation")]
        //    return appDbContext.FxTransactionConfirmations.Select(s => s).OrderBy(o => o.DisplayText).ToList();
        //    // }
        //}

        //public object GetFxConfirmationFinalStatuses()
        //{
        //    //using (var guideContext = new GUIDEEntities())
        //    //{
        //    //[Table("FX_TRANSACTION_Confirmation")]
        //    return appDbContext.FxTransactionConfirmations.Select(s => s.FinalStatus).Distinct().Select(s => new
        //    {
        //        Name = s,
        //        Value = s.Substring(0, 1)
        //    }).ToList();
        //    //}
        //}








    }
}
