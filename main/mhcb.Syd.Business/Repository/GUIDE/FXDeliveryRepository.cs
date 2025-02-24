using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;
using Microsoft.EntityFrameworkCore;
using mhcb.Syd.Business.DbAccess;

namespace mhcb.Syd.Business.Repository
{
    public class FXDeliveryRepository : IFXDelivery
    {
        private readonly GUIDEDbContext appDbContext;
        private SqlDataAccess _dapperAccess;

        public FXDeliveryRepository(GUIDEDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<FXDeliveryView> GetPendingTrans()
        {
            //using GUIDEDbContext appDbContext  = new();
            string[] validStatus = { "F", "A", "V" };
            DateTime defaultDatetime = DateTime.Parse("1900-01-01 00:00:00");

            var entry = (from b in appDbContext.FxSettlementInfs
                         where (!validStatus.Contains(b.Status)
                                   && (!b.CustAbbr.Contains("NO GBASE"))
                                   && (!b.CustAbbr.Contains("NODREAMINPU"))
                                   && (!b.CustAbbr.Contains("999"))
                                   //&& DbFunctions.TruncateTime(b.ADD_ON) == DbFunctions.TruncateTime(date)
                                   )
                         select new FXDeliveryView()
                         {
                             REF_NO = b.RefNo,
                             CUST_ABBR = b.CustAbbr,
                             REC_SETTL_CODE = b.RecSettlCode,
                             REC_CUST_ABBR = b.RecCustAbbr,
                             REC_CCY_CD = b.RecCcyCd,
                             PAY_SETTL_CODE = b.PaySettlCode,
                             PAY_CUST_ABBR = b.PayCustAbbr,
                             PAY_CCY_CD = b.PayCcyCd,

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

        public IEnumerable<FxDeliveryView> GetFxDeliveryByDates(string strDateFrom, string strDateTo)
        {

            //using GUIDEDbContext appDbContext  = new();
            if (!(strDateFrom != null && strDateTo != null)) return new List<FxDeliveryView>();

            //string[] validStatus = { "F", "A", "V" };
            //DateTime date = DateTime.Now;

            DateTime dateFrom = DateTime.Parse(strDateFrom);
            DateTime dateTo = DateTime.Parse(strDateTo);
            DateTime defaultDatetime = DateTime.Parse("1900-01-01 00:00:00");

            var entry = (from f in appDbContext.FxTransactions
                         join s in appDbContext.FxSettlementInfs
                                on f.RefNo equals s.RefNo
                         join cm in appDbContext.CustomerMasters
                                on new { f.CustAbbr, f.BranchNo } equals new { cm.CustAbbr, cm.BranchNo }
                         join fc in appDbContext.Fxfcusts
                                on cm.CustCode equals fc.Code
                         join MxCust in appDbContext.MxCustCounterpartyTypes on fc.CustId equals MxCust.CustId
                         join Mxtype in appDbContext.MxCounterpartyTypes on MxCust.CounterpartyTypeId equals Mxtype.Id
                         where (f.CustAbbr != "999")
                                && (EF.Functions.DateDiffDay(f.ContractDateValue, dateFrom) <= 0)
                                && (EF.Functions.DateDiffDay(f.ContractDateValue, dateTo) >= 0)
                         select new FxDeliveryView()
                         {
                             REF_NO = f.RefNo,
                             CUST_ABBR = f.CustAbbr,
                             CUST_NAME = cm.CustName,

                             BuyAmt = (f.RefNo.Substring(1, 3) == "B" ? (f.ContractCcyAmt ?? 0) : (f.EquivCcyAmt ?? 0)),
                             BuyCCY = (f.RefNo.Substring(1, 3) == "B" ? f.ContractCcyAbbr : f.EquivCcyAbbr),
                             SellAmt = (f.RefNo.Substring(1, 3) == "S" ? (f.EquivCcyAmt ?? 0) : (f.ContractCcyAmt ?? 0)),
                             SellCCY = (f.RefNo.Substring(1, 3) == "S" ? f.EquivCcyAbbr : f.ContractCcyAbbr),

                             //CONTRACT_DATE_OPE = f.ContractDateOpe.ToString().Substring(0, 10),
                             //CONTRACT_DATE_VALUE = f.ContractDateValue.ToString().Substring(0, 10),
                             //DELIVARY_DATE = (EF.Functions.DateDiffDay(f.DelivaryDate, defaultDatetime) == 0) ? "" : f.DelivaryDate.ToString().Substring(0, 10),

                             CONTRACT_DATE_OPE = (DateTime)f.ContractDateOpe,
                             CONTRACT_DATE_VALUE = (DateTime)f.ContractDateValue,
                             DELIVARY_DATE = (DateTime)f.DelivaryDate,
                             EXCHANGE_RATE = f.ExchangeRate,
                         })
                        .ToList();
            return entry;
        }

        public IEnumerable<FxDeliveryView> GetFxDeliveryCorpByDate(string strDeliveryDate, string SPConnection)
        {
            List<FxDeliveryView> fxDeliveries = new();

            if (strDeliveryDate == null) return fxDeliveries;

            IEnumerable<FxDeliveryView> query;
            try
            {
                _dapperAccess = new SqlDataAccess(SPConnection);

                query = _dapperAccess.LoadData<FxDeliveryView, dynamic>("USP_GUIDE_TODAY_FX_DELIVERY_CORPORATE", new { DATE = strDeliveryDate });

                return query.ToList();
            }
            catch
            {
                return null;
            }
            finally
            {
                _dapperAccess = null;
            }
        }

        public IEnumerable<FxDeliveryCorpSummaryView> GetFxDeliveryCorpSummaryByDate(string strDeliveryDate, string SPConnection)
        {
            List<FxDeliveryCorpSummaryView> fxDeliveries = new();

            if (strDeliveryDate == null) return fxDeliveries;

            IEnumerable<FxDeliveryCorpSummaryView> query;
            try
            {
                _dapperAccess = new SqlDataAccess(SPConnection);

                query = _dapperAccess.LoadData<FxDeliveryCorpSummaryView, dynamic>("USP_GUIDE_TODAY_FX_DELIVERY_CORPORATE_SUM", new { DATE = strDeliveryDate });

                //var query2 = (from f in query)
                //select new FxDeliveryCorpSummaryView
                // {
                //	 CCY  = f.CCY,
                //   Acct_Type= f.Acct_Type,
                //    totalNet = f.totalNet
                //}).ToList();

                return query.ToList();
            }
            catch
            {
                return null;
            }
            finally
            {
                _dapperAccess = null;
            }
        }

        public FxSettlementInf GetFxDeliveryByRefNo(string refNo)
        {
            //using GUIDEDbContext appDbContext  = new();
            var entry = appDbContext.FxSettlementInfs
                        .Where(e => e.RefNo.ToLower() == refNo.ToLower())
                        .FirstOrDefault();
            return entry;
        }

        public string UpdateStatus(InputFXTrans status)
        {
            try
            {
                string[] validStatus = { "F", "A", "V" };

                var entry = appDbContext.FxSettlementInfs
                     //.Include(x => x.FX_TRANSACTION)
                     .Where(e => e.RefNo.ToLower() == status.RefNo.ToLower()
                                   && (e.AuthorizeBy == status.AuthorizeBy || e.AuthorizeBy.ToUpper() == "SYSTEM"
                                   || e.AuthorizeBy.ToUpper() == "SA003231")
                                   && !validStatus.Contains(e.Status))
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
                        AuditDesc = "Sent FX Settlement to finalized",
                        AppName = "GUIDE",
                        TableName = "FX Settlement",
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
    }
}
