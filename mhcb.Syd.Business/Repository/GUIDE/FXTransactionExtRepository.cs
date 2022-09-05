using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;

namespace mhcb.Syd.Business.Repository
{
	public class FXTransactionExtRepository : IFXTransactionExt
	{
        private readonly GUIDEDbContext appDbContext;
        public FXTransactionExtRepository(GUIDEDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<FXTransactionExtView> GetPendingTrans()
		{
            //using GUIDEDbContext appDbContext  = new();
            string[] validStatus = { "F", "A", "V" };
            DateTime date = DateTime.Now;
            DateTime defaultDatetime = DateTime.Parse("1900-01-01 00:00:00");

            var entry = (from b in appDbContext.FxTransactionExts
                         .Where(e => e.Printed == true
                                && e.Gidupload == true
                                && EF.Functions.DateDiffDay(e.PrintDateTime, date)==0
                         //&& e.Gidupload == true       )                            
                         ).OrderByDescending(e => e.PrintDateTime)
                         select new FXTransactionExtView()
                         {
                             REF_NO = b.RefNo,
                             ContractId = b.ContractId,
                             TradeId = b.TradeId,
                             Event = b.Event,
                             PortfolioGroup = b.PortfolioGroup,
                             PortfolioDesk = b.PortfolioDesk,
                             PortfolioBook = b.PortfolioBook,
                             AuthorisedDealer = b.AuthorisedDealer,
                             CONTRACT_CCY_ABBR_ORIG = b.ContractCcyAbbrOrig,

                             EQUIV_CCY_ABBR_ORIG = b.EquivCcyAbbrOrig,
                             Printed = (b.Printed ?? false) ? "Y" : "N",
                             //PrintDateTime = (DbFunctions.TruncateTime(b.PrintDateTime).ToString()).Substring(0, 10),
                             PrintDateTime = b.PrintDateTime.ToString().Substring(0, 10),
                             GIDUpload = b.Gidupload ? "True" : "False",
                         })

                        .ToList();
            return entry;
        }

		public string UpdateStatus(FXGIDStatus status)
		{
			try
			{
                //using GUIDEDbContext appDbContext  = new();
                //DateTime date = DateTime.Parse(status.optDate);

                var entry = appDbContext.FxTransactionExts
                    .Where(e => e.Printed == true
                            && e.RefNo == status.RefNo
                            && (EF.Functions.DateDiffDay(e.PrintDateTime, status.optDate) == 0)
                            //&& e.Gidupload == true 
                            )
                    .FirstOrDefault();

                if (entry != null)
                {

                    AuditLog auditLog = new()
                    {
                        UserId = status.AuthorizeBy,
                        AuditDate = DateTime.Now,
                        RefNo = status.RefNo.ToString(),
                        TransNo = "",
                        AuditDesc = "Reset FX GID Upload",
                        AppName = "GUIDE",
                        TableName = "FX Transaction Ext",
                        OriginalValue = entry.Gidupload.ToString(),
                        NewValue = "false",
                    };

                    entry.Gidupload = false;
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
