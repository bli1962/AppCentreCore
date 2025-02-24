using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;

namespace mhcb.Syd.Business.Repository
{
	public class LoanMasterTrancheRepository : ILoanMasterTranche
	{       
        private readonly LOANDbContext appDbContext;
        private readonly GUIDEDbContext appDbContextGuide;
        public LoanMasterTrancheRepository(LOANDbContext appDbContext, GUIDEDbContext appDbContext2)
        {
            this.appDbContext = appDbContext;
            this.appDbContextGuide = appDbContext2;
        }

        public IEnumerable<LoanMasterTrancheView> GetCovenantCheckList()
		{
            //using LOANDbContext appDbContext = new();
            //using GUIDEDbContext appDbContext2 = new();

            var entry = (from lm in appDbContext.LoanMasters
                         join cm in appDbContextGuide.CustomerMasters on lm.CustAbbr equals cm.CustAbbr
                         join tm in appDbContext.TrancheMasters on lm.LoanNo equals tm.LoanNo

                         select new LoanMasterTrancheView()
                         {
                             LOAN_NO = lm.LoanNo,
                             GCIF = lm.Gcif,
                             CCIF = lm.Ccif,
                             CCIF_NAME = lm.CcifName,
                             REMARKS = lm.Remarks,
                             AGREEM_DATE1 = lm.AgreemDate1,
                             AGREEM_DATE2 = lm.AgreemDate2,
                             AMENDMENT_DATE = lm.AmendmentDate,
                             STATUS = lm.Status,

                             TRANCHE_NAME = tm.TrancheName,
                             TRANCHE_NO = tm.TrancheNo,
                             CUST_ABBR = cm.CustAbbr,
                             //STATUS_DESC = sc.SHORT_DESC
                         })
                        .ToList();
            return entry;
        }
		
		public IEnumerable<LoanMasterTrancheView> GetLiborDiscontinuation()
		{
            //using LOANDbContext appDbContext = new();
            //using GUIDEDbContext appDbContext2 = new();

            var entry = (from lm in appDbContext.LoanMasters
                         join cm in appDbContextGuide.CustomerMasters on lm.CustAbbr equals cm.CustAbbr
                         join tm in appDbContext.TrancheMasters on lm.LoanNo equals tm.LoanNo
                         join sc in appDbContext.LoanMasterStatusCodes on lm.Status equals sc.StatusCode
                         where sc.Module == "LOAN_MASTER"
                         select new LoanMasterTrancheView()
                         {
                             LOAN_NO = lm.LoanNo,
                             GCIF = lm.Gcif,
                             CCIF = lm.Ccif,
                             CCIF_NAME = lm.CcifName,
                             REMARKS = lm.Remarks,
                             AGREEM_DATE1 = lm.AgreemDate1,
                             AGREEM_DATE2 = lm.AgreemDate2,
                             AMENDMENT_DATE = lm.AmendmentDate,

                             TRANCHE_NAME = tm.TrancheName,
                             TRANCHE_NO = tm.TrancheNo,
                             CUST_ABBR = cm.CustAbbr,
                             STATUS = lm.Status,
                             STATUS_DESC = sc.ShortDesc
                         })
                        .ToList();
            return entry;
        }
	}
}
