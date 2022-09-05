using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;

namespace mhcb.Syd.Business.Repository
{
	public class FacilityMasterLoanTransRepository : IFacilityMasterLoanTrans
	{
        private readonly LOANDbContext appDbContext;
        public FacilityMasterLoanTransRepository(LOANDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<FacilityMasterLoanTransView> GetLoanTransactionByDates(string strDateFrom, string strDateTo)
		{
			if (!(strDateFrom != null && strDateTo != null)) return new List<FacilityMasterLoanTransView>();

            //using LOANDbContext appDbContext  = new();
            DateTime dateFrom = DateTime.Parse(strDateFrom);
            DateTime dateTo = DateTime.Parse(strDateTo);
            DateTime defaultDatetime = DateTime.Parse("1900-01-01 00:00:00");

            var entry = (from lt in appDbContext.LoanTrans
                         join fm in appDbContext.FacilityMasters on lt.RefNo equals fm.RefNo
                         //join p1 in appDbContext.PROD_TYPE on f.PROD_TYPE1 equals p1.PROD_ID
                         join p2 in appDbContext.ProdTypes on fm.ProdType2 equals p2.ProdId
                         join p3 in appDbContext.ProdTypes on fm.ProdType3 equals p3.ProdId
                         //join p4 in appDbContext.PROD_TYPE on f.PROD_TYPE4 equals p4.PROD_ID

                         join cv in appDbContext.VGuideCustomerMasters
                            on new { fm.CustAbbr, fm.BranchNo } equals new { cv.CustAbbr, cv.BranchNo }

                                // not working. why?
                                //join cust in entities2.CUSTOMER_MASTER on f.CUST_ABBR equals cust.CUST_ABBR 
                         where lt.Status != "D"
                               && EF.Functions.DateDiffDay(lt.StartDate,dateFrom)<=0
                               && EF.Functions.DateDiffDay(lt.StartDate,dateTo) >= 0
                         orderby lt.RefNo, lt.StartDate, lt.TransNo
                         select new FacilityMasterLoanTransView()
                         {
                             DEPARTMENT =
                                        (
                                            cv.DepartmentCd == "20" ? "JCD" :
                                            cv.DepartmentCd == "30" ? "CLD" :
                                            cv.DepartmentCd == "31" ? "PFD" :
                                            cv.DepartmentCd == "32" ? "LBO" : ""
                                        ),
                             CUST_NAME = cv.CustName,

                             REF_NO = lt.RefNo,

                             START_DATE = (EF.Functions.DateDiffDay(lt.StartDate, defaultDatetime)==0) ? "" : lt.StartDate.ToString().Substring(0, 10),

                             DUE_DATE = (EF.Functions.DateDiffDay(lt.DueDate, defaultDatetime)==0) ? "" : lt.DueDate.ToString().Substring(0, 10),

                             DRAW_CCY = lt.DrawCcy,
                             DRAW_AMT = lt.DrawAmt,
                             REPAY_CCY = lt.RepayCcy,
                             REPAY_AMT = lt.RepayAmt,
                             INT_RATE = lt.IntRate,
                             INTERNAL_RATE = lt.InternalRate ?? "",

                             SPREAD = lt.Spread,
                             INT_AMT = lt.IntAmt,
                             REMARKS = lt.Remarks,

                             TransType = (
                                        lt.DrawAmt > 0 && lt.RoNo == 0 ? "Drawdown" :
                                        lt.DrawAmt > 0 && lt.RoNo > 0 ? "Rollover" :
                                        lt.RepayAmt > 0 ? "Repayment" : ""
                                    ),
                             PROD_TYPE2_DESC = p2.ProdDesc,
                             PROD_TYPE3_DESC = p3.ProdDesc


                         })
                        .ToList();
            return entry;
        }

		public IEnumerable<FacilityMasterLoanTransView> GetLoanTransactionByCcyDates(string strDateFrom, string strDateTo, string ccy)
		{
			if (!(strDateFrom != null && strDateTo != null)) return new List<FacilityMasterLoanTransView>();
        
            DateTime dateFrom = DateTime.Parse(strDateFrom);
            DateTime dateTo = DateTime.Parse(strDateTo);
            DateTime defaultDatetime = DateTime.Parse("1900-01-01 00:00:00");

            //using LOANDbContext appDbContext = new();
            var entry = (from lt in appDbContext.LoanTrans
                         join fm in appDbContext.FacilityMasters on lt.RefNo equals fm.RefNo
                         join st in appDbContext.StatusCodes on lt.Status equals st.StatusCode1

                         join cv in appDbContext.VGuideCustomerMasters
                              on new { fm.CustAbbr, fm.BranchNo } equals new { cv.CustAbbr, cv.BranchNo }
                                  // not working. why?
                                  //join cv in entities2.CUSTOMER_MASTER on fm.CUST_ABBR equals cv.CUST_ABBR
                         where lt.Status != "F"
                               && lt.DrawCcy == ccy
                               && EF.Functions.DateDiffDay(lt.StartDate,dateFrom)<=0
                               && EF.Functions.DateDiffDay(lt.StartDate,dateTo) >= 0
                         orderby lt.RefNo, lt.StartDate, lt.TransNo
                         select new FacilityMasterLoanTransView()
                         {
                             REF_NO = lt.RefNo,
                             TRANS_NO = lt.TransNo,
                             CUST_NAME = cv.CustName,

                             START_DATE = (EF.Functions.DateDiffDay(lt.StartDate, defaultDatetime)==0) ? "" : lt.StartDate.ToString().Substring(0, 10),

                             DUE_DATE = (EF.Functions.DateDiffDay(lt.DueDate, defaultDatetime)==0) ? "" : lt.DueDate.ToString().Substring(0, 10),

                             DAYS = lt.Days,
                             DRAW_CCY = lt.DrawCcy,
                             DRAW_AMT = lt.DrawAmt,
                             REPAY_AMT = lt.RepayAmt,
                             REPAY_CCY = lt.RepayCcy,

                             INT_RATE = lt.IntRate,
                             INTERNAL_RATE = lt.InternalRate ?? "",
                             STATUS = st.StatusDesc,

                             SPREAD = lt.Spread,
                             INT_AMT = lt.IntAmt,
                             REMARKS = lt.Remarks,
                         })
                        .ToList();
            return entry;
        }
	}
}
