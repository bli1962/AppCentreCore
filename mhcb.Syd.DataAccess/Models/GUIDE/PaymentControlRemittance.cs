using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("PaymentControl_Remittance")]
    public partial class PaymentControlRemittance
    {
        [Key]
        public int RemittanceId { get; set; }
        [Column("GBaseRefNo")]
        [StringLength(20)]
        public string GbaseRefNo { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
        [Column(TypeName = "date")]
        public DateTime? IssueDate { get; set; }
        [Column("PODate", TypeName = "date")]
        public DateTime? Podate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ValueDate { get; set; }
        [StringLength(50)]
        public string CustomerAccount { get; set; }
        [StringLength(50)]
        public string CustomerAbbreviation { get; set; }
        [StringLength(255)]
        public string CustomerName { get; set; }
        [StringLength(50)]
        public string Department { get; set; }
        [StringLength(50)]
        public string InstructedCurrency { get; set; }
        [StringLength(50)]
        public string InstructedAmount { get; set; }
        [StringLength(50)]
        public string PendingNo { get; set; }
        [StringLength(50)]
        public string PendingReason { get; set; }
        [StringLength(50)]
        public string ExRate { get; set; }
        [StringLength(50)]
        public string AccountNo { get; set; }
        [StringLength(50)]
        public string Currency { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal Amount { get; set; }
        [StringLength(50)]
        public string BeneficiaryAccount { get; set; }
        [StringLength(50)]
        public string RemitterBeneficiary1 { get; set; }
        [StringLength(50)]
        public string RemitterBeneficiary2 { get; set; }
        [StringLength(50)]
        public string NostroId { get; set; }
        [StringLength(1024)]
        public string NostroName { get; set; }
        [Column("ReceivingBankSBIC")]
        [StringLength(50)]
        public string ReceivingBankSbic { get; set; }
        [Column("AccountWithBankSBIC")]
        [StringLength(50)]
        public string AccountWithBankSbic { get; set; }
        [Column("AccountWithBankAC")]
        [StringLength(50)]
        public string AccountWithBankAc { get; set; }
        [StringLength(50)]
        public string AccountWithBank1 { get; set; }
        [StringLength(50)]
        public string DetailsOfChgs { get; set; }
        [StringLength(50)]
        public string SenderToReceiverInfo1 { get; set; }
        [StringLength(50)]
        public string RemarkTypeofApp { get; set; }
        [StringLength(50)]
        public string RemarkSupportingDoc { get; set; }
        [StringLength(50)]
        public string CreateUser { get; set; }
        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }
        [StringLength(50)]
        public string DeleteDate { get; set; }
        [StringLength(50)]
        public string ApplicationNo { get; set; }
        [Column("RemarksEUC")]
        [StringLength(50)]
        public string RemarksEuc { get; set; }
        public bool Processed { get; set; }
        public int? PaymentId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [ForeignKey(nameof(PaymentId))]
        [InverseProperty(nameof(PaymentControlPayment.PaymentControlRemittances))]
        public virtual PaymentControlPayment Payment { get; set; }
    }
}
