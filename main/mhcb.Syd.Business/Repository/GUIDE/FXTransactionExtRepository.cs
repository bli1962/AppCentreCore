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

            var entry = (from fxExt in appDbContext.FxTransactionExts
                         join fx in appDbContext.FxTransactions on fxExt.RefNo equals fx.RefNo
                         where fxExt.Printed == true && fxExt.Gidupload == true
                         && EF.Functions.DateDiffDay(fx.AddOn, date) == 0
                         //.Where(e => e.Printed == true
                         //       && e.Gidupload == true
                         //       && EF.Functions.DateDiffDay(e.PrintDateTime, date)==0
                         //)
                         //.OrderByDescending(e => e.PrintDateTime)
                         select new FXTransactionExtView()
                         {
                             REF_NO = fxExt.RefNo,
                             ContractId = fxExt.ContractId,
                             TradeId = fxExt.TradeId,
                             Event = fxExt.Event,
                             PortfolioGroup = fxExt.PortfolioGroup,
                             PortfolioDesk = fxExt.PortfolioDesk,
                             PortfolioBook = fxExt.PortfolioBook,
                             AuthorisedDealer = fxExt.AuthorisedDealer,
                             CONTRACT_CCY_ABBR_ORIG = fxExt.ContractCcyAbbrOrig,

                             EQUIV_CCY_ABBR_ORIG = fxExt.EquivCcyAbbrOrig,
                             Printed = (fxExt.Printed ?? false) ? "Y" : "N",
                             //PrintDateTime = (DbFunctions.TruncateTime(fxExt.PrintDateTime).ToString()).Substring(0, 10),
                             //PrintDateTime = (DateTime)fxExt.PrintDateTime,
                             PrintDateTime = (fxExt.PrintDateTime != null) ? (DateTime)fxExt.PrintDateTime: DateTime.Parse("1900-01-01"),
                             GIDUpload = fxExt.Gidupload ? "True" : "False",
                         })
                        .ToList();
            return entry;
        }

		public string UpdateStatus(InputFXGID status)
		{
			try
			{
                //using GUIDEDbContext appDbContext  = new();
                //DateTime date = DateTime.Parse(status.optDate);
                var entry = appDbContext.FxTransactionExts
                            .Where(e => e.Printed == true
                                    && e.RefNo == status.RefNo
                                    // remove it for inter bank deal no print date value
                                    //&& (EF.Functions.DateDiffDay(e.PrintDateTime, status.optDate) == 0)
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
