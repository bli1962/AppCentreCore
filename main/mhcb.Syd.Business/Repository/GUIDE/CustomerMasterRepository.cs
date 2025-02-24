using System.Collections.Generic;
using System.Data;
using System.Linq;
using mhcb.Syd.Business.Utilities;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;

namespace mhcb.Syd.Business.Repository
{
	public class CustomerMasterRepository : ICustomerMaster
	{
        private readonly GUIDEDbContext appDbContext;
        public CustomerMasterRepository(GUIDEDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<CustomerMaster> LoadCustomerMasterByCustAbbr(string custAbbr, string branchNo)
		{
            //using GUIDEDbContext appDbContext = new();
            var entry = appDbContext.CustomerMasters
                        .Where(e => e.CustAbbr == custAbbr
                                 && e.BranchNo == branchNo
                                 && e.StatusCd != "C")
                        .Select(x => new CustomerMaster()
                        {
                            CustAbbr = x.CustAbbr,
                            BranchNo = x.BranchNo,
                            StepsCustCd = x.StepsCustCd,
                            CustName = x.CustName,
                            Address = x.Address,
                            Address2 = x.Address2,
                            DepartmentCd = x.DepartmentCd,
                            OfficerCd = x.OfficerCd,
                            LocationCountry = x.LocationCountry,
                            TaxCd = x.TaxCd,
                            Nationality = x.Nationality,
                            StatusCd = x.StatusCd,
                            DeletionStatus = x.DeletionStatus,
                            Status = x.Status,
                        })
                        .ToList();
            return entry;
        }

        public IEnumerable<CustDistirbutionInfo> LoadDistirbutionPasswordByCustName(string custName, string branchNo, string sharedKey)
        {
            //using GUIDEDbContext appDbContext = new();
            //var entry = appDbContext.CustomerMasters
            //            .Where(e => e.CustName.Contains(custName)
            //                     && e.BranchNo == branchNo
            //                     && e.StatusCd != "C")
            //            .Select(x => new CustAbbrInfo()
            //            {
            //                CUST_ABBR = x.CustAbbr,
            //                CUST_NAME = x.CustName,
            //                BRANCH_NO = x.BranchNo,
            //                STEPS_CUST_CD = x.StepsCustCd,
            //                ADDRESS = x.Address,
            //                ADDRESS2 = x.Address2,
            //                DEPARTMENT_CD = x.DepartmentCd,
            //                STATUS_CD = x.StatusCd,                         
            //                STATUS = x.Status,
            //            })
            //            .ToList();
            //return entry;


            var entry = (from c in appDbContext.CustomerMasters
                         join d in appDbContext.DistributionPasswords on c.CustAbbr equals d.CustomerAbbr
                         //on new { c.CustAbbr, c.BranchNo } equals new { d.CustomerAbbr, d.CustomerBranch }
                         where (c.CustName.Contains(custName)
                                 && c.BranchNo == branchNo
                                 && c.StatusCd != "C")
                        select new  CustDistirbutionInfo()
                        {
                            CUST_ABBR = c.CustAbbr,
                            CUST_NAME = c.CustName,
                            BRANCH_NO = c.BranchNo,
                            STEPS_CUST_CD = c.StepsCustCd,
                            ADDRESS = c.Address,
                            ADDRESS2 = c.Address2,
                            DEPARTMENT_CD = c.DepartmentCd,
                            STATUS_CD = c.StatusCd,
                            STATUS = c.Status,
                            Password = Crypto.DecryptStringAES(d.Password, sharedKey)
                        })
                        .ToList();
            return entry;




        }
    }
}
