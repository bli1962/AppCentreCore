using mhcb.Syd.DataAccess.Models.EUCDbArchive;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Business.Repository
{
    public class FacilityTypeOverrideRepository : IFacilityTypeOverride
    {
        private readonly EUCDbArchiveDbContext appDbContext;
        private readonly GUIDEDbContext appDbContextGuide;
        public FacilityTypeOverrideRepository(EUCDbArchiveDbContext appDbContext, GUIDEDbContext appDbContext2)
        {
            this.appDbContext = appDbContext;
            this.appDbContextGuide = appDbContext2;
        }

        public string InsertFacilityType(FacilityTypeAttribute status)
        {
            try
            {
                var entry = appDbContext.FacilityTypeOverrides.FirstOrDefault(
                              e => e.RefNo == status.RefNo);
                              //&& e.FacilityType == status.FacilityType);

                if (entry == null)
                {
                    AuditLog auditLog = new()
                    {
                        UserId = status.AuthorizeBy,
                        AuditDate = DateTime.Now,
                        RefNo = status.RefNo.ToString(),
                        TransNo = status.FacilityType,
                        AuditDesc = "Add Facility Reference",
                        AppName = "EUCDbArchive",
                        TableName = "Facility_Type_Override",
                        OriginalValue = "",
                        NewValue = status.FacilityType,
                    };

                    FacilityTypeOverride entryNew = new()
                    {
                        RefNo = status.RefNo.ToUpper(),
                        FacilityType = status.FacilityType,
                    };
                    appDbContext.FacilityTypeOverrides.Add(entryNew);
                    appDbContext.SaveChanges();

                    appDbContextGuide.AuditLogs.Add(auditLog);
                    appDbContextGuide.SaveChanges();
                    return "OK";
                }
                else
                {
                    return "Found";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        
    }
}
