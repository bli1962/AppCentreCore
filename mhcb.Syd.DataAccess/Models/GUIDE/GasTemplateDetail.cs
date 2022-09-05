using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("GAS_TEMPLATE_DETAILS")]
    public partial class GasTemplateDetail
    {
        [Required]
        [Column("TEMPLATE_NAME")]
        [StringLength(30)]
        public string TemplateName { get; set; }
        [Required]
        [Column("ITEM_NUMBER")]
        [StringLength(1)]
        public string ItemNumber { get; set; }
        [Column("DEBIT")]
        [StringLength(1)]
        public string Debit { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("CUST_NAME")]
        [StringLength(40)]
        public string CustName { get; set; }
        [Column("ACCOUNT_NUMBER")]
        [StringLength(12)]
        public string AccountNumber { get; set; }
        [Column("ACCOUNT_CODE")]
        [StringLength(5)]
        public string AccountCode { get; set; }
        [Column("ADVICE")]
        [StringLength(1)]
        public string Advice { get; set; }
        [Column("ENTITY")]
        [StringLength(3)]
        public string Entity { get; set; }
        [Column("DIVISION")]
        [StringLength(3)]
        public string Division { get; set; }
        [Column("AMOUNT_CCY")]
        [StringLength(3)]
        public string AmountCcy { get; set; }
        [Column("EXCH_RATE_CCY")]
        [StringLength(3)]
        public string ExchRateCcy { get; set; }
        [Column("DETAILS")]
        [StringLength(30)]
        public string Details { get; set; }
        [Column("FUND")]
        [StringLength(1)]
        public string Fund { get; set; }
        [Column("AMOUNT_AMOUNT", TypeName = "decimal(16, 2)")]
        public decimal? AmountAmount { get; set; }
        [Column("EXCH_RATE_AMOUNT", TypeName = "decimal(9, 5)")]
        public decimal? ExchRateAmount { get; set; }
        [Column("INTERRATE", TypeName = "decimal(9, 5)")]
        public decimal? Interrate { get; set; }
        [Column("IBF_TX")]
        [StringLength(1)]
        public string IbfTx { get; set; }
    }
}
