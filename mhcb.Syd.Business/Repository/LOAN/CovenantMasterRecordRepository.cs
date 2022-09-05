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
	public class CovenantMasterRecordRepository : ICovenantMasterRecord
	{        
        private readonly LOANDbContext appDbContext;
        private readonly GUIDEDbContext appDbContextGuide;
        public CovenantMasterRecordRepository(LOANDbContext LoanDbContext, GUIDEDbContext GuideDbContext)
        {
            this.appDbContext = LoanDbContext;
            this.appDbContextGuide = GuideDbContext;
        }

        public IEnumerable<CovenantRatioView> GetCovenantRatio(string covenantType, string dateType, string strDateFrom, string strDateTo)
        {
            if (strDateTo == null) return new List<CovenantRatioView>();
            if (strDateFrom == null) return new List<CovenantRatioView>();

            //using EDocumentDbContext appDbContext  = new();
            DateTime dateFrom = DateTime.Parse(strDateFrom);
            DateTime dateTo = DateTime.Parse(strDateTo);

            //using LOANDbContext appDbContext = new();
            DateTime defaultDatetime = DateTime.Parse("1900-01-01 00:00:00");

            var entry = (from cm in appDbContext.CovenantMasters
                         join cr in appDbContext.CovenantRecords on cm.CovenantNo equals cr.CovenantNo
                         join ct in appDbContext.CovenantTypes on cm.CovType equals ct.CovenantType1
                         join cc in appDbContext.CovenantConditions on cm.ConditionType equals cc.ConditionType
                         join cg in appDbContext.CovenantConditionGroups on cc.ConditionGroup equals cg.ConditionGroupType
                         join lmc in appDbContext.LoanMasterCovenants on cm.CovenantNo equals lmc.CovenantNo
                         join lm in appDbContext.LoanMasters on lmc.LoanNo equals lm.LoanNo
                         /*"Covenant"*/
                         where ct.CovenantDecs == covenantType
                                  && (lm.Status != "T")
                                  && (cm.Status == "L")
                                  && 
                                  (
                                      (dateType == "CovStartDate"
                                          && EF.Functions.DateDiffDay(cm.CovStartDate, dateFrom) <= 0
                                          && EF.Functions.DateDiffDay(cm.CovStartDate, dateTo) >= 0) ||
                                     (dateType == "CovEndDate"
                                          && EF.Functions.DateDiffDay(cm.CovEndDate, dateFrom) <= 0
                                          && EF.Functions.DateDiffDay(cm.CovEndDate, dateTo) >= 0) ||
                                     (dateType == "CovRecReptDate"
                                          && EF.Functions.DateDiffDay(cr.ReportDate, dateFrom) <= 0
                                          && EF.Functions.DateDiffDay(cr.ReportDate, dateTo) >= 0) ||
                                     (dateType == "CovRecReptDate"
                                          && EF.Functions.DateDiffDay(cr.DueDate, dateFrom) <= 0
                                          && EF.Functions.DateDiffDay(cr.DueDate, dateTo) >= 0)
                                   )

                         orderby cm.CustAbbr, cr.RecordNo
                         select new CovenantRatioView()
                         {
                             COVENANT_NO = cm.CovenantNo,
                             CUST_ABBR = cm.CustAbbr,
                             CCIF_NAME = lm.CcifName,
                             COVENANT_DECS = ct.CovenantDecs,

                             CONDITION_GROUP_DESC = cg.ConditionGroupDesc,
                             CONDITION_DESC = cc.ConditionDesc,

                             RECORD_NO = cr.RecordNo,

                             COV_START_DATE = (EF.Functions.DateDiffDay(cm.CovStartDate, defaultDatetime) == 0) ? "" : cm.CovStartDate.ToString().Substring(0, 11),
                             COV_END_DATE = (EF.Functions.DateDiffDay(cm.CovEndDate, defaultDatetime) == 0) ? "" : cm.CovEndDate.ToString().Substring(0, 11),
       

                             DATE_RECIEVED_ADJ = (EF.Functions.DateDiffDay(cr.DateRecievedAdj, defaultDatetime)==0) ? "" : cr.DateRecievedAdj.ToString().Substring(0, 11),

                             DATE_RECIEVED = (EF.Functions.DateDiffDay(cr.DateRecieved, defaultDatetime)==0) ? "" : cr.DateRecieved.ToString().Substring(0, 11),

                             REPORT_DATE = (EF.Functions.DateDiffDay(cr.ReportDate, defaultDatetime)==0) ? "" : cr.ReportDate.ToString().Substring(0, 11),

                             DUE_DATE = (EF.Functions.DateDiffDay(cr.DueDate, defaultDatetime)==0) ? "" : cr.DueDate.ToString().Substring(0, 11),

                             RATE_ADJ = (cr.RateAdj == (decimal)(-9999999999.99)) ? "" : cr.RateAdj.ToString(),
                             RATE = (cr.Rate == (decimal)(-9999999999.99)) ? "" : cr.Rate.ToString(),
                         })
                       .ToList();
            return entry;         
        }
		
		public IEnumerable<CovenantMasterRecordView> GetCovenantMasterRecord()
		{
            //using LOANDbContext LoanDbContext = new();
            //using GUIDEDbContext GuideDbContext = new();

            string[] covenantType = { "COV", "REP" };
            DateTime defaultDatetime = DateTime.Parse("1900-01-01 00:00:00");

            var entry = (from cr in appDbContext.CovenantRecords
                         join cm in appDbContext.CovenantMasters on cr.CovenantNo equals cm.CovenantNo
                         join ct in appDbContext.CovenantTypes on cm.CovType equals ct.CovenantType1
                         join crt in appDbContext.CovenantReceiptTimings on cm.TimeOfReceipt equals crt.TimingType
                         join lmc in appDbContext.LoanMasterCovenants on cr.CovenantNo equals lmc.CovenantNo

                         join cc in appDbContext.CovenantConditions on cm.ConditionType equals cc.ConditionType
                         join cf in appDbContext.CovenantFreqTypes on cm.ReportType equals cf.FreqType

                         join lm in appDbContext.LoanMasters on lmc.LoanNo equals lm.LoanNo

                         //join cm in appDbContext.VGuideCustomerMasters
                         //  on new { fm.CUST_ABBR, fm.BRANCH_NO } equals new { cm.CUST_ABBR, cm.BRANCH_NO }

                         //join cg in appDbContext.COVENANT_CONDITION_GROUP on cg.CONDITION_GROUP equals cg.CONDITION_GROUP_TYPE                            
                         join cust in appDbContextGuide.CustomerMasters //on lm.CUST_ABBR equals cust.CUST_ABBR
                            on new { lm.CustAbbr, lm.BranchNo } equals new { cust.CustAbbr, cust.BranchNo }

                         where ct.CovenantDecs == "Covenant"
                                     && covenantType.Contains(cm.CovType)
                                     && cr.Status != "T"
                                     && cm.Status != "T"
                                     && lm.Status == "L"
                         orderby cm.CovenantNo, cr.ReportDate
                         select new CovenantMasterRecordView()
                         {
                             CUST_NAME = cust.CustName,
                             CUST_ABBR = cm.CustAbbr,  // lm.CUST_ABBR,
                             CCIF_NAME = lm.CcifName,

                             COVENANT_NO = cm.CovenantNo,
                             FREQ_TYPE = cm.FreqType,
                             MATH_SYMBOL = cm.MathSymbol,
                             VALUE = cm.Value,
                             DENOMINATION = cm.Denomination,
                             DESCRIPTION = cm.Description,

                             COVENANT_DECS = ct.CovenantDecs,
                             FREQ_DESC = cf.FreqDesc,
                             TIMING_DESC = crt.TimingDesc,
                             CONDITION_DESC = cc.ConditionDesc,

                             //CONDITION_GROUP_DESC = cg.CONDITION_GROUP_DESC,
                             //CONDITION_DESC = cg.CONDITION_DESC,

                             RECORD_NO = cr.RecordNo,
                             DATE_RECIEVED = (EF.Functions.DateDiffDay(cr.DateRecieved, defaultDatetime)==0) ? "" : cr.DateRecieved.ToString().Substring(0, 10),
                             REPORT_DATE = (EF.Functions.DateDiffDay(cr.ReportDate, defaultDatetime)==0) ? "" : cr.ReportDate.ToString().Substring(0, 10),
                             DUE_DATE = (EF.Functions.DateDiffDay(cr.DueDate, defaultDatetime)==0) ? "" : cr.DueDate.ToString().Substring(0, 10),
                             RATE = cr.Rate,
                             RATE_ADJ = cr.RateAdj,
                             DATE_RECIEVED_ADJ = (EF.Functions.DateDiffDay(cr.DateRecievedAdj, defaultDatetime)==0) ? "" : cr.DateRecievedAdj.ToString().Substring(0, 10),
                             STRESS_VALUE = cr.StressValue

                         })
                        .ToList();
            return entry;
        }
	}

}