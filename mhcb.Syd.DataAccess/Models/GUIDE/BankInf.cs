using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("BANK_INF")]
    public partial class BankInf
    {
        public BankInf()
        {
            BankInfCorrs = new HashSet<BankInfCorr>();
        }

        [Key]
        [Column("SWIFT_ID")]
        [StringLength(12)]
        public string SwiftId { get; set; }
        [Required]
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Key]
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
        [Required]
        [Column("ADD_BY")]
        [StringLength(8)]
        public string AddBy { get; set; }
        [Column("ADD_ON", TypeName = "smalldatetime")]
        public DateTime AddOn { get; set; }
        [Required]
        [Column("AUTHORIZE_BY")]
        [StringLength(8)]
        public string AuthorizeBy { get; set; }
        [Column("AUTHORIZE_ON", TypeName = "smalldatetime")]
        public DateTime AuthorizeOn { get; set; }
        [Required]
        [Column("MODIFY_BY")]
        [StringLength(8)]
        public string ModifyBy { get; set; }
        [Column("MODIFY_ON", TypeName = "smalldatetime")]
        public DateTime ModifyOn { get; set; }
        [Required]
        [Column("DELETE_BY")]
        [StringLength(8)]
        public string DeleteBy { get; set; }
        [Column("DELETE_ON", TypeName = "smalldatetime")]
        public DateTime DeleteOn { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
        [Required]
        [Column("DELETION_STATUS")]
        [StringLength(1)]
        public string DeletionStatus { get; set; }
        [Column("GIP_STATUS")]
        [StringLength(2)]
        public string GipStatus { get; set; }
        [Column("GIP_DESCRIPTION")]
        [StringLength(100)]
        public string GipDescription { get; set; }
        [Column("TRAN_NO")]
        [StringLength(5)]
        public string TranNo { get; set; }

        [InverseProperty(nameof(BankInfCorr.S))]
        public virtual ICollection<BankInfCorr> BankInfCorrs { get; set; }
    }
}
