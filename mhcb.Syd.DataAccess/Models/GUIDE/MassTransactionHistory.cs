using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("MASS_TRANSACTION_HISTORY")]
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
        public string ApprovedBy { get; set; }
        [Required]
        [Column("MODULE_ID")]
        [StringLength(15)]
        public string ModuleId { get; set; }
        [Required]
        [Column("ACU_BU_IND")]
        [StringLength(1)]
        public string AcuBuInd { get; set; }
        [Required]
        [Column("TRAN_NUMBER")]
        [StringLength(5)]
        public string TranNumber { get; set; }
        [Column("GBASE_REF_CODE")]
        [StringLength(14)]
        public string GbaseRefCode { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(30)]
        public string Description { get; set; }
        [Column("OPERATION_MODE")]
        [StringLength(1)]
        public string OperationMode { get; set; }
        [Column("REAPPROVED_OVERRIDE_BY")]
        [StringLength(8)]
        public string ReapprovedOverrideBy { get; set; }
        [Column("REAPPROVED_OVERRIDE_DATE", TypeName = "datetime")]
        public DateTime? ReapprovedOverrideDate { get; set; }
        [Column("MIN_NO")]
        [StringLength(50)]
        public string MinNo { get; set; }
    }
}
