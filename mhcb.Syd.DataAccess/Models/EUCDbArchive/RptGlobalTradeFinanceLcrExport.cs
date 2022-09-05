using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("RptGlobalTradeFinanceLCR_Export")]
    public partial class RptGlobalTradeFinanceLcrExport
    {
        [Column("RPT_GTF_LCR_Export_ID")]
        public int RptGtfLcrExportId { get; set; }
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime DataDate { get; set; }
        [Column("UPLOAD_DATE", TypeName = "datetime")]
        public DateTime UploadDate { get; set; }
        [Column("ACTION")]
        [StringLength(20)]
        public string Action { get; set; }
        [Column("TYPE")]
        [StringLength(20)]
        public string Type { get; set; }
        [Column("tradeExternalId")]
        [StringLength(20)]
        public string TradeExternalId { get; set; }
        [Column("tradeDate", TypeName = "datetime")]
        public DateTime? TradeDate { get; set; }
        [Column("theirName")]
        [StringLength(20)]
        public string TheirName { get; set; }
        [Column("account")]
        [StringLength(20)]
        public string Account { get; set; }
        [Column("borrowOrLend")]
        [StringLength(10)]
        public string BorrowOrLend { get; set; }
        [Column("balance", TypeName = "decimal(18, 2)")]
        public decimal? Balance { get; set; }
        [Column("settlementCcy")]
        [StringLength(10)]
        public string SettlementCcy { get; set; }
        [Column("effectiveDate", TypeName = "datetime")]
        public DateTime? EffectiveDate { get; set; }
        [StringLength(20)]
        public string FacilityType { get; set; }
        [Column("Maturity_Date")]
        [StringLength(20)]
        public string MaturityDate { get; set; }
        [StringLength(5)]
        public string Revolving { get; set; }
        [Column(TypeName = "decimal(6, 6)")]
        public decimal? Rates { get; set; }
        [StringLength(20)]
        public string RecordStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("UploadDate", TypeName = "datetime")]
        public DateTime? UploadDate1 { get; set; }
    }
}
