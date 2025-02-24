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
    public class GASRepository : IGAS
    {
        private readonly GUIDEDbContext appDbContext;
        public GASRepository(GUIDEDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<GASDebitView> GetGASTransByDate(string optDate)
        {
            //using GUIDEDbContext appDbContext = new();
            DateTime date = DateTime.Parse(optDate);

            // not working due to reference object 
            //var entry1 = appDbContext.GasGoDebits
            //                    .Where(e => DbFunctions.TruncateTime(e.VALUEDATE_DT) == DbFunctions.TruncateTime(date))
            //                    .OrderBy(e => e.MIN_NO)
            //                    //.Take(50)                             
            //                    .ToList();

            var entry = (from g in appDbContext.GasGoDebits
                         where EF.Functions.DateDiffDay(g.ValuedateDt,date)==0
                         orderby g.MinNo
                         select new GASDebitView()
                         {
                             MIN_NO = g.MinNo,
                             VALUEDATE_DT = (DateTime) g.ValuedateDt,
                             STATUS_INT = g.StatusInt,
                             DREAMS_REF_CODE = g.DreamsRefCode,
                             REMARKS_TX = g.RemarksTx,
                             CCY_TX = g.CcyTx,
                             AMOUNT_AMT = g.AmountAmt?? 0,
                             CUSTID_TX = g.CustidTx,
                             ACC_CD_TX = g.AccCdTx,
                             ACCNUM_TX = g.AccnumTx,
                             DESCRIPTION_TX = g.DescriptionTx,
                             CREATED_BY = g.CreatedBy,
                             CREATED_DATE = (DateTime)g.CreatedDate,
                             UPLOADED_BY = g.UploadedBy,
                             UPLOADED_DATE = (DateTime)g.UploadedDate,
                             TRANSNO_TX = g.TransnoTx
                         })
                        .ToList();

            return entry;
        }


        public string UpdateDCSStatus(InputGAS status)
        {
            try
            {
                //using GUIDEDbContext appDbContext = new();
                string gBaseRefNo;
                string preGASStatus;
                string prePosingStatus;
                string prePaymentStatus;
                int LastGOPostingId;
                int PaymentId;

                //DateTime valueDate = DateTime.Parse(status.valueDate);

                // check GAS Debit
                var GAS_GO_Debit = appDbContext.GasGoDebits
                            .Where(e => e.MinNo.ToLower() == status.MinNo.ToLower()
                                && EF.Functions.DateDiffDay(e.ValuedateDt, status.valueDate) ==0)
                            .FirstOrDefault();


                // Get the last unsuccessfull GoPosting ID by GBase RefNo
                if (GAS_GO_Debit != null)
                {
                    gBaseRefNo = GAS_GO_Debit.DreamsRefCode;
                    preGASStatus = GAS_GO_Debit.StatusInt.ToString();

                    //check DomesticClearing_Goposting with ref_no and pending status
                    var DC_GoPosting = appDbContext.DomesticClearingGopostings
                                    .Where(e => e.GbaseRefNo.ToLower() == gBaseRefNo
                                                && e.GasDescription.ToLower() != "Approved".ToLower()
                                                && e.StatusId != 9
                                           )
                                    .OrderByDescending(x => x.GopostingId)
                                    .FirstOrDefault();

                    // Get GAS Payment record by GoPosting ID
                    if (DC_GoPosting != null)
                    {
                        LastGOPostingId = DC_GoPosting.GopostingId;
                        prePosingStatus = DC_GoPosting.StatusId.ToString();

                        //find the last DC_Payment record with the Last GOPosting Id
                        var DC_Payment = appDbContext.DomesticClearingPayments
                                        .Where(e => e.MainPostId == LastGOPostingId)
                                        .OrderByDescending(x => x.MainPostId)
                                        .FirstOrDefault();

                        if (DC_Payment != null)
                        {
                            PaymentId = DC_Payment.PaymentId;
                            prePaymentStatus = DC_Payment.StatusId.ToString();

                            //**************************************************************
                            //1. Set DomesticClearing_Goposting to beginning status "1"
                            //**************************************************************
                            var updateGASPosting = appDbContext.DomesticClearingGopostings
                                                    .Where(e => e.GopostingId == LastGOPostingId)
                                                    .FirstOrDefault();                         
                            updateGASPosting.StatusId = 1;


                            //**************************************************************
                            //2. Set GAS debit to Delete of approval
                            //**************************************************************
                            var updateGASDebit = appDbContext.GasGoDebits
                                                .Where(e => e.MinNo == status.MinNo)
                                                .FirstOrDefault();

                            updateGASDebit.StatusInt = status.StatusId; // 10;
                            updateGASDebit.DescriptionTx = "Approved";
                            

                            AuditLog auditLog1 = new()
                            {
                                UserId = status.AuthorizeBy,
                                AuditDate = DateTime.Now,
                                RefNo = status.MinNo,
                                TransNo = PaymentId.ToString(),

                                AuditDesc = "Reset DomesticClearing_GOPosting",
                                AppName = "GUIDE",
                                TableName = "DomesticClearing_GOPosting",
                                OriginalValue = prePosingStatus,
                                NewValue = "1",
                            };
                            appDbContext.AuditLogs.Add(auditLog1);
                            //AuditLogRepository.InsertAuditLog(auditLog1);

                            AuditLog auditLog2 = new()
                            {
                                UserId = status.AuthorizeBy,
                                AuditDate = DateTime.Now,
                                RefNo = status.MinNo,
                                TransNo = status.MinNo,

                                AuditDesc = "Reset GAS Transaction",
                                AppName = "GUIDE",
                                TableName = "GAS_GO_DEBIT",
                                OriginalValue = preGASStatus,
                                NewValue = status.StatusId.ToString(),  //"10",
                            };
                            appDbContext.AuditLogs.Add(auditLog2);
                            //AuditLogRepository.InsertAuditLog(auditLog2);

                            appDbContext.SaveChanges();
                            return "OK";
                        }
                        else
                        {
                            return "NotFound";
                        }
                    }
                    else
                    {
                        return "NotFound";
                    }
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


        public string UpdateGASStatus(InputGAS status)
        {
            try
            {
                //using GUIDEDbContext appDbContext = new();
                string gBeRefNo;
                string preGASStatus;
                //DateTime valueDate = DateTime.Parse(status.valueDate);

                var GAS_Debit = appDbContext.GasGoDebits
                            .Where(e => e.MinNo.ToLower() == status.MinNo.ToLower()
                                && EF.Functions.DateDiffDay(e.ValuedateDt, status.valueDate) ==0)
                            .FirstOrDefault();

                if (GAS_Debit != null)
                {
                    gBeRefNo = GAS_Debit.DreamsRefCode;
                    preGASStatus = GAS_Debit.StatusInt.ToString();

                    GAS_Debit.DescriptionTx = "Approved";
                    GAS_Debit.StatusInt = status.StatusId;  //8;

                    AuditLog auditLog = new()
                    {
                        UserId = status.AuthorizeBy,
                        AuditDate = DateTime.Now,
                        RefNo = status.MinNo,
                        TransNo = status.MinNo,

                        AuditDesc = "Set GAS Transaction",
                        AppName = "GUIDE",
                        TableName = "GAS_GO_DEBIT",
                        OriginalValue = preGASStatus,
                        NewValue = status.StatusId.ToString(),
                    };

                    //AuditLogRepository.InsertAuditLog(auditLog);
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
