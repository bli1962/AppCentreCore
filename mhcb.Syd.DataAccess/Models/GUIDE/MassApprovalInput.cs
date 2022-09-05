using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MASS_APPROVAL_INPUT")]
    public partial class MassApprovalInput
    {
        [Key]
        [Column("IDENTIFIER", TypeName = "decimal(10, 0)")]
        public decimal Identifier { get; set; }
        [Required]
        [Column("ACU_BU_IND")]
        [StringLength(1)]
        public string AcuBuInd { get; set; }
        [Required]
        [Column("START_TRAN_NUMBER")]
        [StringLength(5)]
        public string StartTranNumber { get; set; }
        [Required]
        [Column("END_TRAN_NUMBER")]
        [StringLength(5)]
        public string EndTranNumber { get; set; }
        [Required]
        [Column("APPROVED_BY")]
        [StringLength(8)]
        public string ApprovedBy { get; set; }
        [Column("APPROVED_DATE", TypeName = "datetime")]
        public DateTime ApprovedDate { get; set; }
        [Required]
        [Column("SECTION_CODE")]
        [StringLength(2)]
        public string SectionCode { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
    }
}
