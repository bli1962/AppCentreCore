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

                             BuyAmt = (f.RefNo.Substring(1, 3) == "B" ? f.ContractCcyAmt : f.EquivCcyAmt),
                             BuyCCY = (f.RefNo.Substring(1, 3) == "B" ? f.ContractCcyAbbr : f.EquivCcyAbbr),
                             SellAmt = (f.RefNo.Substring(1, 3) == "S" ? f.ContractCcyAmt : f.EquivCcyAmt),
                             SellCCY = (f.RefNo.Substring(1, 3) == "S" ? f.ContractCcyAbbr : f.EquivCcyAbbr),

                             CONTRACT_DATE_OPE = f.ContractDateOpe.ToString().Substring(0, 10),
                             CONTRACT_DATE_VALUE = f.ContractDateValue.ToString().Substring(0, 10),
                             DELIVARY_DATE = (EF.Functions.DateDiffDay(f.DelivaryDate, defaultDatetime) == 0) ? "" : f.DelivaryDate.ToString().Substring(0, 10),

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
            catch (Exception ex)
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

                return query.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                _dapperAccess = null;
            }
        }


        //public IEnumerable<FxDeliveryView> GetFxDeliveryCorpByDate2(string strDeliveryDate, string SPConnection)
        //{
        //    string connectionString = SPConnection;
        //    //string connectionString = "server=MIZSQLT01; database=GUIDE; integrated security=SSPI;";

        //    List<FxDeliveryView> fxDeliveries = new();

        //    if (strDeliveryDate == null) return fxDeliveries;

        //    using (SqlConnection con = new(connectionString))
        //    {
        //        SqlCommand cmd = new("USP_GUIDE_TODAY_FX_DELIVERY_CORPORATE", con);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        SqlParameter paramDeliveryDate = new();
        //        paramDeliveryDate.ParameterName = "@Date";
        //        paramDeliveryDate.Value = DateTime.Parse(strDeliveryDate);
        //        cmd.Parameters.Add(paramDeliveryDate);

        //        con.Open();
        //        SqlDataReader rdr = cmd.ExecuteReader();
        //        while (rdr.Read())
        //        {
        //            FxDeliveryView fxDelivery = new()
        //            {
        //                REF_NO = rdr["REF_NO"].ToString(),
        //                CUST_ABBR = rdr["CUST_ABBR"].ToString(),
        //                CUST_NAME = rdr["CUST_NAME"].ToString(),
        //                BuyAmt = Convert.ToDecimal(rdr["BuyAmt"]),
        //                BuyCCY = rdr["BuyCCY"].ToString(),
        //                REC_SETTL_CODE = rdr["REC_SETTL_CODE"].ToString(),
        //                BUY_ACCT_TYPE = rdr["BUY_ACCT_TYPE"].ToString(),
        //                REC_ACT_CD = rdr["REC_ACT_CD"].ToString(),
        //                REC_ACT_NO = rdr["REC_ACT_NO"].ToString(),
        //                REC_CUST_ABBR = rdr["REC_CUST_ABBR"].ToString(),
        //                SellAmt = Convert.ToDecimal(rdr["SellAmt"]),
        //                SellCCY = rdr["SellCCY"].ToString(),
        //                PAY_SETTL_CODE = rdr["PAY_SETTL_CODE"].ToString(),
        //                PAY_ACCT_TYPE = rdr["PAY_ACCT_TYPE"].ToString(),
        //                PAY_ACT_CD = rdr["PAY_ACT_CD"].ToString(),
        //                PAY_ACT_NO = rdr["PAY_ACT_NO"].ToString(),
        //                PAY_CUST_ABBR = rdr["PAY_CUST_ABBR"].ToString(),
        //                DELIVARY_DATE = (rdr["DELIVARY_DATE"] is DBNull) ? "" : (Convert.ToString(rdr["DELIVARY_DATE"])).Substring(0, 10),
        //            };

        //            if (!(rdr["EXCHANGE_RATE"] is DBNull))
        //            {
        //                fxDelivery.EXCHANGE_RATE = Convert.ToDecimal(rdr["EXCHANGE_RATE"]);
        //            }

        //            fxDeliveries.Add(fxDelivery);
        //        }
        //    }
        //    return fxDeliveries;
        //}

        //public IEnumerable<FxDeliveryCorpSummaryView> GetFxDeliveryCorpSummaryByDate2(string strDeliveryDate, string SPConnection)
        //{
        //    string connectionString = SPConnection;
        //    //string connectionString = "server=MIZSQLT01; database=GUIDE; integrated security=SSPI;";


        //    List<FxDeliveryCorpSummaryView> fxDeliveries = new();

        //    if (strDeliveryDate == null) return fxDeliveries;

        //    using (SqlConnection con = new(connectionString))
        //    {
        //        SqlCommand cmd = new("USP_GUIDE_TODAY_FX_DELIVERY_CORPORATE_SUM", con);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        SqlParameter paramDeliveryDate = new()
        //        {
        //            ParameterName = "@Date",
        //            Value = DateTime.Parse(strDeliveryDate)
        //        };
        //        cmd.Parameters.Add(paramDeliveryDate);

        //        con.Open();
        //        SqlDataReader rdr = cmd.ExecuteReader();
        //        while (rdr.Read())
        //        {
        //            FxDeliveryCorpSummaryView fxDelivery = new()
        //            {
        //                CCY = rdr["CCY"].ToString(),
        //                Acct_Type = rdr["Acct_Type"].ToString(),
        //                totalNet = Convert.ToDecimal(rdr["totalNet"])
        //            };

        //            fxDeliveries.Add(fxDelivery);
        //        }
        //    }
        //    return fxDeliveries;
        //}

        public FxSettlementInf GetFxDeliveryByRefNo(string refNo)
        {
            //using GUIDEDbContext appDbContext  = new();
            var entry = appDbContext.FxSettlementInfs
                        .Where(e => e.RefNo.ToLower() == refNo.ToLower())
                        .FirstOrDefault();
            return entry;
        }

        public string UpdateStatus(FXTranStatus status)
        {
            try
            {
                //using GUIDEDbContext appDbContext  = new();
                string[] validStatus = { "F", "A", "V" };

                var entry = appDbContext.FxSettlementInfs
                     //.Include(x => x.FX_TRANSACTION)
                     .Where(e => e.RefNo.ToLower() == status.RefNo.ToLower()
                                   && (e.AuthorizeBy == status.AuthorizeBy || e.AuthorizeBy.ToUpper() == "SYSTEM")
                                   && !validStatus.Contains(e.Status))
                    .FirstOrDefault();
                //.FirstOrDefault(e => e.REF_NO == status.REF_NO);

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
