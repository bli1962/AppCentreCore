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
                             VALUEDATE_DT = g.ValuedateDt,
                             STATUS_INT = g.StatusInt,
                             DREAMS_REF_CODE = g.DreamsRefCode,
                             REMARKS_TX = g.RemarksTx,
                             CCY_TX = g.CcyTx,
                             AMOUNT_AMT = g.AmountAmt,
                             CUSTID_TX = g.CustidTx,
                             ACC_CD_TX = g.AccCdTx,
                             ACCNUM_TX = g.AccnumTx,
                             DESCRIPTION_TX = g.DescriptionTx,
                             CREATED_BY = g.CreatedBy,
                             CREATED_DATE = g.CreatedDate,
                             UPLOADED_BY = g.UploadedBy,
                             UPLOADED_DATE = g.UploadedDate,
                             TRANSNO_TX = g.TransnoTx
                         })
                        .ToList();

            return entry;
        }


        public string UpdateDCSStatus(GASAttribute status)
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
                var GAS_Debit = appDbContext.GasGoDebits
                            .Where(e => e.MinNo.ToLower() == status.MinNo.ToLower()
                                && EF.Functions.DateDiffDay(e.ValuedateDt, status.valueDate) ==0)
                            .FirstOrDefault();

                if (GAS_Debit != null)
                {
                    gBaseRefNo = GAS_Debit.DreamsRefCode;
                    preGASStatus = GAS_Debit.StatusInt.ToString();

                    //check DomesticClearing_Goposting with ref_no and pending status
                    var GASPosting = appDbContext.DomesticClearingGopostings
                                    .Where(e => e.GbaseRefNo.ToLower() == gBaseRefNo
                                                && e.GasDescription.ToLower() != "Approved".ToLower()
                                                && e.StatusId != 9
                                           )
                                    .OrderByDescending(x => x.GopostingId)
                                    .FirstOrDefault();

                    //check DomesticClearing_Payment with the last PostID
                    if (GASPosting != null)
                    {
                        LastGOPostingId = GASPosting.GopostingId;
                        prePosingStatus = GASPosting.StatusId.ToString();

                        //find the payment record with id
                        var GASPayment = appDbContext.DomesticClearingPayments
                                        .Where(e => e.MainPostId == LastGOPostingId)
                                        .OrderByDescending(x => x.MainPostId)
                                        .FirstOrDefault();

                        if (GASPayment != null)
                        {
                            PaymentId = GASPayment.PaymentId;
                            prePaymentStatus = GASPayment.StatusId.ToString();

                            //**************************************************************
                            //1. set DomesticClearing_Goposting to beginning status
                            var updateGASPosting = appDbContext.DomesticClearingGopostings
                                                    .Where(e => e.GopostingId == LastGOPostingId)
                                                    .FirstOrDefault();                         
                            updateGASPosting.StatusId = 1;
                            //**************************************************************

                            //**************************************************************
                            //2. Set GAS debit to delete
                            var updateGASDebit = appDbContext.GasGoDebits
                                                .Where(e => e.MinNo == status.MinNo)
                                                .FirstOrDefault();
                            updateGASDebit.StatusInt = status.StatusId; // 10;
                            updateGASDebit.DescriptionTx = "Approved";
                            //**************************************************************

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


        public string UpdateGASStatus(GASAttribute status)
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
