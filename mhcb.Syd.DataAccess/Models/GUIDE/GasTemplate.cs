using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("GAS_TEMPLATE")]
    public partial class GasTemplate
    {
        [Required]
        [Column("TEMPLATE_NAME")]
        [StringLength(30)]
        public string TemplateName { get; set; }
        [Column("TYPE")]
        [StringLength(2)]
        public string Type { get; set; }
        [Column("CATEGORY")]
        [StringLength(30)]
        public string Category { get; set; }
        [Column("ACU_BU")]
        [StringLength(3)]
        public string AcuBu { get; set; }
        [Column("REMARKS")]
        [StringLength(30)]
        public string Remarks { get; set; }
        [Column("BACK_VALUE")]
        [StringLength(1)]
        public string BackValue { get; set; }
        [Column("REASON")]
        [StringLength(30)]
        public string Reason { get; set; }
        [Column("CREATED_BY")]
        [StringLength(8)]
        public string CreatedBy { get; set; }
        [Column("CREATED_DATE", TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("APPROVED_BY")]
        [StringLength(8)]
        public string ApprovedBy { get; set; }
        [Column("APPROVED_DATE", TypeName = "datetime")]
        public DateTime? ApprovedDate { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
    }
}
