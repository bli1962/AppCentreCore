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
    public class FXDeliveryCountRepository : IFXDeliveryCount
	{
		private readonly GUIDEDbContext appDbContext;
		private readonly IConfiguration _configuration;
		private readonly ILogger<FXDeliveryCountRepository> _logger;

		private readonly string _statusE1;
		private readonly string _statusE2;
		private readonly string _statusE3;
		private readonly string _statusGIPE1;
		private readonly string _statusGIPE2;
		private readonly string _statusGIPE3;

		public FXDeliveryCountRepository(ILogger<FXDeliveryCountRepository> logger,
										IConfiguration configuration,
										GUIDEDbContext appDbContext)
		{
			this._logger = logger;
			this.appDbContext = appDbContext;
			this._configuration = configuration;

			_statusE1 = _configuration["DeliveryErrorStatus:E1"];
			_statusE2 = _configuration["DeliveryErrorStatus:E2"];
			_statusE3 = _configuration["DeliveryErrorStatus:E3"];

			_statusGIPE1 = _configuration["DeliveryErrorStatus:GIPE1"];
			_statusGIPE2 = _configuration["DeliveryErrorStatus:GIPE2"];
			_statusGIPE3 = _configuration["DeliveryErrorStatus:GIPE3"];
		}

		public List<StatusCounterDTO> GetFxDeliveriesStatusCount(string strDate)
		{
			var transOptions = new TransactionOptions() { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted };

			//using var scope = new TransactionScope(TransactionScopeOption.Required, transOptions);
			Stopwatch stopwatch = new();
			stopwatch.Start();

			var list = new List<StatusCounterDTO>();

            //E1 ERRORS 'ReUpload' 
            var deliveryStatusInE1 = new List<string>(_statusE1.Split(new char[] {';' }));
            var deliveryGipStatusInE1 = new List<string>(_statusGIPE1.Split(new char[] {';' }));

            //E2 ERRORS 'Reset to verify'
            var deliveryStatusInE2 = new List<string>(_statusE2.Split(new char[] {';' }));
            var deliveryGipStatusInE2 = new List<string>(_statusGIPE2.Split(new char[] {';' }));

            //E3 ERRORS 'GBase ReApprove' 
            var deliveryStatusInE3 = new List<string>(_statusE3.Split(new char[] {';' }));
            var deliveryGipStatusNotInE3 = new List<string>(_statusGIPE3.Split(new char[] {';' }));

            list = CountFxDeliveriesInStatus(strDate, deliveryGipStatusInE2);
            list.Add(new StatusCounterDTO
            {
                Count = CountFxDeliveryErrorE1(deliveryStatusInE1, deliveryGipStatusInE1, strDate).Count(),
                Status = "E1",
                Description = "E1 - ReUpload"
            });

            list.Add(new StatusCounterDTO
            {
                Count = CountFxDeliveryErrorE2(deliveryStatusInE2, deliveryGipStatusInE2, strDate).Count(),
                Status = "E2",
                Description = "E2 - Reset to verify"
            });


            list.Add(new StatusCounterDTO
            {
                Count = CountFxDeliveryErrorE3(deliveryStatusInE3, deliveryGipStatusNotInE3, strDate).Count(),
                Status = "E3",
                Description = "E3 - GBase ReApprove"
            });

			//scope.Complete();
			stopwatch.Stop();
			_logger.LogInformation($"Execution Time of GetFxDeliveriesStatusCount(): {stopwatch.ElapsedMilliseconds} ms");

			return list;
        }


		public List<StatusCounterDTO> CountFxDeliveriesInStatus(string strDate, List<string> cGipStatusIn)
		{
			List<StatusCounterDTO> lstStatus = new ()
						{
							new StatusCounterDTO() {Count = 0, Status = "V", Description = "Verify", Order =1},
							new StatusCounterDTO() {Count = 0, Status = "A", Description = "Authorise", Order =2 },
							new StatusCounterDTO() {Count = 0, Status = "F", Description = "Finalised", Order =3},				
							new StatusCounterDTO() {Count = 0, Status = "D", Description = "Delete Pending", Order =4},
                            new StatusCounterDTO() {Count = 0, Status = "C", Description = "Deleted", Order =5},
							//new StatusCounterDTO() {Count = 0, Status = "E", Description = "Error", Order =6},
							new StatusCounterDTO() {Count = 0, Status = "S", Description = "Submit", Order =6}
						};

			if (!(strDate != null)) return new List<StatusCounterDTO>();
			DateTime dtDate = DateTime.Parse(strDate);
			var optionsNotIn = new int?[] { 2, 11, 13 };

			var transOptions = new TransactionOptions() { IsolationLevel = IsolationLevel.ReadUncommitted };
            using var scope = new TransactionScope(TransactionScopeOption.Required, transOptions);

            var list = new List<StatusCounterDTO>();

            // To translate the logic of "Status"
            var query = (from s in appDbContext.FxSettlementInfs
                         join f in appDbContext.FxTransactions on s.RefNo equals f.RefNo
                         where (f.Status == "F" && f.TranNo != "" && f.DeletionStatus != "D")                                
                                && (s.GipDescription != "AUTO SETTLED BY GBASE")
                                && (s.CustAbbr != "MHCB SY")
                                && (s.CustAbbr != "MHCB HO")
                                && (s.CustAbbr != "999")
                                && (EF.Functions.DateDiffDay(f.DelivaryDate, dtDate) == 0)
                                && !cGipStatusIn.Contains(s.GipStatus.Trim())
                         // add this in order to exclude interbank auto delivery
                         //&& (EF.Functions.DateDiffDay(s.AddOn, dtDate) == 0) 
                         select new     //FxTransactionSelectDTO()
                         {
                             s.RefNo,
                             ContractDateValue = (DateTime)f.ContractDateValue,
                             DelivaryDate = (DateTime)f.DelivaryDate,
                             Status = (s.DeletionStatus == "D" && s.Status == "F") ? "C"
                                    : (s.DeletionStatus == "D" && s.Status != "F") ? "D"
                                    : (s.GipStatus == "" && s.Status == "S") ? "S"
                                    : s.Status,
                             s.DeletionStatus,
                             s.GipStatus,
                             s.GipDescription,
                             s.TranNo,
                             OptionsFlag = (int)f.OptionsFlag,
                             s.CustAbbr,
                             //CounterpartyTypeID = Mxtype.CounterpartyTypeId
                         });

            // To grouping of "Status"
            var queryGroup = (from b in query.Distinct().ToList()
                              group b by b.Status into statusGroup
                              select new    //StatusCounterDTO
                              {
                                  Status = statusGroup.Key,
                                  Count = (statusGroup == null) ? 0 : statusGroup.Count()
                              });

            // make sure that if there is no statuses then they return the statuses with a result of 0.
            var results = (from s in lstStatus
                           join q in queryGroup.ToList() on s.Status equals q.Status into completeList
                           from leftJoinQuery in completeList.DefaultIfEmpty()
                           orderby s.Order
                           select new StatusCounterDTO
                           {
                               Status = s.Status,
                               Description = s.Description,
                               Count = (leftJoinQuery == null) ? 0 : leftJoinQuery.Count
                           })
                          .ToList();

            scope.Complete();
            return results.ToList().ConvertAll(i => (StatusCounterDTO)i);
        }

        private List<SelectedFxDTO> CountFxDeliveryErrorE1(List<string> cStatusIn, List<string> cGipStatusIn,
                                    string strDate)
        {
			// original code
            //var QueryE1 = guideContext.FXSettlementInfs
            //	   .Where(s => deliveryGipStatusInE1.Contains(s.GIP_STATUS.Trim())
            //				&& deliveryStatusInE1.Contains(s.STATUS.Trim()) && s.TRAN_NO == "")
            //	   .Where(s => s.FXTransaction.CUSTOMER_MASTER != null)
            //	   .Where(s => s.FXTransaction.DELETION_STATUS != "D")         // exclude the deleted Transaction
            //	   .Where(s => DbFunctions.DiffMinutes(s.AUTHORIZE_ON, DateTime.Now) > 5)
            //	   .Select(s => s.FXTransaction);

            if (!(strDate != null)) return new List<SelectedFxDTO>();
            DateTime dtDate = DateTime.Parse(strDate);


            // referene : E1 - where STATUS in ('S', 'Q'), TRAN_NO == ""
            var entry = (from s in appDbContext.FxSettlementInfs
                         join f in appDbContext.FxTransactions on s.RefNo equals f.RefNo
                         where EF.Functions.DateDiffDay(s.AuthorizeOn, dtDate) == 0
                                && cStatusIn.Contains(s.Status.Trim())
                                && cGipStatusIn.Contains(s.GipStatus.Trim())
                                && s.DeletionStatus.Trim() != "D"
                                && s.TranNo.Trim() == ""
							     //&& (!s.CustAbbr.Contains("NO GBASE"))
							     //&& (!s.CustAbbr.Contains("NODREAMINPU"))
							     //&& (!s.CustAbbr.Contains("999"))
                         select new SelectedFxDTO()
                         {
                             RefNo = s.RefNo,
                             Status = s.Status,
                             GipDescription = s.GipDescription,
                         })
                        .ToList();
            return entry;
        }


        private List<SelectedFxDTO> CountFxDeliveryErrorE2(List<string> cStatusIn, List<string> cGipStatusIn, 
											string strDate)
		{
			// original code
			//var QueryE2 = guideContext.FXSettlementInfs
			//		 .Where(s => deliveryGipStatusInE2.Contains(s.GIP_STATUS.Trim())
			//				  && deliveryStatusInE1.Contains(s.STATUS.Trim()) && s.TRAN_NO == "")
			//		 .Where(s => s.FXTransaction.CUSTOMER_MASTER != null)
			//		 .Where(s => s.FXTransaction.DELETION_STATUS != "D")         // exclude the deleted Transaction
			//		 .Select(s => s.FXTransaction);


			if (!(strDate != null)) return new List<SelectedFxDTO>();
			DateTime dtDate = DateTime.Parse(strDate);

            //E2 - where STATUS in ('S') and GIP_STATUS in (0,5,9,13,17,18,19,20,24), TRAN_NO == ""
            var entry = (from s in appDbContext.FxSettlementInfs
						 join f in appDbContext.FxTransactions on s.RefNo equals f.RefNo
						 where EF.Functions.DateDiffDay(s.AuthorizeOn, dtDate) == 0
                                && cStatusIn.Contains(s.Status.Trim())
                                && cGipStatusIn.Contains(s.GipStatus.Trim())                            
								&& s.DeletionStatus.Trim() != "D" 
								&& s.TranNo.Trim() == ""
                                //&& (!s.CustAbbr.Contains("NO GBASE"))
								//&& (!s.CustAbbr.Contains("NODREAMINPU"))
								//&& (!s.CustAbbr.Contains("999"))
						 select new SelectedFxDTO()
						 {
							 RefNo = s.RefNo,
                             Status = s.Status,
                             GipDescription = s.GipDescription,
						 })
						.ToList();
			return entry;
		}

		private List<SelectedFxDTO> CountFxDeliveryErrorE3(List<string> cStatusIn, List<string> cGipStatusNotIn,
										string strDate)
		{
            // original code
            //var QueryE3 = guideContext.FXSettlementInfs
            //		.Where(s => deliveryStatusInE3.Contains(s.STATUS.Trim())
            //			  && s.TRAN_NO != ""
            //			  && !optionsNotIn.Contains(s.FXTransaction.OptionsFlag.Value)
            //			  && !deliveryGipStatusNotInE3.Contains(s.GIP_STATUS.Trim())
            //			  )
            //		.Where(s => s.FXTransaction.CUSTOMER_MASTER != null)
            //		.Where(s => s.FXTransaction.DELETION_STATUS != "D")         // exclude the deleted Transaction
            //		.Select(s => s.FXTransaction);

            var optionsNotIn = new[] { 11, 13 };

            if (!(strDate != null)) return new List<SelectedFxDTO>();
			DateTime dtDate = DateTime.Parse(strDate);


            // reference : where STATUS ='F' and GIP_STATUS NOT in (8, 15, 21) and  TranNo != "" 
            var entry = (from s in appDbContext.FxSettlementInfs
						 join f in appDbContext.FxTransactions on s.RefNo equals f.RefNo
						 where EF.Functions.DateDiffDay(s.AuthorizeOn, dtDate) == 0
                                && cStatusIn.Contains(s.Status.Trim())
                                && !cGipStatusNotIn.Contains(s.GipStatus.Trim())
								&& !optionsNotIn.Contains(f.OptionsFlag.Value)                              
								&& s.DeletionStatus != "D" 
								&& s.TranNo != ""                                
                                //&& (!s.CustAbbr.Contains("NO GBASE"))
								//&& (!s.CustAbbr.Contains("NODREAMINPU"))
								//&& (!s.CustAbbr.Contains("999"))
						 select new SelectedFxDTO()
						 {
							 RefNo = s.RefNo,
                             Status = s.Status,
                             GipDescription = s.GipDescription,
						 })
						.ToList();
			return entry;
		}


		// To archive only
		private List<SelectedFxDTO> GetFxDeliveryByStatus(string cStatus, string strDate)
		{
			if (!(strDate != null)) return new List<SelectedFxDTO>();
			DateTime dtDate = DateTime.Parse(strDate);

			var entry = (from s in appDbContext.FxSettlementInfs
						 join f in appDbContext.FxTransactions on s.RefNo equals f.RefNo
						 where s.Status == cStatus
								//!validStatus.Contains(s.Status)
								&& (!s.CustAbbr.Contains("NO GBASE"))
								&& (!s.CustAbbr.Contains("NODREAMINPU"))
								&& (!s.CustAbbr.Contains("999"))
								&& (f.Status == "F" && f.TranNo != "")
								&& EF.Functions.DateDiffDay(f.DelivaryDate, dtDate) == 0
						 select new SelectedFxDTO()
						 {
							 RefNo = s.RefNo,
                             Status = (s.DeletionStatus != "D") ? s.Status : (s.Status == "F" && s.GipStatus == "8") ? "C" : "D",
                             GipDescription = s.GipDescription,
						 });

			var results = (from s in entry
						   where (s.Status == cStatus)
						   select s)
						  .ToList();

			return results;
		}
	}
}
