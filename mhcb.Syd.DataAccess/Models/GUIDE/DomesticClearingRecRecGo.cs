using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Rec_Rec_GO")]
    public partial class DomesticClearingRecRecGo
    {
        [Key]
        [Column("RecRecGOId")]
        public int RecRecGoid { get; set; }
        public int RecBatchId { get; set; }
        [Column("GO_RecCollateGOId")]
        public int? GoRecCollateGoid { get; set; }
        [Column("GAS_RecCollateGOId")]
        public int? GasRecCollateGoid { get; set; }
        [Column("EUC_RecCollateGOId")]
        public int? EucRecCollateGoid { get; set; }
        [StringLength(50)]
        public string TransNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OperationDate { get; set; }
        [Column("GO_Remark")]
        [StringLength(30)]
        public string GoRemark { get; set; }
        [Column("GAS_Remark")]
        [StringLength(30)]
        public string GasRemark { get; set; }
        [Column("EUC_Remark")]
        [StringLength(30)]
        public string EucRemark { get; set; }
        [Column("GO_ValueDate", TypeName = "datetime")]
        public DateTime? GoValueDate { get; set; }
        [Column("GAS_ValueDate", TypeName = "datetime")]
        public DateTime? GasValueDate { get; set; }
        [Column("EUC_ValueDate", TypeName = "datetime")]
        public DateTime? EucValueDate { get; set; }
        [Column("GO_DebitAmount", TypeName = "decimal(22, 8)")]
        public decimal? GoDebitAmount { get; set; }
        [Column("GAS_DebitAmount", TypeName = "decimal(22, 8)")]
        public decimal? GasDebitAmount { get; set; }
        [Column("EUC_DebitAmount", TypeName = "decimal(22, 8)")]
        public decimal? EucDebitAmount { get; set; }
        [Column("GO_CreditAmount", TypeName = "decimal(22, 8)")]
        public decimal? GoCreditAmount { get; set; }
        [Column("GAS_CreditAmount", TypeName = "decimal(22, 8)")]
        public decimal? GasCreditAmount { get; set; }
        [Column("EUC_CreditAmount", TypeName = "decimal(22, 8)")]
        public decimal? EucCreditAmount { get; set; }
        [Column("GO_DebitCurrency")]
        [StringLength(4)]
        public string GoDebitCurrency { get; set; }
        [Column("GAS_DebitCurrency")]
        [StringLength(4)]
        public string GasDebitCurrency { get; set; }
        [Column("EUC_DebitCurrency")]
        [StringLength(4)]
        public string EucDebitCurrency { get; set; }
        [Column("GO_CreditCurrency")]
        [StringLength(4)]
        public string GoCreditCurrency { get; set; }
        [Column("GAS_CreditCurrency")]
        [StringLength(4)]
        public string GasCreditCurrency { get; set; }
        [Column("EUC_CreditCurrency")]
        [StringLength(4)]
        public string EucCreditCurrency { get; set; }
        [Column("GO_DebitAccountCode")]
        [StringLength(20)]
        public string GoDebitAccountCode { get; set; }
        [Column("GAS_DebitAccountCode")]
        [StringLength(20)]
        public string GasDebitAccountCode { get; set; }
        [Column("EUC_DebitAccountCode")]
        [StringLength(20)]
        public string EucDebitAccountCode { get; set; }
        [Column("GO_DebitAccountNumber")]
        [StringLength(20)]
        public string GoDebitAccountNumber { get; set; }
        [Column("GAS_DebitAccountNumber")]
        [StringLength(20)]
        public string GasDebitAccountNumber { get; set; }
        [Column("EUC_DebitAccountNumber")]
        [StringLength(20)]
        public string EucDebitAccountNumber { get; set; }
        [Column("GO_CreditAccountCode")]
        [StringLength(20)]
        public string GoCreditAccountCode { get; set; }
        [Column("GAS_CreditAccountCode")]
        [StringLength(20)]
        public string GasCreditAccountCode { get; set; }
        [Column("EUC_CreditAccountCode")]
        [StringLength(20)]
        public string EucCreditAccountCode { get; set; }
        [Column("GO_CreditAccountNumber")]
        [StringLength(20)]
        public string GoCreditAccountNumber { get; set; }
        [Column("GAS_CreditAccountNumber")]
        [StringLength(20)]
        public string GasCreditAccountNumber { get; set; }
        [Column("EUC_CreditAccountNumber")]
        [StringLength(20)]
        public string EucCreditAccountNumber { get; set; }
        [Column("GO_DebitCustomerAbbreviation")]
        [StringLength(12)]
        public string GoDebitCustomerAbbreviation { get; set; }
        [Column("GAS_DebitCustomerAbbreviation")]
        [StringLength(12)]
        public string GasDebitCustomerAbbreviation { get; set; }
        [Column("EUC_DebitCustomerAbbreviation")]
        [StringLength(12)]
        public string EucDebitCustomerAbbreviation { get; set; }
        [Column("GO_CreditCustomerAbbreviation")]
        [StringLength(12)]
        public string GoCreditCustomerAbbreviation { get; set; }
        [Column("GAS_CreditCustomerAbbreviation")]
        [StringLength(12)]
        public string GasCreditCustomerAbbreviation { get; set; }
        [Column("EUC_CreditCustomerAbbreviation")]
        [StringLength(12)]
        public string EucCreditCustomerAbbreviation { get; set; }
        public int? RecKeyStatusId { get; set; }
        public int? RecValueStatusId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [ForeignKey(nameof(RecBatchId))]
        [InverseProperty(nameof(DomesticClearingRecBatch.DomesticClearingRecRecGos))]
        public virtual DomesticClearingRecBatch RecBatch { get; set; }
        [ForeignKey(nameof(RecKeyStatusId))]
        [InverseProperty(nameof(DomesticClearingRecKeyStatus.DomesticClearingRecRecGos))]
        public virtual DomesticClearingRecKeyStatus RecKeyStatus { get; set; }
        [ForeignKey(nameof(RecValueStatusId))]
        [InverseProperty(nameof(DomesticClearingRecValueStatus.DomesticClearingRecRecGos))]
        public virtual DomesticClearingRecValueStatus RecValueStatus { get; set; }
    }
}
