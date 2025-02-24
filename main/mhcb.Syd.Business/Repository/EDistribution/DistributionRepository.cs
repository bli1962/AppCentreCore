using mhcb.Syd.Business.Utilities;
using mhcb.Syd.DataAccess.Models.EDistribution;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Business.Repository.EDistribution
{
    public class DistributionRepository : IDistribution
    {
        private readonly eDistributionContext appDbContextEDist;
        private readonly GUIDEDbContext appDbContextGuide;

        public DistributionRepository(eDistributionContext appDbContexteDistribution, GUIDEDbContext appDbContext)
        {
            this.appDbContextGuide = appDbContext;
            this.appDbContextEDist = appDbContexteDistribution;
        }

        public IEnumerable<DistributionPreferenceView> GetDistributionPreference(string appName)
        {
            var entry = (from b in appDbContextGuide.DistributionPreferences
                         join c in appDbContextGuide.CustomerMasters on b.CustomerAbbr equals c.CustAbbr into c1
                         from custMaster in c1.DefaultIfEmpty()

                         join y in appDbContextGuide.DistributionTypes on b.DistributionType equals y.Id into y1
                         from distType in y1.DefaultIfEmpty()

                         where b.DistributionChannel == 1
                                && custMaster.StatusCd != "C"
                                && (appName != "All" && distType.VisableToSystem.Contains(appName)
                                || appName == "All" && (distType.VisableToSystem.Contains("eLCS") || distType.VisableToSystem.Contains("GUIDE")))
                         select new DistributionPreferenceView()
                         {
                             CUST_ABBR = b.CustomerAbbr,
                             CUST_NAME = custMaster.CustName,
                             VisableToSystem = distType.VisableToSystem,
                             DistributionType = distType.DistributionType1,
                             Address = b.Address.Replace("\n", "").Replace("\r", ""),
                             Status = b.Status
                         })
                        .ToList();
            return entry;
        }


        public IEnumerable<DistributionPasswordView> GetDistributionPassword(string Abbreviation, string Branch, string sharedKey)
        {
            if (string.IsNullOrEmpty(Abbreviation) && string.IsNullOrEmpty(Branch))
                yield return null;

            //var query = from a in appDbContext.DistributionPasswords select a;

            ////if (!string.IsNullOrEmpty(Code))
            ////    query = query.Where(a => a.CustomerCode == Code);
            //if (!string.IsNullOrEmpty(Abbreviation))
            //    query = query.Where(a => a.CustomerAbbr == Abbreviation);
            //if (!string.IsNullOrEmpty(Branch))
            //    query = query.Where(a => a.CustomerBranch == Branch);

            //DistributionPassword distributionPassword = query.ToList().OrderByDescending(a => a.Id).First();

            DistributionPasswordView entry = appDbContextGuide.DistributionPasswords
                        .Where(e => e.CustomerAbbr == Abbreviation
                                 && e.CustomerBranch == Branch
                                 )
                        .Select(x => new DistributionPasswordView()
                        {
                            Id = x.Id,
                            CustomerCode = x.CustomerCode,
                            Password = x.Password,
                            CustomerBranch = x.CustomerBranch,
                            CustomerAbbr = x.CustomerAbbr,
                            Encode = x.Encode
                        })
                        .ToList()
                        .OrderByDescending(a => a.Id)
                        .First();

            entry.Password = Crypto.DecryptStringAES(entry.Password, sharedKey);
            //return entry;
            yield return entry;
        }


        public IEnumerable<DistributionView> GetElcsConfirmation(string dateAdded)
        {
            DateTime dateAdd = DateTime.Parse(dateAdded);
            var entry = (from b in appDbContextEDist.Distributions
                         where (EF.Functions.DateDiffDay(b.DateAdded, dateAdd) == 0)                     
                                && b.DocumentId == 0
                         select new DistributionView()
                         {
                             Id = b.Id,
                             Status = b.Status,
                             ChannelId = 
                                        (
                                            b.ChannelId == 1 ? "Email" :
                                            b.ChannelId == 2 ? "FX" :
                                            b.ChannelId == 3 ? "Mail":
                                            b.ChannelId == 4 ? "MGeB" :
                                            b.ChannelId == 5 ? "MT300":
                                            b.ChannelId == 6 ? "EPlatform" : "Unknown"
                                        ),
                             DeliveryAddress = b.DeliveryAddress,
                             CustomerCode = b.CustomerCode,
                             CustAbbr = b.CustAbbr,
                             Reference = b.Reference,
                             DateAdded = b.DateAdded.ToShortDateString(),
                             DateSent =  b.DateSent.ToString(),
                             AddedBy = b.AddedBy,
                             SentBy = b.SentBy
                         })
                        .ToList();
            return entry;
        }

        public string UpdateStatus(InputEDistribution status)
        {
            try
            {
                //using eDistributionContext appDbContext = new();
                var entry = appDbContextEDist.Distributions
                            .Where(x => (x.Id == status.Id) && 
                                    (x.Status == "E") &&
                                    //(x.Channel == "1") &&
                                    ((x.AddedBy == status.AuthorizeBy) || (x.SentBy == status.AuthorizeBy)))
                            .FirstOrDefault();      

                if (entry != null)
                {
                    AuditLog auditLog = new()
                    {
                        UserId = status.AuthorizeBy,
                        AuditDate = DateTime.Now,
                        RefNo = status.Id.ToString(),
                        TransNo = "",
                        AuditDesc = "Sent ELCS confirmation to Re-Sent",
                        AppName = "eDistribution",
                        TableName = "Distributions",
                        OriginalValue = entry.Status.ToString(),
                        NewValue = "P",
                    };

                    entry.Status = "P";
                    appDbContextEDist.SaveChanges();

                   // AuditLogRepository.InsertAuditLog(auditLog);
                    appDbContextGuide.AuditLogs.Add(auditLog);
                    appDbContextGuide.SaveChanges();

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


