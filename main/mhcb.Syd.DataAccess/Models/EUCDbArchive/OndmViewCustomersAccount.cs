using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    public partial class OndmViewCustomersAccount
    {
        public long RowNo { get; set; }
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("ACTNO_KIND")]
        [StringLength(3)]
        public string ActnoKind { get; set; }
        [Column("ACTNO_BRANCH_NO")]
        [StringLength(3)]
        public string ActnoBranchNo { get; set; }
        [Column("ACTNO_SERNO")]
        [StringLength(6)]
        public string ActnoSerno { get; set; }
        [Column("REV1")]
        [StringLength(4)]
        public string Rev1 { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("ACTNO_NAME")]
        [StringLength(30)]
        public string ActnoName { get; set; }
        [Column("ACTNO_ABBR")]
        [StringLength(12)]
        public string ActnoAbbr { get; set; }
        [Column("BALANCE_FC", TypeName = "decimal(15, 0)")]
        public decimal? BalanceFc { get; set; }
        [Column("BALANCE_HC", TypeName = "decimal(15, 0)")]
        public decimal? BalanceHc { get; set; }
        [Column("AVBAL_FC", TypeName = "decimal(15, 0)")]
        public decimal? AvbalFc { get; set; }
        [Column("AVBAL_HC", TypeName = "decimal(15, 0)")]
        public decimal? AvbalHc { get; set; }
        [Column("WARNING_CD")]
        [StringLength(1)]
        public string WarningCd { get; set; }
        [Column("OD_CODE")]
        [StringLength(1)]
        public string OdCode { get; set; }
        [Column("AFTBAL1", TypeName = "decimal(15, 0)")]
        public decimal? Aftbal1 { get; set; }
        [Column("AFTBAL2", TypeName = "decimal(15, 0)")]
        public decimal? Aftbal2 { get; set; }
        [Column("BASE_RATE_CD")]
        [StringLength(2)]
        public string BaseRateCd { get; set; }
        [Column("SPREAD_1", TypeName = "decimal(2, 0)")]
        public decimal? Spread1 { get; set; }
        [Column("SPREAD_FRCH1")]
        [StringLength(7)]
        public string SpreadFrch1 { get; set; }
        [Column("ODBASE_RATE_CD")]
        [StringLength(2)]
        public string OdbaseRateCd { get; set; }
        [Column("SPREAD_2", TypeName = "decimal(2, 0)")]
        public decimal? Spread2 { get; set; }
        [Column("SPREAD_FRCH2")]
        [StringLength(7)]
        public string SpreadFrch2 { get; set; }
        [Column("REMARKS")]
        [StringLength(20)]
        public string Remarks { get; set; }
        [Column("ORDEXP", TypeName = "decimal(13, 0)")]
        public decimal? Ordexp { get; set; }
        [Column("PROEXP", TypeName = "decimal(13, 0)")]
        public decimal? Proexp { get; set; }
        [Column("LSTRNS_DATE")]
        [StringLength(6)]
        public string LstrnsDate { get; set; }
        [Column("OPENING_DATE")]
        [StringLength(6)]
        public string OpeningDate { get; set; }
        [Column("CLOSEING_DATE")]
        [StringLength(6)]
        public string CloseingDate { get; set; }
        [Column("MODIFY_DATE")]
        [StringLength(6)]
        public string ModifyDate { get; set; }
        [Column("LAST_INT_DATE")]
        [StringLength(6)]
        public string LastIntDate { get; set; }
        [Column("INT_CALC_CD")]
        [StringLength(2)]
        public string IntCalcCd { get; set; }
        [Column("AUTOPOS_CD")]
        [StringLength(1)]
        public string AutoposCd { get; set; }
        [Column("APPL_NO")]
        [StringLength(7)]
        public string ApplNo { get; set; }
        [Column("SWIFT_LASTSND_DATE")]
        [StringLength(6)]
        public string SwiftLastsndDate { get; set; }
        [Column("SWIFT_LASTSND_NO")]
        [StringLength(5)]
        public string SwiftLastsndNo { get; set; }
        [Column("CALC_CD_1")]
        [StringLength(1)]
        public string CalcCd1 { get; set; }
        [Column("PAGE", TypeName = "decimal(7, 0)")]
        public decimal? Page { get; set; }
        [Column("MAIL_CD")]
        [StringLength(1)]
        public string MailCd { get; set; }
        [Column("REV2")]
        [StringLength(13)]
        public string Rev2 { get; set; }
        [Column("STATUS_CD")]
        [StringLength(1)]
        public string StatusCd { get; set; }
        [Column("CRT_DATE")]
        [StringLength(19)]
        public string CrtDate { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
        [Column("BATCH_NUMBER")]
        public int? BatchNumber { get; set; }
    }
}
