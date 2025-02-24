using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("MASS_TRANSACTION_HISTORY", Schema = "dbo")]
    public partial class MassTransactionHistory
    {
        [Column("TRAN_ID", TypeName = "decimal(10, 0)")]
        public decimal TranId { get; set; }
        [Column("BATCH_REF_NO", TypeName = "decimal(8, 0)")]
        public decimal BatchRefNo { get; set; }
        [Column("APPROVED_DATE", TypeName = "datetime")]
        public DateTime ApprovedDate { get; set; }
        [Required]
        [Column("APPROVED_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string ApprovedBy { get; set; }
        [Required]
        [Column("MODULE_ID")]
        [StringLength(15)]
        [Unicode(false)]
        public string ModuleId { get; set; }
        [Required]
        [Column("ACU_BU_IND")]
        [StringLength(1)]
        [Unicode(false)]
        public string AcuBuInd { get; set; }
        [Required]
        [Column("TRAN_NUMBER")]
        [StringLength(5)]
        [Unicode(false)]
        public string TranNumber { get; set; }
        [Column("GBASE_REF_CODE")]
        [StringLength(14)]
        [Unicode(false)]
        public string GbaseRefCode { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string Status { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(30)]
        [Unicode(false)]
        public string Description { get; set; }
        [Column("OPERATION_MODE")]
        [StringLength(1)]
        [Unicode(false)]
        public string OperationMode { get; set; }
        [Column("REAPPROVED_OVERRIDE_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string ReapprovedOverrideBy { get; set; }
        [Column("REAPPROVED_OVERRIDE_DATE", TypeName = "datetime")]
        public DateTime? ReapprovedOverrideDate { get; set; }
        [Column("MIN_NO")]
        [StringLength(50)]
        [Unicode(false)]
        public string MinNo { get; set; }
    }
}
