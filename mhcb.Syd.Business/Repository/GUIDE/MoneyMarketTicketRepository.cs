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
	public class MoneyMarketTicketRepository : IMoneyMarketTicket
	{
        private readonly GUIDEDbContext appDbContext;
        public MoneyMarketTicketRepository(GUIDEDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<MoneyMarketTicketView> GetPendingTrans()
		{
            //using GUIDEDbContext appDbContext  = new();
            string[] validStatus = { "F", "A", "V" };
            DateTime date = DateTime.Now;
            DateTime defaultDatetime = DateTime.Parse("1900-01-01 00:00:00");

            var entry = (from b in appDbContext.MoneyMarketTickets
                         .Where(e => e.PrintStatus == true
                                && e.Gidupload == true
                                && EF.Functions.DateDiffDay(e.TicketCreatedTimestamp, date) ==0
                         //&& e.Gidupload == true       )                            
                         ).OrderByDescending(e => e.TicketCreatedTimestamp)
                         select new MoneyMarketTicketView()
                         {
                             TicketId = b.MmticketId,
                             REF_NO = b.GbaseRefNo,
                             Counterparty = b.CounterpartyShortName,
                             Event = b.Event,
                             Typology = b.Typology,
                             TradeId = b.MurexTradeId,

                             PortfolioGroup = b.PortfolioGroup,
                             PortfolioDesk = b.PortfolioDesk,
                             PortfolioBook = b.PortfolioBook,
                             Currency = b.Currency,
                             PrincipalAmount = b.PrincipalAmount,

                             InputBy = b.FrontOfficeInputBy,
                             AuthorisedBy = b.FrontOfficeAuthorisedBy,

                             PrintStatus = b.PrintStatus ? "Y" : "N",
                             PrintDateTime = (EF.Functions.DateDiffDay(b.TicketCreatedTimestamp, defaultDatetime)==0) ? "" : b.TicketCreatedTimestamp.ToShortDateString(),

                             GIDUpload = b.Gidupload ? "True" : "False",
                         })

                        .ToList();
            return entry;
        }

		public IEnumerable<MoneyMarketReportView> GetMoneyMarketTransactionByDates(string strDateFrom, string strDateTo)
		{
			if (!(strDateFrom != null && strDateTo != null)) return new List<MoneyMarketReportView>();

            //using GUIDEDbContext appDbContext  = new();
            string[] validStatus = { "F", "A", "V" };

            DateTime date = DateTime.Now;
            DateTime dateFrom = DateTime.Parse(strDateFrom);
            DateTime dateTo = DateTime.Parse(strDateTo);
            DateTime defaultDatetime = DateTime.Parse("1900-01-01 00:00:00");

            var entry = (from mm in appDbContext.MoneyMarketTickets
                         join cm in appDbContext.CustomerMasters on mm.CounterpartyAbbreviation equals cm.CustAbbr
                         join fc in appDbContext.Fxfcusts on cm.CustCode equals fc.Code
                         join mxCust in appDbContext.MxCustCounterpartyTypes on fc.CustId equals mxCust.CustId
                         join mxType in appDbContext.MxCounterpartyTypes on mxCust.CounterpartyTypeId equals mxType.Id

                         where EF.Functions.DateDiffDay(mm.OperationDate, dateFrom)<=0
                            && EF.Functions.DateDiffDay(mm.OperationDate, dateTo) >=0
                            //&& (mxType.ID == 1 || mxType.ID == 14)
                            && mm.PrintStatus == true
                            && mm.Gidupload == true
                         orderby mm.Typology, mm.GbaseRefNo, mm.ContractVersion

                         select new MoneyMarketReportView()
                         {
                             GBaseRefNo = mm.GbaseRefNo,

                             CounterpartyAbbreviation = mm.CounterpartyAbbreviation,
                             CounterpartyShortName = mm.CounterpartyShortName,
                             TicketTemplate = mm.TicketTemplate,

                             Event = mm.Event,
                             Typology = mm.Typology,

                             PortfolioDesk = mm.PortfolioDesk,
                             PortfolioBook = mm.PortfolioBook,

                             ContractVersion = mm.ContractVersion,

                             OperationDate = (EF.Functions.DateDiffDay(mm.OperationDate, defaultDatetime)==0) ? "" : mm.OperationDate.ToShortDateString(),

                             ContractDate = (EF.Functions.DateDiffDay(mm.ContractDate, defaultDatetime)==0) ? "" : mm.ContractDate.ToString().Substring(0, 10),

                             ValueDate = (EF.Functions.DateDiffDay(mm.ValueDate, defaultDatetime)==0) ? "" : mm.ValueDate.ToString().Substring(0, 10),

                             FinalDueDate = (EF.Functions.DateDiffDay(mm.FinalDueDate, defaultDatetime)==0) ? "" : mm.FinalDueDate.ToString().Substring(0, 10),

                             DueDate = (EF.Functions.DateDiffDay(mm.DueDate, defaultDatetime)==0) ? "" : mm.DueDate.ToString().Substring(0, 10),

                             TradeDate = (EF.Functions.DateDiffDay(mm.TradeDate, defaultDatetime)==0) ? "" : mm.TradeDate.ToString().Substring(0, 10),

                             PaymentDate = (EF.Functions.DateDiffDay(mm.PaymentDate, defaultDatetime)==0) ? "" : mm.PaymentDate.ToString().Substring(0, 10),

                             Currency = mm.Currency,
                             PrincipalAmount = mm.PrincipalAmount,

                             InterestRate = mm.InterestRate,
                             InterestAmount = mm.InterestAmount,

                             InternalRate = mm.InternalRate,
                             SettlementDetails = mm.SettlementDetails,

                             //-- not for ('Call Depo', 'Call Loan') , 
                             //-- not for ('CD')
                             //-- but for Typology in ('Depo', 'Loan') 
                             NetInterest = mm.NetInterest,
                             TotalDue = mm.TotalDue,

                             //-- not for Typology in ('Depo', 'Loan') 
                             //-- not for ('CD')  
                             PrincipalAmountPrevious = mm.PrincipalAmountPrevious,
                             RolloverType = mm.RolloverType,
                             RolloverTypeLabel = mm.RolloverTypeLabel,
                             PrincipalAmountClosing = mm.PrincipalAmountClosing,
                             SettlementDirectionLabel = mm.SettlementDirectionLabel,

                             //-- For ('CD')  only
                             BuySell = mm.BuySell,

                             //-- not for ('Call Depo', 'Call Loan') , 
                             //-- not for ('Depo', 'Loan')  
                             Denomination = mm.Denomination,
                             Quantity = mm.Quantity,
                             FaceAmount = mm.FaceAmount,
                             ConsiderationAmount = mm.ConsiderationAmount,

                             TransactionStatus = mm.TransactionStatus,
                             DEPARTMENT_CD = cm.DepartmentCd,
                         })

                        .ToList();
            return entry;
        }

		public string UpdateStatus(MMGIDStatus status)
		{
			try
			{
                //using GUIDEDbContext appDbContext  = new();
                //DateTime date = DateTime.Parse(status.optDate);

                var entry = appDbContext.MoneyMarketTickets
                    .Where(e => e.PrintStatus == true
                            && e.MmticketId == status.TicketId
                            && EF.Functions.DateDiffDay(e.TicketCreatedTimestamp, status.optDate) ==0
                            //&& e.Gidupload == true 
                            )
                    .FirstOrDefault();

                if (entry != null)
                {

                    AuditLog auditLog = new()
                    {
                        UserId = status.AuthorizeBy,
                        AuditDate = DateTime.Now,
                        RefNo = status.TicketId.ToString(),
                        TransNo = "",
                        AuditDesc = "Reset MM GID Upload",
                        AppName = "GUIDE",
                        TableName = "MoneyMarketTicket",
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
