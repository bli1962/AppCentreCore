using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("T_CORRESPONDENT_MASTER", Schema = "EUC")]
    public partial class TCorrespondentMaster
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("CORRES_BANK_CD")]
        [StringLength(7)]
        public string CorresBankCd { get; set; }
        [Column("BANK_NAME")]
        [StringLength(70)]
        public string BankName { get; set; }
        [Column("ADDRESS")]
        [StringLength(70)]
        public string Address { get; set; }
        [Column("LOCATION_COUNTRY")]
        [StringLength(2)]
        public string LocationCountry { get; set; }
        [Column("BANK_ABBR")]
        [StringLength(35)]
        public string BankAbbr { get; set; }
        [Column("PRIVATE_CD")]
        [StringLength(1)]
        public string PrivateCd { get; set; }
        [Column("CABLE_ADDRESS")]
        [StringLength(35)]
        public string CableAddress { get; set; }
        [Column("TELEX_NO")]
        [StringLength(15)]
        public string TelexNo { get; set; }
        [Column("ANS_BACK")]
        [StringLength(15)]
        public string AnsBack { get; set; }
        [Column("TESTKEY_SIDE_CD")]
        [StringLength(1)]
        public string TestkeySideCd { get; set; }
        [Column("TEST_FIXED_NO")]
        [StringLength(5)]
        public string TestFixedNo { get; set; }
        [Column("SWIFT_ADDRESS")]
        [StringLength(11)]
        public string SwiftAddress { get; set; }
        [Column("VIA_SWIFT")]
        [StringLength(1)]
        public string ViaSwift { get; set; }
        [Column("SWIFT_CD")]
        [StringLength(1)]
        public string SwiftCd { get; set; }
        [Column("HO_BANK_CD")]
        [StringLength(4)]
        public string HoBankCd { get; set; }
        [Column("HO_LOCATION_COUNTRY")]
        [StringLength(2)]
        public string HoLocationCountry { get; set; }
        [Column("HO_DEPO_CORRES_CD")]
        [StringLength(1)]
        public string HoDepoCorresCd { get; set; }
        [Column("HO_OUR_CCY_ABBR_1")]
        [StringLength(4)]
        public string HoOurCcyAbbr1 { get; set; }
        [Column("HO_OUR_CCY_CD_1")]
        [StringLength(2)]
        public string HoOurCcyCd1 { get; set; }
        [Column("HO_OUR_CCY_ABBR_2")]
        [StringLength(4)]
        public string HoOurCcyAbbr2 { get; set; }
        [Column("HO_OUR_CCY_CD_2")]
        [StringLength(2)]
        public string HoOurCcyCd2 { get; set; }
        [Column("HO_OUR_CCY_ABBR_3")]
        [StringLength(4)]
        public string HoOurCcyAbbr3 { get; set; }
        [Column("HO_OUR_CCY_CD_3")]
        [StringLength(2)]
        public string HoOurCcyCd3 { get; set; }
        [Column("HO_OUR_CCY1_ACT_NO")]
        [StringLength(16)]
        public string HoOurCcy1ActNo { get; set; }
        [Column("HO_THEIR_CCY_ABBR_1")]
        [StringLength(4)]
        public string HoTheirCcyAbbr1 { get; set; }
        [Column("HO_THEIR_CCY_CD_1")]
        [StringLength(2)]
        public string HoTheirCcyCd1 { get; set; }
        [Column("HO_THEIR_CCY_ABBR_2")]
        [StringLength(4)]
        public string HoTheirCcyAbbr2 { get; set; }
        [Column("HO_THEIR_CCY_CD_2")]
        [StringLength(2)]
        public string HoTheirCcyCd2 { get; set; }
        [Column("HO_THEIR_CCY_ABBR_3")]
        [StringLength(4)]
        public string HoTheirCcyAbbr3 { get; set; }
        [Column("HO_THEIR_CCY_CD_3")]
        [StringLength(2)]
        public string HoTheirCcyCd3 { get; set; }
        [Column("OVSEA_BR_NO")]
        [StringLength(3)]
        public string OvseaBrNo { get; set; }
        [Column("BR_DEPO_CORRES_CD")]
        [StringLength(1)]
        public string BrDepoCorresCd { get; set; }
        [Column("BR_OUR_CCY_ABBR")]
        [StringLength(4)]
        public string BrOurCcyAbbr { get; set; }
        [Column("BR_OUR_CCY_CD")]
        [StringLength(2)]
        public string BrOurCcyCd { get; set; }
        [Column("BR_SHADOW_ACT_NO")]
        [StringLength(12)]
        public string BrShadowActNo { get; set; }
        [Column("BR_OUR_ACT_NO")]
        [StringLength(16)]
        public string BrOurActNo { get; set; }
        [Column("BR_THEIR_CCY_ABBR")]
        [StringLength(4)]
        public string BrTheirCcyAbbr { get; set; }
        [Column("BR_THEIR_CCY_CD")]
        [StringLength(2)]
        public string BrTheirCcyCd { get; set; }
        [Column("BR_THEIR_ACT_NO")]
        [StringLength(12)]
        public string BrTheirActNo { get; set; }
        [Column("BR_CUST_ABBR")]
        [StringLength(12)]
        public string BrCustAbbr { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
