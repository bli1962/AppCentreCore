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
	public class SettlementInfRepository : ISettlementInf
	{
        private readonly GUIDEDbContext appDbContext;
        public SettlementInfRepository(GUIDEDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<SettlementInfView> GetPendingTrans()
		{

            //Begin tran

            //	Update [GUIDE].[dbo].[SETTLEMENT_INF]
            //	Set STATUS = 'F'
            //	where STATUS not in ('F', 'A', 'V' )

            //	Update [GUIDE].[dbo].[SETTLEMENT_INF]
            //	Set STATUS = 'S', AUTHORIZE_BY = 'DL002041', AUTHORIZE_ON=getdate(), ADD_ON = getdate()
            //	where SIF_ID  in ('3326', '3325' )

            //	Update [GUIDE].[dbo].[SETTLEMENT_INF]
            //	Set STATUS = 'S', AUTHORIZE_BY = 'GW003368', AUTHORIZE_ON=getdate(), ADD_ON = getdate()
            //	where SIF_ID  in ('3324', '3323' )

            //	Update [GUIDE].[dbo].[SETTLEMENT_INF]
            //	Set STATUS = 'S', AUTHORIZE_BY = 'UA003086', AUTHORIZE_ON=getdate(), ADD_ON = getdate()
            //	where SIF_ID  in ('3322', '3321' )

            //	Update [GUIDE].[dbo].[SETTLEMENT_INF]
            //	Set STATUS = 'S', AUTHORIZE_BY = 'MM003292', AUTHORIZE_ON=getdate(), ADD_ON = getdate()
            //	where SIF_ID  in ('3320', '3319' )

            //	Update [GUIDE].[dbo].[SETTLEMENT_INF]
            //	Set STATUS = 'S', AUTHORIZE_BY = 'BL007010', AUTHORIZE_ON=getdate(), ADD_ON = getdate()
            //	where SIF_ID  in ('3318', '3317' )

            //	SELECT TOP (100) *
            //	FROM [GUIDE].[dbo].[SETTLEMENT_INF]
            //	where STATUS not in ('F', 'A', 'V' )
            //	order by [ADD_ON] desc

            //--Commit tran
            //--rollback tran

            //using GUIDEDbContext appDbContext  = new();
            string[] validStatus = { "F", "A", "V" };

            var entry = (from s in appDbContext.SettlementInfs
                         join f in appDbContext.Fxfswifts on s.SifId equals f.SifId into fullFxfSwifts
                         from s1 in fullFxfSwifts.DefaultIfEmpty()
                         join y in appDbContext.Fxfccies on s1.CcyCd equals y.CcyCd into fullFxfSwiftsCcy
                         from y1 in fullFxfSwiftsCcy.DefaultIfEmpty()
                         where !validStatus.Contains(s.Status)
                         select new SettlementInfView()
                         {
                             SIF_ID = s.SifId,
                             CUST_ABBR = s.CustAbbr,
                             RECORD_KIND =
                                        (
                                            s.RecordKind == "0" ? "FX" :
                                            s.RecordKind == "2" ? "MM" :
                                            s.RecordKind == "6" ? "Swap" : "Unknown"
                                        ),
                             CCY = y1.Ccy,
                             STATUS = s.Status,
                             AUTHORIZE_BY = s.AuthorizeBy,
                             DELETION_STATUS = s.DeletionStatus,
                             TRAN_NO = s.TranNo,
                             GIP_STATUS = s.GipStatus,
                             GIP_DESCRIPTION = s.GipDescription,

                             Addresse = s1.Addresse ?? String.Empty,
                             PartyIdentifier56 = s1.PartyIdentifier56 ?? String.Empty,
                             BIC56_1 = s1.Bic561 ?? String.Empty,
                             PartyIdentifier57 = s1.PartyIdentifier57 ?? String.Empty,
                             FXALM_PartyIdentifier57 = s1.FxalmPartyIdentifier57 ?? String.Empty,
                             BIC57_1 = s1.Bic571 ?? String.Empty,
                             BIC57_2 = s1.Bic572 ?? String.Empty,
                             BIC57_3 = s1.Bic573 ?? String.Empty,
                             BIC57_4 = s1.Bic574 ?? String.Empty,
                             PartyIdentifier58 = s1.PartyIdentifier58 ?? String.Empty,
                             FXALM_PartyIdentifier58 = s1.FxalmPartyIdentifier58 ?? String.Empty,
                             BIC58_1 = s1.Bic581 ?? String.Empty,
                             PartyIdentifier59 = s1.PartyIdentifier59 ?? String.Empty,
                             BIC59_1 = s1.Bic591 ?? String.Empty,
                             BIC59_2 = s1.Bic592 ?? String.Empty,
                             BIC59_3 = s1.Bic593 ?? String.Empty,
                             BIC59_4 = s1.Bic594 ?? String.Empty,
                             SpecialInstruction_1 = s1.SpecialInstruction1 ?? String.Empty,
                             SpecialInstruction_2 = s1.SpecialInstruction2 ?? String.Empty,
                             SpecialInstruction_3 = s1.SpecialInstruction3 ?? String.Empty,
                             SpecialInstruction_4 = s1.SpecialInstruction4 ?? String.Empty,
                         })
                           .ToList();
            return entry;
        }


        public IEnumerable<SettlementInfView> GetSettlementInfBySifId(int id)
		{
            //using GUIDEDbContext appDbContext  = new();

            var entry = (from s in appDbContext.SettlementInfs
                         join f in appDbContext.Fxfswifts on s.SifId equals f.SifId into fullFxfSwifts
                         from s1 in fullFxfSwifts.DefaultIfEmpty()
                         join y in appDbContext.Fxfccies on s1.CcyCd equals y.CcyCd into fullFxfSwiftsCcy
                         from y1 in fullFxfSwiftsCcy.DefaultIfEmpty()
                         where s.SifId == id
                         select new SettlementInfView()
                         {
                             SIF_ID = s.SifId,
                             CUST_ABBR = s.CustAbbr,
                             RECORD_KIND =
                                        (
                                            s.RecordKind == "0" ? "FX" :
                                            s.RecordKind == "2" ? "MM" :
                                            s.RecordKind == "6" ? "Swap" : "Unknown"
                                        ),
                             CCY = y1.Ccy,
                             STATUS = s.Status,
                             DELETION_STATUS = s.DeletionStatus,
                             TRAN_NO = s.TranNo,
                             GIP_STATUS = s.GipStatus,
                             GIP_DESCRIPTION = s.GipDescription,
                             AUTHORIZE_BY = s.AuthorizeBy,

                             Addresse = s1.Addresse ?? String.Empty,
                             PartyIdentifier56 = s1.PartyIdentifier56 ?? String.Empty,
                             BIC56_1 = s1.Bic561 ?? String.Empty,
                             PartyIdentifier57 = s1.PartyIdentifier57 ?? String.Empty,
                             FXALM_PartyIdentifier57 = s1.FxalmPartyIdentifier57 ?? String.Empty,
                             BIC57_1 = s1.Bic571 ?? String.Empty,
                             BIC57_2 = s1.Bic572 ?? String.Empty,
                             BIC57_3 = s1.Bic573 ?? String.Empty,
                             BIC57_4 = s1.Bic574 ?? String.Empty,
                             PartyIdentifier58 = s1.PartyIdentifier58 ?? String.Empty,
                             FXALM_PartyIdentifier58 = s1.FxalmPartyIdentifier58 ?? String.Empty,
                             BIC58_1 = s1.Bic581 ?? String.Empty,
                             PartyIdentifier59 = s1.PartyIdentifier59 ?? String.Empty,
                             BIC59_1 = s1.Bic591 ?? String.Empty,
                             BIC59_2 = s1.Bic592 ?? String.Empty,
                             BIC59_3 = s1.Bic593 ?? String.Empty,
                             BIC59_4 = s1.Bic594 ?? String.Empty,
                             SpecialInstruction_1 = s1.SpecialInstruction1 ?? String.Empty,
                             SpecialInstruction_2 = s1.SpecialInstruction2 ?? String.Empty,
                             SpecialInstruction_3 = s1.SpecialInstruction3 ?? String.Empty,
                             SpecialInstruction_4 = s1.SpecialInstruction4 ?? String.Empty,
                         })
                         .ToList();


            
            return entry;
        }

		public IEnumerable<SettlementInfView> GetSettlementInfByCustAbbr(string custAbbr)
		{
            //using GUIDEDbContext appDbContext  = new();
            var entry = (from s in appDbContext.SettlementInfs
                         join f in appDbContext.Fxfswifts on s.SifId equals f.SifId into fullFxfSwifts
                         from s1 in fullFxfSwifts.DefaultIfEmpty()
                         join y in appDbContext.Fxfccies on s1.CcyCd equals y.CcyCd into fullFxfSwiftsCcy
                         from y1 in fullFxfSwiftsCcy.DefaultIfEmpty()
                         where s.CustAbbr.Contains(custAbbr)
                         select new SettlementInfView()
                         {
                             SIF_ID = s.SifId,
                             CUST_ABBR = s.CustAbbr,
                             RECORD_KIND =
                                        (
                                            s.RecordKind == "0" ? "FX" :
                                            s.RecordKind == "2" ? "MM" :
                                            s.RecordKind == "6" ? "Swap" : "Unknown"
                                        ),
                             CCY = y1.Ccy,
                             STATUS = s.Status,
                             DELETION_STATUS = s.DeletionStatus,
                             TRAN_NO = s.TranNo,
                             GIP_STATUS = s.GipStatus,
                             GIP_DESCRIPTION = s.GipDescription,
                             AUTHORIZE_BY = s.AuthorizeBy,

                             Addresse = s1.Addresse ?? String.Empty,
                             PartyIdentifier56 = s1.PartyIdentifier56 ?? String.Empty,
                             BIC56_1 = s1.Bic561 ?? String.Empty,
                             PartyIdentifier57 = s1.PartyIdentifier57 ?? String.Empty,
                             FXALM_PartyIdentifier57 = s1.FxalmPartyIdentifier57 ?? String.Empty,
                             BIC57_1 = s1.Bic571 ?? String.Empty,
                             BIC57_2 = s1.Bic572 ?? String.Empty,
                             BIC57_3 = s1.Bic573 ?? String.Empty,
                             BIC57_4 = s1.Bic574 ?? String.Empty,
                             PartyIdentifier58 = s1.PartyIdentifier58 ?? String.Empty,
                             FXALM_PartyIdentifier58 = s1.FxalmPartyIdentifier58 ?? String.Empty,
                             BIC58_1 = s1.Bic581 ?? String.Empty,
                             PartyIdentifier59 = s1.PartyIdentifier59 ?? String.Empty,
                             BIC59_1 = s1.Bic591 ?? String.Empty,
                             BIC59_2 = s1.Bic592 ?? String.Empty,
                             BIC59_3 = s1.Bic593 ?? String.Empty,
                             BIC59_4 = s1.Bic594 ?? String.Empty,
                             SpecialInstruction_1 = s1.SpecialInstruction1 ?? String.Empty,
                             SpecialInstruction_2 = s1.SpecialInstruction2 ?? String.Empty,
                             SpecialInstruction_3 = s1.SpecialInstruction3 ?? String.Empty,
                             SpecialInstruction_4 = s1.SpecialInstruction4 ?? String.Empty,
                         })
                           .ToList();
            return entry;
        }

		public IEnumerable<SettlementInfView> GetSettlementInfByDetails(string custAbbr, string ccyCD, string recordKind)
		{
            //using GUIDEDbContext appDbContext  = new();
            var entry = (from s in appDbContext.SettlementInfs
                         join f in appDbContext.Fxfswifts on s.SifId equals f.SifId into fullFxfSwifts
                         from s1 in fullFxfSwifts.DefaultIfEmpty()
                         join y in appDbContext.Fxfccies on s1.CcyCd equals y.CcyCd  into fullFxfSwiftsCcy
                         from y1 in fullFxfSwiftsCcy.DefaultIfEmpty()
                         where s.CustAbbr.Contains(custAbbr)
                                && s.CcyCd == ccyCD
                                && s.RecordKind == recordKind
                         select new SettlementInfView()
                         {
                             SIF_ID = s.SifId,
                             CUST_ABBR = s.CustAbbr,
                             RECORD_KIND =
                                        (
                                            s.RecordKind == "0" ? "FX" :
                                            s.RecordKind == "2" ? "MM" :
                                            s.RecordKind == "6" ? "Swap" : "Unknown"
                                        ),
                             CCY = y1.Ccy,
                             STATUS = s.Status,
                             DELETION_STATUS = s.DeletionStatus,
                             TRAN_NO = s.TranNo,
                             GIP_STATUS = s.GipStatus,
                             GIP_DESCRIPTION = s.GipDescription,
                             AUTHORIZE_BY = s.AuthorizeBy,

                             Addresse = s1.Addresse ?? String.Empty,
                             PartyIdentifier56 = s1.PartyIdentifier56 ?? String.Empty,
                             BIC56_1 = s1.Bic561 ?? String.Empty,
                             PartyIdentifier57 = s1.PartyIdentifier57 ?? String.Empty,
                             FXALM_PartyIdentifier57 = s1.FxalmPartyIdentifier57 ?? String.Empty,
                             BIC57_1 = s1.Bic571 ?? String.Empty,
                             BIC57_2 = s1.Bic572 ?? String.Empty,
                             BIC57_3 = s1.Bic573 ?? String.Empty,
                             BIC57_4 = s1.Bic574 ?? String.Empty,
                             PartyIdentifier58 = s1.PartyIdentifier58 ?? String.Empty,
                             FXALM_PartyIdentifier58 = s1.FxalmPartyIdentifier58 ?? String.Empty,
                             BIC58_1 = s1.Bic581 ?? String.Empty,
                             PartyIdentifier59 = s1.PartyIdentifier59 ?? String.Empty,
                             BIC59_1 = s1.Bic591 ?? String.Empty,
                             BIC59_2 = s1.Bic592 ?? String.Empty,
                             BIC59_3 = s1.Bic593 ?? String.Empty,
                             BIC59_4 = s1.Bic594 ?? String.Empty,
                             SpecialInstruction_1 = s1.SpecialInstruction1 ?? String.Empty,
                             SpecialInstruction_2 = s1.SpecialInstruction2 ?? String.Empty,
                             SpecialInstruction_3 = s1.SpecialInstruction3 ?? String.Empty,
                             SpecialInstruction_4 = s1.SpecialInstruction4 ?? String.Empty,
                         })
                           .ToList();
            return entry;
        }

		public IEnumerable<SettlementInf> GetSettlementInfsByStatus(string status = "All")
		{
            //using GUIDEDbContext appDbContext  = new();
            List<SettlementInf> entry;

            switch (status)
            {
                case "All":
                    entry = appDbContext.SettlementInfs.ToList();
                    break;
                case "F":
                    entry = appDbContext.SettlementInfs.Where(e => e.Status == "F" && e.DeletionStatus == "").ToList();
                    break;
                case "A":
                    entry = appDbContext.SettlementInfs.Where(e => e.Status == "A" && e.DeletionStatus == "").ToList();
                    break;
                case "V":
                    entry = appDbContext.SettlementInfs.Where(e => e.Status == "V" && e.DeletionStatus == "").ToList();
                    break;
                case "S":
                    entry = appDbContext.SettlementInfs.Where(e => e.Status == "S" && e.DeletionStatus == "").ToList();
                    break;
                case "SD":
                    entry = appDbContext.SettlementInfs.Where(e => e.Status == "S" && e.DeletionStatus == "D").ToList();
                    break;
                case "D":
                    entry = appDbContext.SettlementInfs.Where(e => e.Status == "F" && e.DeletionStatus == "D").ToList();
                    break;
                default:
                    //break;
                    return null;
            }
            return entry;
        }

        public IEnumerable<SettlementInfView> GetSifInstructionsByStatus(string status = "F")
        {
            //using GUIDEDbContext appDbContext  = new();
            //string[] validStatus = { "F", "A", "V" };

            var entry = (from s in appDbContext.SettlementInfs
                         join f in appDbContext.Fxfswifts on s.SifId equals f.SifId into fullFxfSwifts
                         from s1 in fullFxfSwifts.DefaultIfEmpty()
                         join y in appDbContext.Fxfccies on s1.CcyCd equals y.CcyCd into fullFxfSwiftsCcy
                         from y1 in fullFxfSwiftsCcy.DefaultIfEmpty()
                         where s.Status == status
                         select new SettlementInfView()
                         {
                             SIF_ID = s.SifId,
                             CUST_ABBR = s.CustAbbr,
                             RECORD_KIND =
                                        (
                                            s.RecordKind == "0" ? "FX" :
                                            s.RecordKind == "2" ? "MM" :
                                            s.RecordKind == "6" ? "Swap" : "Unknown"
                                        ),
                             CCY = y1.Ccy,

                             REC_SETTL_CODE = s.RecSettlCode,
                             REC_ACT_CD = s.RecActCd,
                             REC_METHOD = s.RecMethod,
                             PAY_SETTL_CODE = s.PaySettlCode,
                             PAY_ACT_CD = s.PayActCd,
                             PAY_METHOD = s.PayMethod,
                             REC_BANK_ID = s.RecBankId,
                             REC_CUST_ABBR = s.RecCustAbbr,
                             INTERMEDIARY_BANK_ID = s.IntermediaryBankId,
                             ACC_BANK_ID = s.AccBankId,
                             ACC_BANK_ACTNO = s.AccBankActno,
                             BENE_BANK_ID = s.BeneBankActno,
                             BENE_BANK_ACTNO = s.BeneBankActno,
                             CONFIRMATION_SWIFT_ID = s.ConfirmationSwiftId,
                             CONFIRMATION_FLG = s.ConfirmationFlg,
                             REC_BANK_BR_ACTNO = s.RecBankBrActno,
                             REC_BANK_HO_ACTNO = s.RecBankHoActno,
                             BANK_INF = s.BankInf,

                             STATUS = s.Status,
                             AUTHORIZE_BY = s.AuthorizeBy,
                             DELETION_STATUS = s.DeletionStatus,
                             TRAN_NO = s.TranNo,
                             GIP_STATUS = s.GipStatus,
                             GIP_DESCRIPTION = s.GipDescription,

                             Addresse = s1.Addresse ?? String.Empty,
                             PartyIdentifier56 = s1.PartyIdentifier56 ?? String.Empty,
                             BIC56_1 = s1.Bic561 ?? String.Empty,
                             PartyIdentifier57 = s1.PartyIdentifier57 ?? String.Empty,
                             FXALM_PartyIdentifier57 = s1.FxalmPartyIdentifier57 ?? String.Empty,
                             BIC57_1 = s1.Bic571 ?? String.Empty,
                             BIC57_2 = s1.Bic572 ?? String.Empty,
                             BIC57_3 = s1.Bic573 ?? String.Empty,
                             BIC57_4 = s1.Bic574 ?? String.Empty,
                             PartyIdentifier58 = s1.PartyIdentifier58 ?? String.Empty,
                             FXALM_PartyIdentifier58 = s1.FxalmPartyIdentifier58 ?? String.Empty,
                             BIC58_1 = s1.Bic581 ?? String.Empty,
                             PartyIdentifier59 = s1.PartyIdentifier59 ?? String.Empty,
                             BIC59_1 = s1.Bic591 ?? String.Empty,
                             BIC59_2 = s1.Bic592 ?? String.Empty,
                             BIC59_3 = s1.Bic593 ?? String.Empty,
                             BIC59_4 = s1.Bic594 ?? String.Empty,
                             SpecialInstruction_1 = s1.SpecialInstruction1 ?? String.Empty,
                             SpecialInstruction_2 = s1.SpecialInstruction2 ?? String.Empty,
                             SpecialInstruction_3 = s1.SpecialInstruction3 ?? String.Empty,
                             SpecialInstruction_4 = s1.SpecialInstruction4 ?? String.Empty,
                         })
                           .ToList();
            return entry;
        }

        //public string InsertSettlementInf(SETTLEMENT_INF settlement_inf)
        //{
        //	try
        //	{
        //		using (GUIDEDbContext appDbContext  = new())
        //		{
        //			appDbContext.SettlementInfs.Add(settlement_inf);
        //			appDbContext.SaveChanges();

        //			return settlement_inf.SIF_ID.ToString();
        //		}
        //	}
        //	catch (Exception ex)
        //	{
        //		// HTTP/1.1 400 Not found  
        //		return ex.ToString();
        //	}
        //}

        public string DeleteSettlementInf(int id)
		{
			try
			{
                //using GUIDEDbContext appDbContext  = new();
                var entity = appDbContext.SettlementInfs.FirstOrDefault(e => e.SifId == id);

                if (entity != null)
                {
                    appDbContext.SettlementInfs.Remove(entity);
                    appDbContext.SaveChanges();
                    return "OK";
                }
                else
                {
                    return "not found";
                }
            }
			catch (Exception ex)
			{
				return ex.ToString();
			}
		}

		public string UpdateStatus(SIFStatus status)
		{
			try
			{
				string[] validStatus = { "F", "A", "V" };

                //using GUIDEDbContext appDbContext  = new();
                var entry = appDbContext.SettlementInfs
                           .Where(e => e.SifId == status.SifId
                               && (e.AuthorizeBy == status.AuthorizeBy || e.AuthorizeBy.ToUpper() == "SYSTEM")
                               && !validStatus.Contains(e.Status))
                           .FirstOrDefault();
                // .FirstOrDefault(e => e.SIF_ID == status.SIF_ID); 

                if (entry != null)
                {
                    var delstatus = entry.DeletionStatus.ToString();
                    var guideStatus = entry.Status.ToString();

                    AuditLog auditLog = new()
                    {
                        UserId = status.AuthorizeBy,
                        AuditDate = DateTime.Now,
                        RefNo = status.SifId.ToString(),
                        TransNo = status.TranNo ?? "99999",
                        AuditDesc = "Sent SIF to Finalized",
                        AppName = "GUIDE",
                        TableName = "Settlement Information",
                        OriginalValue = guideStatus + " : " + delstatus,
                        NewValue = status.Status + " : " + status.DeletionStatus,
                    };

                    entry.AuthorizeBy = status.AuthorizeBy;
                    entry.Status = status.Status;
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

        string ISettlementInf.InsertSettlementInf(SettlementInf settlement_inf)
        {
            throw new NotImplementedException();
        }

        

    }
}
