using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Keyless]
    public partial class ViewEucFeeAndCharge2
    {
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("FEE_KIND")]
        [StringLength(5)]
        public string FeeKind { get; set; }
        [Column("FEE_NO")]
        [StringLength(3)]
        public string FeeNo { get; set; }
        [Column("FEE_RATE", TypeName = "decimal(9, 6)")]
        public decimal? FeeRate { get; set; }
        [Column("FEE_START_DATE", TypeName = "datetime")]
        public DateTime? FeeStartDate { get; set; }
        [Column("FEE_END_DATE", TypeName = "datetime")]
        public DateTime? FeeEndDate { get; set; }
        [Column("CEIL_AMOUNT", TypeName = "decimal(18, 3)")]
        public decimal? CeilAmount { get; set; }
        [Column("FLOOR_AMOUNT", TypeName = "decimal(18, 3)")]
        public decimal? FloorAmount { get; set; }
        [Column("AMOUNT_RATIO", TypeName = "decimal(10, 6)")]
        public decimal? AmountRatio { get; set; }
        [Column("LAST_COLLECTION", TypeName = "datetime")]
        public DateTime? LastCollection { get; set; }
        [Column("TTL_AMOUNT", TypeName = "decimal(18, 3)")]
        public decimal? TtlAmount { get; set; }
        [Column("NEXT_COLLECTION", TypeName = "datetime")]
        public DateTime? NextCollection { get; set; }
        [Column("COLLECTED_AMOUNT", TypeName = "decimal(18, 3)")]
        public decimal? CollectedAmount { get; set; }
    }
}
