using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("RAM_BASE_RECORDS")]
    public partial class RamBaseRecord
    {
        [Column("PROCESS_DATE", TypeName = "datetime")]
        public DateTime ProcessDate { get; set; }
        [Required]
        [Column("RAM_TYPE_CODE")]
        [StringLength(20)]
        public string RamTypeCode { get; set; }
        [Required]
        [Column("KIND")]
        [StringLength(5)]
        public string Kind { get; set; }
        [Required]
        [Column("CCY")]
        [StringLength(4)]
        public string Ccy { get; set; }
        [Column("REC_TOTAL")]
        public int RecTotal { get; set; }
        [Required]
        [Column("DEPARTMENT")]
        [StringLength(100)]
        public string Department { get; set; }
        [Required]
        [Column("BRANCH")]
        [StringLength(3)]
        public string Branch { get; set; }
        [Column("APPROVED_AMT", TypeName = "decimal(18, 2)")]
        public decimal ApprovedAmt { get; set; }
        [Column("REC_DELETED")]
        public int RecDeleted { get; set; }
        [Column("DELETED_AMT", TypeName = "decimal(18, 2)")]
        public decimal? DeletedAmt { get; set; }
    }
}
