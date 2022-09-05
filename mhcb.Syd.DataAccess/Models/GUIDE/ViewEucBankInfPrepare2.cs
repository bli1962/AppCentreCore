using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    public partial class ViewEucBankInfPrepare2
    {
        [Column("SWIFT_ID")]
        [StringLength(11)]
        public string SwiftId { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("SETTL_BRANCH_NO")]
        [StringLength(3)]
        public string SettlBranchNo { get; set; }
        [Column("ACRONYM")]
        [StringLength(6)]
        public string Acronym { get; set; }
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
        [Column("LOCATION_COUNTRY")]
        [StringLength(2)]
        public string LocationCountry { get; set; }
        [Column("SWIFT_FLG")]
        [StringLength(1)]
        public string SwiftFlg { get; set; }
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
        [Column("COR_BANK_CD")]
        [StringLength(7)]
        public string CorBankCd { get; set; }
        [Column("MHCB_BR_ABBR")]
        [StringLength(2)]
        public string MhcbBrAbbr { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("REMARKS")]
        [StringLength(50)]
        public string Remarks { get; set; }
    }
}
