using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MASS_APPROVAL_INPUT", Schema = "dbo")]
    public partial class MassApprovalInput
    {
        [Key]
        [Column("IDENTIFIER", TypeName = "decimal(10, 0)")]
        public decimal Identifier { get; set; }
        [Required]
        [Column("ACU_BU_IND")]
        [StringLength(1)]
        [Unicode(false)]
        public string AcuBuInd { get; set; }
        [Required]
        [Column("START_TRAN_NUMBER")]
        [StringLength(5)]
        [Unicode(false)]
        public string StartTranNumber { get; set; }
        [Required]
        [Column("END_TRAN_NUMBER")]
        [StringLength(5)]
        [Unicode(false)]
        public string EndTranNumber { get; set; }
        [Required]
        [Column("APPROVED_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string ApprovedBy { get; set; }
        [Column("APPROVED_DATE", TypeName = "datetime")]
        public DateTime ApprovedDate { get; set; }
        [Required]
        [Column("SECTION_CODE")]
        [StringLength(2)]
        [Unicode(false)]
        public string SectionCode { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string Status { get; set; }
    }
}
