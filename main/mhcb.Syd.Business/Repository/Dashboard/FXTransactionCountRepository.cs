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
    public class FXTransactionCountRepository : IFXTransactionCount
    {
        private readonly GUIDEDbContext appDbContext;
        private readonly IConfiguration _configuration;
        private readonly ILogger<FXTransactionCountRepository> _logger;

        private readonly string _statusE1;
        private readonly string _statusE2;
        private readonly string _statusE3;
        private readonly string _statusGIPE1;
        private readonly string _statusGIPE2;
        private readonly string _statusGIPE3;

        public FXTransactionCountRepository(ILogger<FXTransactionCountRepository> logger,
                                        IConfiguration configuration,
                                        GUIDEDbContext appDbContext)
        {
            this._logger = logger;
            this.appDbContext = appDbContext;
            this._configuration = configuration;

            _statusE1 = _configuration["TransactionErrorStatus:E1"];
            _statusE2 = _configuration["TransactionErrorStatus:E2"];
            _statusE3 = _configuration["TransactionErrorStatus:E3"];

            _statusGIPE1 = _configuration["TransactionErrorStatus:GIPE1"];
            _statusGIPE2 = _configuration["TransactionErrorStatus:GIPE2"];
            _statusGIPE3 = _configuration["TransactionErrorStatus:GIPE3"];
        }

        public List<StatusCounterSameDayDTO> GetFxTransactionStatusCount(string strDate)
        {

            var transOptions = new TransactionOptions() { IsolationLevel = IsolationLevel.ReadUncommitted };

            using (var scope = new TransactionScope(TransactionScopeOption.Required, transOptions))
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                var list = new List<StatusCounterSameDayDTO>();

                list = CountFxTransactionInStatus(strDate);

                //E1 ERRORS 'ReUpload' 
                List<string> transactionStatusInE1 = new List<string>(_statusE1.Split(new char[] {';'}));
                List<string> transactionGipStatusInE1 = new List<string>(_statusGIPE1.Split(new char[] {';'}));

                //E2 ERRORS 'Reset to verify'
                List<string> transactionStatusInE2 = new List<string>(_statusE2.Split(new char[] {';'}));
                List<string> transactionGipStatusInE2 = new List<string>(_statusGIPE2.Split(new char[] {';'}));

                //E3 ERRORS 'GBase ReApprove' 
                //int[] transactionOptionsNotInE3 = new[] { 11, 13 };
                List<string> transactionStatusInE3 = new List<string>(_statusE3.Split(new char[] {';'}));
                List<string> transactionGipStatusNotInE3 = new List<string>(_statusGIPE3.Split(new char[] {';'}));

                list.Add(new StatusCounterSameDayDTO
                {
                    SameDayCount = CountFXTransErrorE1(transactionStatusInE1, transactionGipStatusInE1, strDate).Count(),
                    Count = 0,
                    Status = "E1",
                    Description = "E1 - ReUpload"
                });

                list.Add(new StatusCounterSameDayDTO
                {
                    SameDayCount = CountFXTransErrorE2(transactionStatusInE2, transactionGipStatusInE2, strDate).Count(),
                    Count = 0,
                    Status = "E2",
                    Description = "E2 - Reset to verify"
                });


                list.Add(new StatusCounterSameDayDTO
                {
                    SameDayCount = CountFXTransErrorE3(transactionStatusInE3, transactionGipStatusNotInE3, strDate).Count(),
                    Count = 0,
                    Status = "E3",
                    Description = "E3 - GBase ReApprove"
                });

                scope.Complete();

                stopwatch.Stop();

                //Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds} ms");
                _logger.LogInformation($"Execution Time of GetFxTransactionStatusCount(): {stopwatch.ElapsedMilliseconds} ms");

                return list;
            }
        }

        // this is the first method
        public List<StatusCounterSameDayDTO> CountFxTransactionInStatus(string strDate)
        {
            List<StatusCounterDTO> lstStatus = new()
                        {
                            new StatusCounterDTO() {Count = 0, Status = "V", Description = "Verify", Order = 1},
                            new StatusCounterDTO() {Count = 0, Status = "A", Description = "Authorise", Order = 2},
                            new StatusCounterDTO() {Count = 0, Status = "F", Description = "Finalised", Order = 3},
                            new StatusCounterDTO() {Count = 0, Status = "C", Description = "Deleted", Order = 5},
                            new StatusCounterDTO() {Count = 0, Status = "D", Description = "Delete Pending", Order = 4},
                            new StatusCounterDTO() {Count = 0, Status = "S", Description = "Submit", Order = 6}
                        };

            if (!(strDate != null)) return new List<StatusCounterSameDayDTO>();
            DateTime dtDate = DateTime.Parse(strDate);

            var optionsNotIn = new int?[] { 2, 11, 13 };

            var transOptions = new TransactionOptions() { IsolationLevel = IsolationLevel.ReadUncommitted };

            using var scope = new TransactionScope(TransactionScopeOption.Required, transOptions);

            var list = new List<StatusCounterDTO>();


            // To translate the logic of "Status"
            var TranslatedQueryAll = (from f in appDbContext.FxTransactions
                                      where !optionsNotIn.Contains(f.OptionsFlag)
                                            && EF.Functions.DateDiffDay(f.AddOn, dtDate) == 0
                                            && (f.CustAbbr != "MHCB SY")
                                            //&& (f.CustAbbr != "MHCB HO")
                                            //&& (f.CustAbbr != "999")
                                            && f.Status != "G"
                                      select new     //FxTransactionSelectDTO()
                                      {
                                          f.RefNo,
                                          ContractDateValue = (DateTime)f.ContractDateValue,
                                          DelivaryDate = (DateTime)f.DelivaryDate,
                                          Status = (f.DeletionStatus == "D" && f.Status == "F") ? "C"
                                                : (f.DeletionStatus == "D" && f.Status != "F") ? "D"
                                                : (f.GipStatus == "" && f.Status == "S") ? "S"
                                                : f.Status,
                                          f.DeletionStatus,
                                          f.GipStatus,
                                          f.GipDescription,
                                          f.TranNo,
                                          f.AddOn,
                                          OptionsFlag = (int)f.OptionsFlag,
                                          f.CustAbbr,
                                          //CounterpartyTypeID = Mxtype.CounterpartyTypeId
                                      });

            var TranslatedQueryToday = (from f in TranslatedQueryAll
                                        where EF.Functions.DateDiffDay(f.DelivaryDate, dtDate) == 0
                                        select f);

            var query1 = (from f in TranslatedQueryAll.Distinct().ToList()		//appDbContext.FxTransactions
                          where 1 == 1
                          group f by f.Status into queryGroup
                          select new
                          {
                              Status = queryGroup.Key,
                              TotalStatus = queryGroup.Count()
                          });

            var query2 = (from f in TranslatedQueryToday.Distinct().ToList()	//appDbContext.FxTransactions
                          where 1 == 1
                          group f by f.Status into queryGroup
                          select new
                          {
                              Status = queryGroup.Key,
                              TotalStatus = queryGroup.Count()
                          });

            var query = (from s in lstStatus
                         join q1 in query1 on s.Status equals q1.Status into completeList1
                         from leftJoinQuery1 in completeList1.DefaultIfEmpty()

                         join q2 in query2 on s.Status equals q2.Status into completeList2
                         from leftJoinQuery2 in completeList2.DefaultIfEmpty()

                         orderby s.Order
                         select new StatusCounterSameDayDTO()
                         {
                             Status = s.Status,
                             Description = s.Description,
                             SameDayCount = (leftJoinQuery2 == null) ? 0 : leftJoinQuery2.TotalStatus,
                             Count = (leftJoinQuery1 == null) ? 0 : leftJoinQuery1.TotalStatus
                         })
                        .ToList();

            scope.Complete();

            return query.ToList().ConvertAll(i => (StatusCounterSameDayDTO)i);
        }


        // this is the second method
        public List<StatusCounterSameDayDTO> CountFxTransactionInStatus1(string strDate)
        {
            List<StatusCounterDTO> lstStatus = new List<StatusCounterDTO>()
                        {
                            new StatusCounterDTO() {Count = 0, Status = "V", Description = "Verify", Order = 1},
                            new StatusCounterDTO() {Count = 0, Status = "A", Description = "Authorise", Order = 2},
                            new StatusCounterDTO() {Count = 0, Status = "F", Description = "Finalised", Order = 3},
                            new StatusCounterDTO() {Count = 0, Status = "C", Description = "Deleted", Order = 5},
                            new StatusCounterDTO() {Count = 0, Status = "D", Description = "Delete Pending", Order = 4},
                            new StatusCounterDTO() {Count = 0, Status = "S", Description = "Submit", Order = 6}
                        };

            if (!(strDate != null)) return new List<StatusCounterSameDayDTO>();
            DateTime dtDate = DateTime.Parse(strDate);

            var optionsNotIn = new int?[] { 2, 11, 13 };

            var transOptions = new TransactionOptions() { IsolationLevel = IsolationLevel.ReadUncommitted };

            using (var scope = new TransactionScope(TransactionScopeOption.Required, transOptions))
            {
                var list = new List<StatusCounterDTO>();

                var query = (from s in lstStatus
                             let OperationDateCount = (from f in appDbContext.FxTransactions
                                                       where EF.Functions.DateDiffDay(f.AddOn, dtDate) == 0
                                                              && !optionsNotIn.Contains(f.OptionsFlag)
                                                              && s.Status == f.Status
                                                       select 1).Count()

                             let sameDayCount = (from f in appDbContext.FxTransactions
                                                 where EF.Functions.DateDiffDay(f.AddOn, dtDate) == 0
                                                        && EF.Functions.DateDiffDay(f.DelivaryDate, dtDate) == 0
                                                        && !optionsNotIn.Contains(f.OptionsFlag)
                                                        && f.Status != "G"
                                                        && s.Status == f.Status
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

                return query.ToList().ConvertAll(i => (StatusCounterSameDayDTO)i);
            }
        }

        public List<SelectedFxDTO> CountFXTransErrorE1(List<string> cStatusIn, List<string> cGipStatusIn, string strDate)
        {
            // orginal code
            //IQueryable<FxTransaction> QueryE1 = from fx in appDbContext.FxTransactions
            //									where (transactionStatusInE1.Contains(fx.Status.Trim()) && fx.TranNo == "")
            //									where transactionGipStatusInE1.Contains(fx.GipStatus.Trim())
            //									where EF.Functions.DateDiffMinute(fx.AddOn, DateTime.Now) > 5
            //									where fx.CustomerMaster != null
            //									select fx;

            if (!(strDate != null)) return new List<SelectedFxDTO>();
            DateTime dtDate = DateTime.Parse(strDate);

            var optionsNotIn = new int?[] { 2, 11, 13 };

            // referene : E1 - where STATUS in ('S', 'Q') 
            var query = (from f in appDbContext.FxTransactions
                         where EF.Functions.DateDiffDay(f.AddOn, dtDate) == 0
                               && !optionsNotIn.Contains(f.OptionsFlag)
                               && cStatusIn.Contains(f.Status.Trim())
                               && !cGipStatusIn.Contains(f.GipStatus.Trim())
                               && f.TranNo == ""
                         select new SelectedFxDTO
                         {
                             RefNo = f.RefNo,
                             Status = f.Status,
                             GipDescription = f.GipDescription,
                         })
                         .ToList();
            return query;
        }

        public List<SelectedFxDTO> CountFXTransErrorE2(List<string> cStatusIn, List<string> cGipStatusIn, string strDate)
        {
            // original code
            //IQueryable<FxTransaction> QueryE2 = from fx in appDbContext.FxTransactions
            //									where (transactionGipStatusInE2.Contains(fx.GipStatus.Trim()) && fx.TranNo == "")
            //									where transactionStatusInE2.Contains(fx.Status.Trim())
            //									where fx.CustomerMaster != null
            //									select fx;

            if (!(strDate != null)) return new List<SelectedFxDTO>();
            DateTime dtDate = DateTime.Parse(strDate);

            var optionsNotIn = new int?[] { 2, 11, 13 };

            // E2 - where STATUS in ('S')  and GIP_STATUS in (0,5,9,13,17,18,19,20,24)
            var query = (from f in appDbContext.FxTransactions
                         where EF.Functions.DateDiffDay(f.AddOn, dtDate) == 0
                               && !optionsNotIn.Contains(f.OptionsFlag)
                               && cStatusIn.Contains(f.Status.Trim())
                               && cGipStatusIn.Contains(f.GipStatus.Trim())
                               && f.TranNo == ""
                         select new SelectedFxDTO
                         {
                             RefNo = f.RefNo,
                             Status = f.Status,
                             GipDescription = f.GipDescription,
                         })
                         .ToList();
            return query;
        }

        public List<SelectedFxDTO> CountFXTransErrorE3(List<string> cStatusIn, List<string> cGipStatusNotIn, string strDate)
        {
            // original code
            //int[] transactionOptionsNotInE3 = new[] { 11, 13 };
            //IQueryable<FxTransaction> QueryE3 = from fx in appDbContext.FxTransactions
            //									where fx.TranNo != "" 
            //									&& !transactionOptionsNotInE3.Contains(fx.OptionsFlag.Value) 
            //									&& !transactionGipStatusNotInE3.Contains(fx.GipStatus.Trim())
            //									where transactionStatusInE3.Contains(fx.Status.Trim())
            //									where fx.CustomerMaster != null
            //									select fx;


            if (!(strDate != null)) return new List<SelectedFxDTO>();
            DateTime dtDate = DateTime.Parse(strDate);
            int[] transactionOptionsNotInE3 = new[] { 11, 13 };

            // reference : where STATUS ='F' and GIP_STATUS NOT in (8, 15, 21) and TranNo != ""
            var query = (from f in appDbContext.FxTransactions
                         where EF.Functions.DateDiffDay(f.AddOn, dtDate) == 0
                                && !transactionOptionsNotInE3.Contains(f.OptionsFlag.Value)
                                && cStatusIn.Contains(f.Status.Trim())
                                && !cGipStatusNotIn.Contains(f.GipStatus.Trim())
                                && f.TranNo != ""
                         select new SelectedFxDTO
                         {
                             RefNo = f.RefNo,
                             Status = f.Status,
                             GipDescription = f.GipDescription,
                         })
                         .ToList();
            return query;
        }




        // To archive only
        public List<SelectedFxDTO> GetFXTransByStatus(string cStatus, string strDate)
        {
            if (!(strDate != null)) return new List<SelectedFxDTO>();
            DateTime dtDate = DateTime.Parse(strDate);

            //string[] validStatus = { "F", "A", "V" };
            //DateTime date = DateTime.Now;
            //DateTime defaultDatetime = DateTime.Parse("1900-01-01 00:00:00");

            var optionsNotIn = new int?[] { 2, 11, 13 };

            var entry = (from f in appDbContext.FxTransactions
                         join cm in appDbContext.CustomerMasters
                                   on new { f.CustAbbr, f.BranchNo } equals new { cm.CustAbbr, cm.BranchNo }
                         join fc in appDbContext.Fxfcusts on cm.CustCode equals fc.Code into c1
                         from fxcust in c1.DefaultIfEmpty()
                         join Mxtype in appDbContext.MxCustCounterpartyTypes on fxcust.CustId equals Mxtype.CustId
                         where Mxtype.CounterpartyTypeId == 10     // corporate deal only
                                && cm.StatusCd != "C"              //exclude closed customer
                                && (!cm.CustAbbr.Contains("NO GBASE"))
                                && (!cm.CustAbbr.Contains("NODREAMINPU"))
                                && (!cm.CustAbbr.Contains("999"))
                                && !optionsNotIn.Contains(f.OptionsFlag)
                                && f.Status == cStatus
                                && f.Status != "G"
                                && EF.Functions.DateDiffDay(f.AddOn, dtDate) == 0
                                 //&& (
                                 //(dateType == "DelivaryDate" &&
                                 //	EF.Functions.DateDiffDay(f.DelivaryDate, dtDate) <= 0 &&
                                 //	EF.Functions.DateDiffDay(f.DelivaryDate, dtDate) >= 0) ||
                                 //(dateType == "ContractValueDate" &&
                                 //	EF.Functions.DateDiffDay(f.ContractDateValue, dtDate) <= 0 &&
                                 //	EF.Functions.DateDiffDay(f.ContractDateValue, dtDate) >= 0)
                                 //)
                         select new SelectedFxDTO
                         {
                             RefNo = f.RefNo,
                             Status = (f.DeletionStatus == "D" && f.Status == "F" && (f.GipStatus == "15" || f.GipStatus == "8")) ? "C"
                                    //: (f.DeletionStatus == "D" && f.Status == "F" && (f.GipStatus != "8")) ? "D"
                                    : (f.GipStatus != "" && f.GipStatus == "15" && f.GipStatus == "8") ? "E"
                                    : f.Status,
                             GipDescription = f.GipDescription,
                         });

            var results = (from s in entry
                           where (s.Status == cStatus)
                           select s)
                        .ToList();

            return results;
        }
    }
}
