using System.Collections.Generic;
using System.Data;
using System.Linq;
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
	}
}
