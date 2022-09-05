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

namespace mhcb.Syd.Business.Repository
{
    public class FXTransactionRepository : IFXTransaction
    {
        private readonly GUIDEDbContext appDbContext;
        public FXTransactionRepository(GUIDEDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }


        public IEnumerable<FxTransaction> GetFullFXTransactionByDates(string strDateFrom, string strDateTo, string dateType)
        {

            //using GUIDEDbContext appDbContext  = new();
            if (!(strDateFrom != null && strDateTo != null)) return new List<FxTransaction>();

            //string[] validStatus = { "F", "A", "V" };
            //DateTime date = DateTime.Now;

            DateTime dateFrom = DateTime.Parse(strDateFrom);
            DateTime dateTo = DateTime.Parse(strDateTo);

            //DateTime defaultDatetime = DateTime.Parse("1900-01-01 00:00:00");

            //var entry = appDbContext.FxTransactions
            //            .Where(x => x.Status == "F" && EF.Functions.DateDiffDay(x.ContractDateValue, dateFrom) <= 0 && EF.Functions.DateDiffDay(x.ContractDateValue, dateTo) >= 0)
            //            .ToList();


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
                          select new FxTransaction
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

                              ContractDateOpe = f.ContractDateOpe,
                              ContractDateValue = f.ContractDateValue,
                              DelivaryDate = f.DelivaryDate,
                              DelivaryThru = f.DelivaryThru,
                              AccrualFrom = f.AccrualFrom,
                              AccrualTo = f.AccrualTo,
                              SettlementValueDate = f.SettlementValueDate,

                              CcyCd = f.CcyCd,
                              //CcyCd = y1.Ccy,   

                              //ContractCcyCd = f.ContractCcyCd,
                              ContractCcyCd = y2.Ccy,

                              ContractCcyAbbr = f.ContractCcyAbbr,
                              ContractCcyAmt = Math.Round((decimal)f.ContractCcyAmt, 2),
                              ContractCcyBal = Math.Round((decimal)f.ContractCcyBal, 2),
                              ContractCcyTtb = Math.Round((decimal)f.ContractCcyTtb, 2),

                              //EquivCcyCd = f.EquivCcyCd,
                              EquivCcyCd = y3.Ccy,
                              //
                              EquivCcyAbbr = f.EquivCcyAbbr,
                              EquivCcyAmt = Math.Round((decimal)f.EquivCcyAmt, 2),
                              EquivCcyBal = Math.Round((decimal)f.EquivCcyBal, 2),
                              EquivCcyTtb = Math.Round((decimal)f.EquivCcyTtb, 2),
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

            //SELECT f.*
            //FROM[Guide].[dbo].[FX_TRANSACTION] f
            //Left join[Guide].[dbo].[CUSTOMER_MASTER] a on f.CUST_ABBR = a.CUST_ABBR
            //Left Join[Guide].[dbo].[FXFCust] b on b.CUST_ID = a.CUST_ID and b.Abbreviation = a.CUST_ABBR

            //Left join[Guide].[dbo].[MxCustCounterpartyType] c on b.CUST_ID = c.CustID
            //LEFT JOIN[Guide].[dbo].[MxCounterpartyType] d on c.CounterpartyTypeID = d.id
            //Where d.ID = 10  and a.STATUS_CD <> 'C'
            //and f.CONTRACT_DATE_VALUE between '2021-01-01' and '2021-12-31'
            //order by  f.DealNo

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

                             CONTRACT_DATE_OPE = b.ContractDateOpe.ToString().Substring(0, 10),
                             CONTRACT_DATE_VALUE = b.ContractDateValue.ToString().Substring(0, 10),
                             SETTLEMENT_VALUE_DATE = (EF.Functions.DateDiffDay(b.SettlementValueDate, defaultDatetime) == 0) ? "" : b.SettlementValueDate.ToString().Substring(0, 10),

                             CONTRACT_CCY_ABBR = b.ContractCcyAbbr,
                             CONTRACT_CCY_AMT = b.ContractCcyAmt,
                             EQUIV_CCY_ABBR = b.EquivCcyAbbr,
                             EQUIV_CCY_AMT = b.EquivCcyAmt,

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

                             CONTRACT_DATE_OPE = b.ContractDateOpe.ToString().Substring(0, 10),
                             CONTRACT_DATE_VALUE = b.ContractDateValue.ToString().Substring(0, 10),
                             DELIVARY_DATE = (EF.Functions.DateDiffDay(b.DelivaryDate, defaultDatetime) == 0) ? "" : b.DelivaryDate.ToString().Substring(0, 10),

                             CONTRACT_CCY_ABBR = b.ContractCcyAbbr,
                             CONTRACT_CCY_AMT = b.ContractCcyAmt,
                             EQUIV_CCY_ABBR = b.EquivCcyAbbr,
                             EQUIV_CCY_AMT = b.EquivCcyAmt,

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


        //public IEnumerable<FxDeliveryView> GetFxDeliveryByDatesOld(string strDateFrom, string strDateTo)
        //{
        //    //string connectionString = ConfigurationManager.ConnectionStrings["GUIDESP"].ConnectionString;
        //    string connectionString = "server=MIZSQLT01; database=GUIDE; integrated security=SSPI;";

        //    List<FxDeliveryView> fxDeliveries = new();

        //    if (!(strDateFrom != null && strDateTo != null)) return new List<FxDeliveryView>();

        //    using (SqlConnection con = new(connectionString))
        //    {
        //        SqlCommand cmd = new("USP_GUIDE_FX_Transaction_All", con)
        //        {
        //            CommandType = CommandType.StoredProcedure
        //        };

        //        SqlParameter paramDateFrom = new()
        //        {
        //            ParameterName = "@DateFrom",
        //            Value = DateTime.Parse(strDateFrom)
        //        };
        //        cmd.Parameters.Add(paramDateFrom);

        //        SqlParameter paramDateTo = new()
        //        {
        //            ParameterName = "@DateTo",
        //            Value = DateTime.Parse(strDateTo)
        //        };
        //        cmd.Parameters.Add(paramDateTo);

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
        //                //REC_SETTL_CODE = rdr["REC_SETTL_CODE"].ToString(),
        //                //BUY_ACCT_TYPE = rdr["BUY_ACCT_TYPE"].ToString(),
        //                //REC_ACT_CD = rdr["REC_ACT_CD"].ToString(),
        //                //REC_ACT_NO = rdr["REC_ACT_NO"].ToString(),
        //                //REC_CUST_ABBR = rdr["REC_CUST_ABBR"].ToString(),
        //                SellAmt = Convert.ToDecimal(rdr["SellAmt"]),
        //                SellCCY = rdr["SellCCY"].ToString(),
        //                //PAY_SETTL_CODE = rdr["PAY_SETTL_CODE"].ToString(),
        //                //PAY_ACCT_TYPE = rdr["PAY_ACCT_TYPE"].ToString(),
        //                //PAY_ACT_CD = rdr["PAY_ACT_CD"].ToString(),
        //                //PAY_ACT_NO = rdr["PAY_ACT_NO"].ToString(),
        //                //PAY_CUST_ABBR = rdr["PAY_CUST_ABBR"].ToString()

        //                CONTRACT_DATE_OPE = (rdr["CONTRACT_DATE_OPE"] is DBNull) ? "" : (Convert.ToString(rdr["CONTRACT_DATE_OPE"])).Substring(0, 10),
        //                CONTRACT_DATE_VALUE = (rdr["CONTRACT_DATE_VALUE"] is DBNull) ? "" : (Convert.ToString(rdr["CONTRACT_DATE_VALUE"])).Substring(0, 10),
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

        public string UpdateStatus(FXTranStatus status)
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
    }
}
