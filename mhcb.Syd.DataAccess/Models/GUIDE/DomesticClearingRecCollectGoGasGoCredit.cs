using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Rec_Collect_GO_GasGoCredit")]
    public partial class DomesticClearingRecCollectGoGasGoCredit
    {
        [Key]
        [Column("RecCollectGOGasGoCreditId")]
        public int RecCollectGogasGoCreditId { get; set; }
        public int RecCollectionId { get; set; }
        [Column("MIN_NO")]
        [StringLength(18)]
        public string MinNo { get; set; }
        [Column("GROUPNO_TX")]
        [StringLength(2)]
        public string GroupnoTx { get; set; }
        [Column("CCY_TX")]
        [StringLength(4)]
        public string CcyTx { get; set; }
        [Column("AMOUNT_AMT", TypeName = "decimal(16, 2)")]
        public decimal? AmountAmt { get; set; }
        [Column("CUSTID_TX")]
        [StringLength(12)]
        public string CustidTx { get; set; }
        [Column("ACC_CD_TX")]
        [StringLength(5)]
        public string AccCdTx { get; set; }
        [Column("ACCNUM_TX")]
        [StringLength(12)]
        public string AccnumTx { get; set; }
        [Column("DETAILS_TX")]
        [StringLength(30)]
        public string DetailsTx { get; set; }
        [Column("ADVISEPRINT_TX")]
        [StringLength(1)]
        public string AdviseprintTx { get; set; }
        [Column("FXCCY_TX")]
        [StringLength(4)]
        public string FxccyTx { get; set; }
        [Column("INTERRATE_INT", TypeName = "decimal(9, 5)")]
        public decimal? InterrateInt { get; set; }
        [Column("EXCHRATE_INT", TypeName = "decimal(9, 5)")]
        public decimal? ExchrateInt { get; set; }
        [Column("ENTITY_TX")]
        [StringLength(3)]
        public string EntityTx { get; set; }
        [Column("DIVISION_TX")]
        [StringLength(2)]
        public string DivisionTx { get; set; }
        [Column("TYPE_TX")]
        [StringLength(1)]
        public string TypeTx { get; set; }
        [Column("CHECKNO_TX")]
        [StringLength(10)]
        public string ChecknoTx { get; set; }
        [Column("FUND_TX")]
        [StringLength(1)]
        public string FundTx { get; set; }
        [Column("AVAILABLE_DATE", TypeName = "datetime")]
        public DateTime? AvailableDate { get; set; }
        [Column("IBF_TX")]
        [StringLength(1)]
        public string IbfTx { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [ForeignKey(nameof(RecCollectionId))]
        [InverseProperty(nameof(DomesticClearingRecCollection.DomesticClearingRecCollectGoGasGoCredits))]
        public virtual DomesticClearingRecCollection RecCollection { get; set; }
    }
}
