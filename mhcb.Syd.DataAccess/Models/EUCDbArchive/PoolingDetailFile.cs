using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("POOLING_DETAIL_FILE", Schema = "EUC")]
    public partial class PoolingDetailFile
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_ID")]
        [StringLength(3)]
        public string BranchId { get; set; }
        [Column("RECORD_ID")]
        [StringLength(1)]
        public string RecordId { get; set; }
        [Column("SCHEME_NO")]
        [StringLength(10)]
        public string SchemeNo { get; set; }
        [Column("SCHEME_DATE", TypeName = "datetime")]
        public DateTime? SchemeDate { get; set; }
        [Column("TRANS_KIND")]
        [StringLength(3)]
        public string TransKind { get; set; }
        [Column("SCHEME_TIMING")]
        [StringLength(4)]
        public string SchemeTiming { get; set; }
        [Column("TRANS_NO")]
        [StringLength(5)]
        public string TransNo { get; set; }
        [Column("POOLING_ID")]
        [StringLength(1)]
        public string PoolingId { get; set; }
        [Column("REV_FLG")]
        [StringLength(1)]
        public string RevFlg { get; set; }
        [Column("SCHEME_NAME")]
        [StringLength(40)]
        public string SchemeName { get; set; }
        [Column("CREATE_DATE", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("STATUS_CD")]
        [StringLength(1)]
        public string StatusCd { get; set; }
        [Column("VALUE_DATE", TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column("DUE_DATE", TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        [Column("BASE_RATE_CD")]
        [StringLength(2)]
        public string BaseRateCd { get; set; }
        [Column("SPREAD", TypeName = "decimal(9, 7)")]
        public decimal? Spread { get; set; }
        [Column("CALC_CD")]
        [StringLength(1)]
        public string CalcCd { get; set; }
        [Column("REMARKS")]
        [StringLength(30)]
        public string Remarks { get; set; }
        [Column("RESULT_CD")]
        [StringLength(3)]
        public string ResultCd { get; set; }
        [Column("NOJNL_FLG")]
        [StringLength(1)]
        public string NojnlFlg { get; set; }
        [Column("EXTRACT_FLG")]
        [StringLength(1)]
        public string ExtractFlg { get; set; }
        [Column("TRANS_FLG")]
        [StringLength(1)]
        public string TransFlg { get; set; }
        [Column("FROM_AREA")]
        [StringLength(1)]
        public string FromArea { get; set; }
        [Column("TO_AREA")]
        [StringLength(1)]
        public string ToArea { get; set; }
        [Column("PAYMENT_DATE", TypeName = "datetime")]
        public DateTime? PaymentDate { get; set; }
        [Column("RECEIPT_DATE", TypeName = "datetime")]
        public DateTime? ReceiptDate { get; set; }
        [Column("DR_CR")]
        [StringLength(1)]
        public string DrCr { get; set; }
        [Column("PTN_ID")]
        [StringLength(1)]
        public string PtnId { get; set; }
        [Column("PTN_BRANCH_ID")]
        [StringLength(3)]
        public string PtnBranchId { get; set; }
        [Column("SWIFT_CCY_CD")]
        [StringLength(3)]
        public string SwiftCcyCd { get; set; }
        [Column("ACT_NO")]
        [StringLength(20)]
        public string ActNo { get; set; }
        [Column("AMOUNT", TypeName = "decimal(19, 3)")]
        public decimal? Amount { get; set; }
        [Column("SEQ_NO")]
        [StringLength(6)]
        public string SeqNo { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
