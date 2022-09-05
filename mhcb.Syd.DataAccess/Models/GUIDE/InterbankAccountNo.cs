using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("INTERBANK_ACCOUNT_NO")]
    [Index(nameof(CcyCd), nameof(BranchNo), nameof(DefaultFlg), Name = "IX_INTERBANK_ACCOUNT_NO", IsUnique = true)]
    public partial class InterbankAccountNo
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("SWIFT_ID")]
        [StringLength(12)]
        public string SwiftId { get; set; }
        [Required]
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("NAME")]
        [StringLength(35)]
        public string Name { get; set; }
        [Required]
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("ACT_NO")]
        [StringLength(9)]
        public string ActNo { get; set; }
        [Column("SWIFT_FLG")]
        [StringLength(1)]
        public string SwiftFlg { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Required]
        [Column("Default_Flg")]
        public bool? DefaultFlg { get; set; }
    }
}
