
using System;
using System.Collections.Generic;
using System.Linq;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;

namespace mhcb.Syd.Business.Repository
{
    public class BankInfRepository : IBankInf
    {
        private readonly GUIDEDbContext appDbContext;
        public BankInfRepository(GUIDEDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<BankInfView> GetPendingTrans()
        {
            //using GUIDEDbContext appDbContext = new();
            string[] validStatus = { "F", "A", "M", "V" };
            var entry = (from b in appDbContext.BankInfs
                         join c in appDbContext.BankInfCorrs on b.SwiftId equals c.SwiftId into c1
                         from bankInfcorr in c1.DefaultIfEmpty()
                         join y in appDbContext.Fxfccies on bankInfcorr.CcyCd equals y.CcyCd into y1
                         from fxccy in y1.DefaultIfEmpty()
                         where (!validStatus.Contains(b.Status))
                         select new BankInfView()
                         {
                             SWIFT_ID = b.SwiftId,
                             BRANCH_NO = b.BranchNo,
                             SETTL_BRANCH_NO = b.SettlBranchNo,
                             ACRONYM = b.Acronym,
                             NAME_ADDR_1 = b.NameAddr1,
                             NAME_ADDR_2 = b.NameAddr2,
                             NAME_ADDR_3 = b.NameAddr3,
                             NAME_ADDR_4 = b.NameAddr4,
                             LOCATION_COUNTRY = b.LocationCountry,
                             SWIFT_FLG = b.SwiftFlg,
                             CHIPS_UID = b.ChipsUid,
                             COR_BANK_CD = b.CorBankCd,
                             STATUS = b.Status,
                             DELETION_STATUS = b.DeletionStatus,
                             GIP_STATUS = b.GipStatus,
                             GIP_DESCRIPTION = b.GipDescription,
                             AUTHORIZE_BY = b.AuthorizeBy,
                             TRAN_NO = b.TranNo,

                             MM_SETTL_BANK_ID = bankInfcorr.MmSettlBankId ?? String.Empty,
                             CCY = fxccy.Ccy ?? String.Empty
                         })
                        .ToList();
            return entry;
        }

        public IEnumerable<BankInfView> GetBankInfByDetails(string custName, string branchNo)
        {
            //using GUIDEDbContext appDbContext = new();
            var entry = (from b in appDbContext.BankInfs
                         join c in appDbContext.BankInfCorrs on b.SwiftId equals c.SwiftId into c1
                         from bankInfcorr in c1.DefaultIfEmpty()
                         join y in appDbContext.Fxfccies on bankInfcorr.CcyCd equals y.CcyCd into y1
                         from fxccy in y1.DefaultIfEmpty()
                         where b.NameAddr1.Contains(custName)
                               && b.BranchNo == branchNo
                               && (!String.IsNullOrEmpty(b.SwiftId))
                         select new BankInfView()
                         {
                             
                             SWIFT_ID = b.SwiftId,
                             BRANCH_NO = b.BranchNo,
                             SETTL_BRANCH_NO = b.SettlBranchNo,
                             ACRONYM = b.Acronym,
                             NAME_ADDR_1 = b.NameAddr1,
                             NAME_ADDR_2 = b.NameAddr2,
                             NAME_ADDR_3 = b.NameAddr3,
                             NAME_ADDR_4 = b.NameAddr4,
                             LOCATION_COUNTRY = b.LocationCountry,
                             SWIFT_FLG = b.SwiftFlg,
                             CHIPS_UID = b.ChipsUid,
                             COR_BANK_CD = b.CorBankCd,
                             STATUS = b.Status,
                             DELETION_STATUS = b.DeletionStatus,
                             //GIP_STATUS = b.GipStatus,
                             //GIP_DESCRIPTION = b.GipDescription,
                             AUTHORIZE_BY = b.AuthorizeBy,
                             //TRAN_NO = b.TranNo,

                             MM_SETTL_BANK_ID = bankInfcorr.MmSettlBankId ?? String.Empty,
                            CCY = fxccy.Ccy ?? String.Empty
                             //CCY = y.Ccy ?? String.Empty
                         })
                        .ToList();
            return entry;

        }

		public IEnumerable<BankInfView> GetBankInfBySwiftID(string swiftId)
		{

            //using GUIDEDbContext appDbContext = new();
            var entry = (from b in appDbContext.BankInfs
                         join c in appDbContext.BankInfCorrs on b.SwiftId equals c.SwiftId into c1
                         from bankInfcorr in c1.DefaultIfEmpty()
                         join y in appDbContext.Fxfccies on bankInfcorr.CcyCd equals y.CcyCd into y1
                         from fxccy in y1.DefaultIfEmpty()
                         where b.SwiftId == swiftId && (!String.IsNullOrEmpty(b.SwiftId))
                         select new BankInfView()
                         {
                             
                             SWIFT_ID = b.SwiftId,
                             BRANCH_NO = b.BranchNo,
                             SETTL_BRANCH_NO = b.SettlBranchNo,
                             ACRONYM = b.Acronym,
                             NAME_ADDR_1 = b.NameAddr1,
                             NAME_ADDR_2 = b.NameAddr2,
                             NAME_ADDR_3 = b.NameAddr3,
                             NAME_ADDR_4 = b.NameAddr4,
                             LOCATION_COUNTRY = b.LocationCountry,
                             SWIFT_FLG = b.SwiftFlg,
                             CHIPS_UID = b.ChipsUid,
                             COR_BANK_CD = b.CorBankCd,
                             STATUS = b.Status,
                             DELETION_STATUS = b.DeletionStatus,
                             //GIP_STATUS = b.GipStatus,
                             //GIP_DESCRIPTION = b.GipDescription,
                             AUTHORIZE_BY = b.AuthorizeBy,
                             //TRAN_NO = b.TranNo,

                             MM_SETTL_BANK_ID = bankInfcorr.MmSettlBankId ?? String.Empty,
                             //CCY = y.Ccy ?? String.Empty
                            CCY = fxccy.Ccy ?? String.Empty
                         })
                        .ToList();
            return entry;
        }

        public IEnumerable<BankInfView> GetFullBankInfByStatus(string status)
        {
            //using GUIDEDbContext appDbContext = new();
            var entry = (from b in appDbContext.BankInfs
                         join c in appDbContext.BankInfCorrs on b.SwiftId equals c.SwiftId into c1
                         from bankInfcorr in c1.DefaultIfEmpty()
                         join y in appDbContext.Fxfccies on bankInfcorr.CcyCd equals y.CcyCd into y1
                         from fxccy in y1.DefaultIfEmpty()
                         where (b.Status == (status.ToUpper() == "ALL" ? b.Status : status)
                                 && (b.DeletionStatus == "")
                                 && !String.IsNullOrEmpty(b.SwiftId))
                         select new BankInfView()
                         {
                             SWIFT_ID = b.SwiftId,
                             BRANCH_NO = b.BranchNo,
                             //SETTL_BRANCH_NO = b.SettlBranchNo,
                             ACRONYM = b.Acronym,
                             NAME_ADDR_1 = b.NameAddr1,
                             NAME_ADDR_2 = b.NameAddr2,
                             NAME_ADDR_3 = b.NameAddr3,
                             NAME_ADDR_4 = b.NameAddr4,
                             LOCATION_COUNTRY = b.LocationCountry,
                             SWIFT_FLG = b.SwiftFlg,
                             CHIPS_UID = b.ChipsUid,
                             COR_BANK_CD = b.CorBankCd,
                             STATUS = b.Status,
                             DELETION_STATUS = b.DeletionStatus,
                             //GIP_STATUS = b.GipStatus,
                             //GIP_DESCRIPTION = b.GipDescription,
                             AUTHORIZE_BY = b.AuthorizeBy,
                             //TRAN_NO = b.TranNo,

                             MM_SETTL_BANK_ID = bankInfcorr.MmSettlBankId ?? String.Empty,
                             CCY = fxccy.Ccy ?? String.Empty,
                             //CCY = y.Ccy ?? String.Empty
                             //MM_SETTL_BANK_ACTNO = bankInfcorr.MmSettlBankActno ?? String.Empty,
                         }).Distinct()
                        .ToList();
            return entry;
        }
        public IEnumerable<BankInfView> GetBankInfsByStatus(string status = "All")
		{
            //using GUIDEDbContext appDbContext = new();
            if (status != "D")
            {
                var entry = (from b in appDbContext.BankInfs
                             join c in appDbContext.BankInfCorrs on b.SwiftId equals c.SwiftId into c1
                             from bankInfcorr in c1.DefaultIfEmpty()
                             join y in appDbContext.Fxfccies on bankInfcorr.CcyCd equals y.CcyCd into y1
                             from fxccy in y1.DefaultIfEmpty()
                             where (b.Status == (status.ToUpper() == "ALL" ? b.Status : status)
                                        && (b.DeletionStatus == "")
                                        && !String.IsNullOrEmpty(b.SwiftId))
                             select new BankInfView()
                             {
                                 
                                 SWIFT_ID = b.SwiftId,
                                 BRANCH_NO = b.BranchNo,
                                 SETTL_BRANCH_NO = b.SettlBranchNo,
                                 ACRONYM = b.Acronym,
                                 NAME_ADDR_1 = b.NameAddr1,
                                 NAME_ADDR_2 = b.NameAddr2,
                                 NAME_ADDR_3 = b.NameAddr3,
                                 NAME_ADDR_4 = b.NameAddr4,
                                 LOCATION_COUNTRY = b.LocationCountry,
                                 SWIFT_FLG = b.SwiftFlg,
                                 CHIPS_UID = b.ChipsUid,
                                 COR_BANK_CD = b.CorBankCd,
                                 STATUS = b.Status,
                                 DELETION_STATUS = b.DeletionStatus,
                                 //GIP_STATUS = b.GipStatus,
                                 //GIP_DESCRIPTION = b.GipDescription,
                                 AUTHORIZE_BY = b.AuthorizeBy,
                                 //TRAN_NO = b.TranNo,

                                 MM_SETTL_BANK_ID = bankInfcorr.MmSettlBankId ?? String.Empty,
                                 //CCY = y.Ccy ?? String.Empty
                                 CCY = fxccy.Ccy ?? String.Empty
                             })
                       .ToList();
                return entry;
            }
            else
            {
                var entry = (from b in appDbContext.BankInfs
                             join c in appDbContext.BankInfCorrs on b.SwiftId equals c.SwiftId into c1
                             from bankInfcorr in c1.DefaultIfEmpty()
                             join y in appDbContext.Fxfccies on bankInfcorr.CcyCd equals y.CcyCd into y1
                             from fxccy in y1.DefaultIfEmpty()
                             where ((b.Status == "F")
                             && (b.DeletionStatus == status)
                             && !String.IsNullOrEmpty(b.SwiftId))
                             select new BankInfView()
                             {
                                
                                 SWIFT_ID = b.SwiftId,
                                 BRANCH_NO = b.BranchNo,
                                 SETTL_BRANCH_NO = b.SettlBranchNo,
                                 ACRONYM = b.Acronym,
                                 NAME_ADDR_1 = b.NameAddr1,
                                 NAME_ADDR_2 = b.NameAddr2,
                                 NAME_ADDR_3 = b.NameAddr3,
                                 NAME_ADDR_4 = b.NameAddr4,
                                 LOCATION_COUNTRY = b.LocationCountry,
                                 SWIFT_FLG = b.SwiftFlg,
                                 CHIPS_UID = b.ChipsUid,
                                 COR_BANK_CD = b.CorBankCd,
                                 STATUS = b.Status,
                                 DELETION_STATUS = b.DeletionStatus,
                                 //GIP_STATUS = b.GipStatus,
                                 //GIP_DESCRIPTION = b.GipDescription,
                                 AUTHORIZE_BY = b.AuthorizeBy,
                                 //TRAN_NO = b.TranNo,

                                 MM_SETTL_BANK_ID = bankInfcorr.MmSettlBankId ?? String.Empty,
                                 CCY = fxccy.Ccy ?? String.Empty
                                 //CCY = y.Ccy ?? String.Empty
                             })
                       .ToList();
                return entry;
            }
        }

		public string UpdateStatus(BankInfStatus status)
		{
            
            try
            {
                //using GUIDEDbContext appDbContext = new();
                string[] validStatus = { "F", "A", "M", "V" };

                var entry = appDbContext.BankInfs
                     .Where(e => e.SwiftId.ToLower() == status.SwiftId.ToLower()
                           && (e.AuthorizeBy == status.AuthorizeBy || e.AuthorizeBy.ToUpper() == "SYSTEM")
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
                        RefNo = status.SwiftId.ToString(),
                        TransNo = status.TranNo ?? "99999",
                        AuditDesc = "Sent BIF to Finalized",
                        AppName = "GUIDE",
                        TableName = "Bank Information",
                        OriginalValue = guideStatus + " : " + delstatus,
                        NewValue = status.Status + " : " + status.DeletionStatus,
                    };

                    entry.AuthorizeBy = string.IsNullOrEmpty(status.AuthorizeBy) ? entry.AuthorizeBy : status.AuthorizeBy;
                    entry.Status = string.IsNullOrEmpty(status.Status) ? entry.Status : status.Status;
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
