using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("M_BANK_INF", Schema = "EUC")]
    public partial class MBankInf
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("SWIFT_ID")]
        [StringLength(11)]
        public string SwiftId { get; set; }
        [Column("CHIPS_UID")]
        [StringLength(6)]
        public string ChipsUid { get; set; }
        [Column("CHIPS_ABA")]
        [StringLength(4)]
        public string ChipsAba { get; set; }
        [Column("FED_ID")]
        [StringLength(9)]
        public string FedId { get; set; }
        [Column("CHAPS_SORT_CD")]
        [StringLength(6)]
        public string ChapsSortCd { get; set; }
        [Column("ACRONYM")]
        [StringLength(6)]
        public string Acronym { get; set; }
        [Column("SWIFT_FLG")]
        [StringLength(1)]
        public string SwiftFlg { get; set; }
        [Column("LOCATION_COUNTRY")]
        [StringLength(2)]
        public string LocationCountry { get; set; }
        [Column("COR_BANK_CD")]
        [StringLength(7)]
        public string CorBankCd { get; set; }
        [Column("MHCB_BR_ABBR")]
        [StringLength(2)]
        public string MhcbBrAbbr { get; set; }
        [Column("NAME_ADDR_1")]
        [StringLength(35)]
        public string NameAddr1 { get; set; }
        [Column("NAME_ADDR_2")]
        [StringLength(35)]
        public string NameAddr2 { get; set; }
        [Column("NAME_ADDR_3")]
        [StringLength(35)]
        public string NameAddr3 { get; set; }
        [Column("NAME_ADDR_4")]
        [StringLength(35)]
        public string NameAddr4 { get; set; }
        [Column("REMARKS")]
        [StringLength(50)]
        public string Remarks { get; set; }
        [Column("SETTL_BRANCH_NO")]
        [StringLength(3)]
        public string SettlBranchNo { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("MM_SETTL_BANK_ID")]
        [StringLength(12)]
        public string MmSettlBankId { get; set; }
        [Column("MM_SETTL_BANK_ACTNO")]
        [StringLength(34)]
        public string MmSettlBankActno { get; set; }
        [Column("ACINF_ACT_CODE")]
        [StringLength(5)]
        public string AcinfActCode { get; set; }
        [Column("ACINF_CUST_ABBR")]
        [StringLength(12)]
        public string AcinfCustAbbr { get; set; }
        [Column("ACINF_ACT_NO")]
        [StringLength(12)]
        public string AcinfActNo { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
