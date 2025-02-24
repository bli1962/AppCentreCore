using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("USR_GBASE_SPL_TRANSACTION", Schema = "dbo")]
    public partial class UsrGbaseSplTransaction
    {
        [Key]
        [Column("USER_ID")]
        [StringLength(8)]
        [Unicode(false)]
        public string UserId { get; set; }
        [Column("SYSTEM")]
        [StringLength(1)]
        [Unicode(false)]
        public string System { get; set; }
        [Column("PERSONNEL")]
        [StringLength(1)]
        [Unicode(false)]
        public string Personnel { get; set; }
        [Column("APPROVAL_OF_LOAN")]
        [StringLength(1)]
        [Unicode(false)]
        public string ApprovalOfLoan { get; set; }
        [Column("EDP_MANAGER")]
        [StringLength(1)]
        [Unicode(false)]
        public string EdpManager { get; set; }
        [Column("APPROVAL_OF_CORRECTION")]
        [StringLength(1)]
        [Unicode(false)]
        public string ApprovalOfCorrection { get; set; }
        [Column("ACCOUNT_SETTLEMENT")]
        [StringLength(1)]
        [Unicode(false)]
        public string AccountSettlement { get; set; }
        [Column("NON_ONLINE_ACC")]
        [StringLength(1)]
        [Unicode(false)]
        public string NonOnlineAcc { get; set; }
        [Column("APPROVAL_OF_REMITTANCE")]
        [StringLength(1)]
        [Unicode(false)]
        public string ApprovalOfRemittance { get; set; }
        [Column("WARNING_CD_OVERRD")]
        [StringLength(1)]
        [Unicode(false)]
        public string WarningCdOverrd { get; set; }
        [Column("APPROVAL_WARN_CD")]
        [StringLength(1)]
        [Unicode(false)]
        public string ApprovalWarnCd { get; set; }
        [Column("APPROVAL_OF_TMPOD")]
        [StringLength(1)]
        [Unicode(false)]
        public string ApprovalOfTmpod { get; set; }
        [Column("APPROVAL_LDGR_MOD")]
        [StringLength(1)]
        [Unicode(false)]
        public string ApprovalLdgrMod { get; set; }
        [Column("TRANSMIT_OF_OUT")]
        [StringLength(1)]
        [Unicode(false)]
        public string TransmitOfOut { get; set; }
        [Column("TAKE_IN_POSTING")]
        [StringLength(1)]
        [Unicode(false)]
        public string TakeInPosting { get; set; }
        [Column("UPDATE_OF_MESSAGE")]
        [StringLength(1)]
        [Unicode(false)]
        public string UpdateOfMessage { get; set; }
        [Column("REVERSAL_OF_OP")]
        [StringLength(1)]
        [Unicode(false)]
        public string ReversalOfOp { get; set; }
        [Column("PROFIT_MANAGEMENT")]
        [StringLength(1)]
        [Unicode(false)]
        public string ProfitManagement { get; set; }
        [Column("SYNTH_LIMIT_CONT")]
        [StringLength(1)]
        [Unicode(false)]
        public string SynthLimitCont { get; set; }
        [Column("APPROVAL_OF_OD")]
        [StringLength(1)]
        [Unicode(false)]
        public string ApprovalOfOd { get; set; }
        [Column("FWD_VALUE_REMITTANCE")]
        [StringLength(1)]
        [Unicode(false)]
        public string FwdValueRemittance { get; set; }
    }
}
