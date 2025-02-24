using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("BANK_INF", Schema = "dbo")]
    public partial class BankInf
    {
        public BankInf()
        {
            BankInfCorrs = new HashSet<BankInfCorr>();
        }

        [Key]
        [Column("SWIFT_ID")]
        [StringLength(12)]
        [Unicode(false)]
        public string SwiftId { get; set; }
        [Required]
        [Column("BRANCH_NO")]
        [StringLength(3)]
        [Unicode(false)]
        public string BranchNo { get; set; }
        [Key]
        [Column("SETTL_BRANCH_NO")]
        [StringLength(3)]
        [Unicode(false)]
        public string SettlBranchNo { get; set; }
        [Column("ACRONYM")]
        [StringLength(6)]
        [Unicode(false)]
        public string Acronym { get; set; }
        [Column("NAME_ADDR_1")]
        [StringLength(35)]
        [Unicode(false)]
        public string NameAddr1 { get; set; }
        [Column("NAME_ADDR_2")]
        [StringLength(35)]
        [Unicode(false)]
        public string NameAddr2 { get; set; }
        [Column("NAME_ADDR_3")]
        [StringLength(35)]
        [Unicode(false)]
        public string NameAddr3 { get; set; }
        [Column("NAME_ADDR_4")]
        [StringLength(35)]
        [Unicode(false)]
        public string NameAddr4 { get; set; }
        [Column("LOCATION_COUNTRY")]
        [StringLength(2)]
        [Unicode(false)]
        public string LocationCountry { get; set; }
        [Column("SWIFT_FLG")]
        [StringLength(1)]
        [Unicode(false)]
        public string SwiftFlg { get; set; }
        [Column("CHIPS_UID")]
        [StringLength(6)]
        [Unicode(false)]
        public string ChipsUid { get; set; }
        [Column("CHIPS_ABA")]
        [StringLength(4)]
        [Unicode(false)]
        public string ChipsAba { get; set; }
        [Column("FED_ID")]
        [StringLength(9)]
        [Unicode(false)]
        public string FedId { get; set; }
        [Column("CHAPS_SORT_CD")]
        [StringLength(6)]
        [Unicode(false)]
        public string ChapsSortCd { get; set; }
        [Column("COR_BANK_CD")]
        [StringLength(7)]
        [Unicode(false)]
        public string CorBankCd { get; set; }
        [Column("MHCB_BR_ABBR")]
        [StringLength(2)]
        [Unicode(false)]
        public string MhcbBrAbbr { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        [Unicode(false)]
        public string CustAbbr { get; set; }
        [Column("REMARKS")]
        [StringLength(50)]
        [Unicode(false)]
        public string Remarks { get; set; }
        [Required]
        [Column("ADD_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string AddBy { get; set; }
        [Column("ADD_ON", TypeName = "smalldatetime")]
        public DateTime AddOn { get; set; }
        [Required]
        [Column("AUTHORIZE_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string AuthorizeBy { get; set; }
        [Column("AUTHORIZE_ON", TypeName = "smalldatetime")]
        public DateTime AuthorizeOn { get; set; }
        [Required]
        [Column("MODIFY_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string ModifyBy { get; set; }
        [Column("MODIFY_ON", TypeName = "smalldatetime")]
        public DateTime ModifyOn { get; set; }
        [Required]
        [Column("DELETE_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string DeleteBy { get; set; }
        [Column("DELETE_ON", TypeName = "smalldatetime")]
        public DateTime DeleteOn { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string Status { get; set; }
        [Required]
        [Column("DELETION_STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string DeletionStatus { get; set; }
        [Column("GIP_STATUS")]
        [StringLength(2)]
        [Unicode(false)]
        public string GipStatus { get; set; }
        [Column("GIP_DESCRIPTION")]
        [StringLength(100)]
        [Unicode(false)]
        public string GipDescription { get; set; }
        [Column("TRAN_NO")]
        [StringLength(5)]
        [Unicode(false)]
        public string TranNo { get; set; }

        [InverseProperty("S")]
        public virtual ICollection<BankInfCorr> BankInfCorrs { get; set; }
    }
}
