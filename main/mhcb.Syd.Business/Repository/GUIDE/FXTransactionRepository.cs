using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;
using mhcb.Syd.Business.DbAccess;
using Dapper;

namespace mhcb.Syd.Business.Repository
{
    public class FXTransactionRepository : IFXTransaction
    {
        private readonly GUIDEDbContext appDbContext;
        private SqlDataAccess _dapperAccess;

        public FXTransactionRepository(GUIDEDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<FxTransactionCompleteView> GetFullFXTransactionByDates(string strDateFrom, string strDateTo, string dateType)
        {

            //using GUIDEDbContext appDbContext  = new();
            if (!(strDateFrom != null && strDateTo != null)) return new List<FxTransactionCompleteView>();

            //string[] validStatus = { "F", "A", "V" };
            //DateTime date = DateTime.Now;

            DateTime dateFrom = DateTime.Parse(strDateFrom);
            DateTime dateTo = DateTime.Parse(strDateTo);

            //List<FxTransaction> entry2 = new List<FxTransaction>();
            var entry2 = (from f in appDbContext.FxTransactions
                          join cm in appDbContext.CustomerMasters
                                    on new { f.CustAbbr, f.BranchNo } equals new { cm.CustAbbr, cm.BranchNo }
                          join fc in appDbContext.Fxfcusts on cm.CustCode equals fc.Code into c1
                          from fxcust in c1.DefaultIfEmpty()
                          join Mxtype in appDbContext.MxCustCounterpartyTypes on fxcust.CustId equals Mxtype.CustId

                          //join y1 in appDbContext.Fxfccies on f.CcyCd equals y1.CcyCd
                          join y2 in appDbContext.Fxfccies on f.ContractCcyCd equals y2.CcyCd
                          join y3 in appDbContext.Fxfccies on f.EquivCcyCd equals y3.CcyCd

                          where Mxtype.CounterpartyTypeId == 10
                                    && f.Status != "D"
                                    && cm.StatusCd != "C"
                                    && (!cm.CustAbbr.Contains("NO GBASE"))
                                    && (!cm.CustAbbr.Contains("NODREAMINPU"))
                                    && (!cm.CustAbbr.Contains("999"))
                                    && (
                                    (dateType == "DelivaryDate" &&
                                        EF.Functions.DateDiffDay(f.DelivaryDate, dateFrom) <= 0 &&
                                        EF.Functions.DateDiffDay(f.DelivaryDate, dateTo) >= 0) ||
                                    (dateType == "ContractValueDate" &&
                                        EF.Functions.DateDiffDay(f.ContractDateValue, dateFrom) <= 0 &&
                                        EF.Functions.DateDiffDay(f.ContractDateValue, dateTo) >= 0)
                                  )
                          select new FxTransactionCompleteView
                          {
                              RefNo = f.RefNo,
                              //DealNo = f.DealNo,
                              //TransCode = f.TransCode,
                              //Dealtype = f.Dealtype,
                              //Subtype = f.Subtype,
                              ActCd = f.ActCd,
                              ActAbbr = f.ActAbbr,
                              //CustCode = f.CustCode,
                              CustAbbr = f.CustAbbr,
                              BranchNo = f.BranchNo,
                              //DivisionCd = f.DivisionCd,
                              //IbfId = f.IbfId,
                              SchemeNo = f.SchemeNo,
                              Authorized = f.Authorized,
                              Revise = f.Revise,
                              CoverPoFlg = f.CoverPoFlg,

                              //DateTime.ParseExact(txtDate1.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture);

                              ContractDateOpe = (DateTime)f.ContractDateOpe,
                              ContractDateValue = (DateTime)f.ContractDateValue,
                              DelivaryDate = (DateTime)f.DelivaryDate,
                              DelivaryThru = (DateTime)f.DelivaryThru,

                              AccrualFrom = (DateTime)f.AccrualFrom,
                              AccrualTo = (DateTime)f.AccrualTo,
                              SettlementValueDate = (DateTime)f.SettlementValueDate,

                              CcyCd = f.CcyCd,
                              //CcyCd = y1.Ccy,   

                              //ContractCcyCd = f.ContractCcyCd,
                              ContractCcyCd = y2.Ccy,

                              ContractCcyAbbr = f.ContractCcyAbbr,
                              ContractCcyAmt = f.ContractCcyAmt ?? 0 ,
                              ContractCcyBal = f.ContractCcyBal ?? 0,
                              ContractCcyTtb = f.ContractCcyTtb ?? 0,
                              //ContractCcyAmt = Math.Round((decimal)f.ContractCcyAmt, 2) ,
                              //ContractCcyBal = Math.Round((decimal)f.ContractCcyBal, 2),
                              //ContractCcyTtb = Math.Round((decimal)f.ContractCcyTtb, 2),

                              //EquivCcyCd = f.EquivCcyCd,
                              EquivCcyCd = y3.Ccy,
                              //
                              EquivCcyAbbr = f.EquivCcyAbbr,
                              EquivCcyAmt = f.EquivCcyAmt ?? 0,
                              EquivCcyBal = f.EquivCcyBal ?? 0,
                              EquivCcyTtb = f.EquivCcyTtb ?? 0,
                              //EquivCcyAmt = Math.Round((decimal)f.EquivCcyAmt, 2),
                              //EquivCcyBal = Math.Round((decimal)f.EquivCcyBal, 2),
                              //EquivCcyTtb = Math.Round((decimal)f.EquivCcyTtb, 2),
                              ExchangeRate = f.ExchangeRate,

                              InternalRate = f.InternalRate,
                              Spread = f.Spread,
                              AccountEntry = f.AccountEntry,
                              Broker = f.Broker,
                              Remarks = f.Remarks,
                              RemarksTrd = f.RemarksTrd,
                              SwapRefNo = f.SwapRefNo,
                              StatusCd = f.StatusCd,
                              Addressee = f.Addressee,
                              Code56 = f.Code56,
                              Code57 = f.Code57,
                              Code57a = f.Code57a,
                              Code58 = f.Code58,
                              SetInstruction = f.SetInstruction,
                              Dealer = f.Dealer,
                              OptionsFlag = f.OptionsFlag,
                              ExecutionRefNo = f.ExecutionRefNo,
                              //AddBy = f.AddBy,
                              //AddOn = f.AddOn,
                              AuthorizeBy = f.AuthorizeBy,
                              //AuthorizeOn = f.AuthorizeOn,
                              //VerifyBy = f.VerifyBy,
                              //VerifyOn = f.VerifyOn,
                              //ModifyBy = f.ModifyBy,
                              //ModifyOn = f.ModifyOn,
                              //DeleteBy = f.DeleteBy,
                              //DeleteOn = f.DeleteOn,
                              Status = f.Status,
                              DeletionStatus = f.DeletionStatus,
                              //GipStatus = f.GipStatus,
                              //GipDescription = f.GipDescription,
                              TranNo = f.TranNo
                          })
                          .ToList();

            return entry2;
        }


        public IEnumerable<FXTransactionView> GetPendingTrans()
        {
            //using GUIDEDbContext appDbContext  = new();
            string[] validStatus = { "F", "A", "V" };
            DateTime date = DateTime.Now;
            DateTime defaultDatetime = DateTime.Parse("1900-01-01 00:00:00");

            var entry = (from b in appDbContext.FxTransactions
                         where (!validStatus.Contains(b.Status)
                                    && (!b.CustAbbr.Contains("NO GBASE"))
                                    && (!b.CustAbbr.Contains("NODREAMINPU"))
                                    && (!b.CustAbbr.Contains("999"))
                                   )
                         select new FXTransactionView()
                         {
                             REF_NO = b.RefNo,
                             CUST_ABBR = b.CustAbbr,

                             //CONTRACT_DATE_OPE = b.ContractDateOpe.ToString().Substring(0, 10),
                             //CONTRACT_DATE_VALUE = b.ContractDateValue.ToString().Substring(0, 10),
                             //SETTLEMENT_VALUE_DATE = (EF.Functions.DateDiffDay(b.SettlementValueDate, defaultDatetime) == 0) ? "" : b.SettlementValueDate.ToString().Substring(0, 10),
                             CONTRACT_DATE_OPE = (DateTime)b.ContractDateOpe,
                             CONTRACT_DATE_VALUE = (DateTime)b.ContractDateValue,
                             SETTLEMENT_VALUE_DATE = (DateTime)b.SettlementValueDate,

                             CONTRACT_CCY_ABBR = b.ContractCcyAbbr,
                             CONTRACT_CCY_AMT = b.ContractCcyAmt ?? 0,
                             EQUIV_CCY_ABBR = b.EquivCcyAbbr,
                             EQUIV_CCY_AMT = b.EquivCcyAmt ?? 0,

                             STATUS = b.Status,
                             DELETION_STATUS = b.DeletionStatus,
                             GIP_STATUS = b.GipStatus,
                             GIP_DESCRIPTION = b.GipDescription,
                             AUTHORIZE_BY = b.AuthorizeBy,
                             TRAN_NO = b.TranNo,
                         })
                        .ToList();
            return entry;
        }

        public IEnumerable<FXTransactionView> GetFXTransactionByDatesCustAbbr(string strDateFrom, string strDateTo, string dateType, string custName)
        {

            //using GUIDEDbContext appDbContext  = new();
            if (!(strDateFrom != null && strDateTo != null)) return new List<FXTransactionView>();

            string[] validStatus = { "F", "A", "V" };
            DateTime date = DateTime.Now;

            DateTime dateFrom = DateTime.Parse(strDateFrom);
            DateTime dateTo = DateTime.Parse(strDateTo);
            DateTime defaultDatetime = DateTime.Parse("1900-01-01 00:00:00");

            var entry = (from b in appDbContext.FxTransactions
                         join cm in appDbContext.CustomerMasters
                                    on new { b.CustAbbr, b.BranchNo } equals new { cm.CustAbbr, cm.BranchNo }
                         where validStatus.Contains(b.Status)
                            && (cm.CustName.Contains(custName))
                            && (b.DeletionStatus == "")
                            && (
                                    (dateType == "DelivaryDate" &&
                                        EF.Functions.DateDiffDay(b.DelivaryDate, dateFrom) <= 0 &&
                                        EF.Functions.DateDiffDay(b.DelivaryDate, dateTo) >= 0) ||
                                    (dateType == "ContractValueDate" &&
                                        EF.Functions.DateDiffDay(b.ContractDateValue, dateFrom) <= 0 &&
                                        EF.Functions.DateDiffDay(b.ContractDateValue, dateTo) >= 0)
                                )
                         select new FXTransactionView()
                         {
                             REF_NO = b.RefNo,
                             CUST_ABBR = b.CustAbbr,
                             CUST_NAME = cm.CustName,
                             ACT_ABBR = b.ActAbbr,
                             ACT_CD = b.ActCd,

                             //CONTRACT_DATE_OPE = b.ContractDateOpe.ToString().Substring(0, 10),
                             //CONTRACT_DATE_VALUE = b.ContractDateValue.ToString().Substring(0, 10),
                             //DELIVARY_DATE = (EF.Functions.DateDiffDay(b.DelivaryDate, defaultDatetime) == 0) ? "" : b.DelivaryDate.ToString().Substring(0, 10),
                             CONTRACT_DATE_OPE = (DateTime)b.ContractDateOpe,
                             CONTRACT_DATE_VALUE = (DateTime)b.ContractDateValue,                          
                             DELIVARY_DATE = (DateTime)b.DelivaryDate,

                             SETTLEMENT_VALUE_DATE = (DateTime)b.SettlementValueDate,

                             CONTRACT_CCY_ABBR = b.ContractCcyAbbr,
                             CONTRACT_CCY_AMT = b.ContractCcyAmt ?? 0,

                             EQUIV_CCY_ABBR = b.EquivCcyAbbr,
                             EQUIV_CCY_AMT = b.EquivCcyAmt ?? 0,

                             EXCHANGE_RATE = b.ExchangeRate,
                             INTERNAL_RATE = b.InternalRate,
                             SPREAD = b.Spread,

                             STATUS = b.Status,
                             DELETION_STATUS = b.DeletionStatus,
                             GIP_STATUS = b.GipStatus,
                             GIP_DESCRIPTION = b.GipDescription,
                             AUTHORIZE_BY = b.AuthorizeBy,
                             TRAN_NO = b.TranNo,
                         })
                        .ToList();
            return entry;
        }


        //FXTransactionView
        public FxTransaction GetFxTransByRefNo(string refNo)
        {
            //using GUIDEDbContext appDbContext  = new();
            var entry = appDbContext.FxTransactions
                        .Where(e => e.RefNo.ToLower() == refNo.ToLower())
                        .FirstOrDefault();
            return entry;
        }

    
        public string UpdateStatus(InputFXTrans status)
        {
            try
            {
                //using GUIDEDbContext appDbContext  = new();
                string[] validStatus = { "F", "A", "V" };

                var entry = appDbContext.FxTransactions
                    //.Include(x => x.FX_SETTLEMENT_INF)
                    //.Include(x => x.CUSTOMER_MASTER)
                    .Where(e =>
                            e.RefNo.ToLower() == status.RefNo.ToLower() &&
                            (e.AuthorizeBy == status.AuthorizeBy || e.AuthorizeBy.ToUpper()== "SYSTEM") &&
                            !validStatus.Contains(e.Status))
                    .FirstOrDefault();


                if (entry != null)
                {
                    var delstatus = entry.DeletionStatus.ToString();
                    var guideStatus = entry.Status.ToString();

                    AuditLog auditLog = new()
                    {
                        UserId = status.AuthorizeBy,
                        AuditDate = DateTime.Now,
                        RefNo = status.RefNo.ToString(),
                        TransNo = status.TranNo ?? "99999",
                        AuditDesc = "Sent FX Transaction to Finalized",
                        AppName = "GUIDE",
                        TableName = "FX Transaction",
                        OriginalValue = guideStatus + " : " + delstatus,
                        NewValue = status.Status + " : " + status.DeletionStatus,
                    };

                    entry.AuthorizeBy = status.AuthorizeBy;
                    entry.Status = status.Status;
                    entry.DeletionStatus = status.DeletionStatus ?? "";
                    entry.GipStatus = status.GipStatus;
                    entry.GipDescription = status.GipDescription;
                    entry.TranNo = status.TranNo ?? "99999";

                    appDbContext.AuditLogs.Add(auditLog);

                    appDbContext.SaveChanges();
                    return "OK";
                }
                else
                {
                    return "NotFound";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }


        // NDF Project
        //if return 1, there is a pending transactions
        //if return 2, there is a pending delivery
        //if return 0, no pending trans/delivery
        public int CheckFxTransactionQueues(string SPConnection, DateTime rundate)
        {
            IEnumerable<int> query;
            Int32 intRtn = -1;
            try
            {
                _dapperAccess = new SqlDataAccess(SPConnection);
                var parameters = new DynamicParameters();
                parameters.Add("@Rundate", rundate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
                query = _dapperAccess.LoadData<Int32, dynamic>("USP_GUIDE_RATES_CHECK_FX_TRANSACTION_QUEUES", parameters);
                return intRtn = query.FirstOrDefault();
            }
            catch
            {
                return -1;
            }
            finally
            {
                _dapperAccess = null;
            };
        }
    }
}
