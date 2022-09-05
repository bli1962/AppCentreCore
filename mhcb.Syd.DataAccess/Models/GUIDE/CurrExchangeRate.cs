using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("CURR_EXCHANGE_RATES")]
    public partial class CurrExchangeRate
    {
        [Column("EFFECTIVE_DATE", TypeName = "datetime")]
        public DateTime EffectiveDate { get; set; }
        [Required]
        [Column("TO_CCY_CODE")]
        [StringLength(10)]
        public string ToCcyCode { get; set; }
        [Required]
        [Column("FROM_CCY_CODE")]
        [StringLength(10)]
        public string FromCcyCode { get; set; }
        [Column("ODB_RATE", TypeName = "decimal(16, 9)")]
        public decimal OdbRate { get; set; }
        [Column("TTB_RATE", TypeName = "decimal(16, 9)")]
        public decimal TtbRate { get; set; }
        [Column("MEAN_RATE", TypeName = "decimal(16, 9)")]
        public decimal MeanRate { get; set; }
        [Column("ODS_RATE", TypeName = "decimal(16, 9)")]
        public decimal OdsRate { get; set; }
        [Column("TTS_RATE", TypeName = "decimal(16, 9)")]
        public decimal TtsRate { get; set; }
    }
}
