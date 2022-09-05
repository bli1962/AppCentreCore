using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_BulkPaymentDetail")]
    public partial class DomesticClearingBulkPaymentDetail
    {
        [Key]
        public int BulkPaymentDetailId { get; set; }
        [Column("GCMSReferenceNumber")]
        [StringLength(50)]
        public string GcmsreferenceNumber { get; set; }
        [StringLength(50)]
        public string Creator { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(50)]
        public string Approver1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApproveDate1 { get; set; }
        [StringLength(50)]
        public string Approver2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApproveDate2 { get; set; }
        [StringLength(50)]
        public string Approver3 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApproveDate3 { get; set; }
        [StringLength(50)]
        public string Approver4 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApproveDate4 { get; set; }
        [StringLength(50)]
        public string Approver5 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApproveDate5 { get; set; }
        [StringLength(50)]
        public string TransactionStatusType { get; set; }
        [StringLength(50)]
        public string BlankColumn { get; set; }
        [StringLength(50)]
        public string RecordNumber { get; set; }
        [StringLength(50)]
        public string DetailStatusType { get; set; }
        [StringLength(50)]
        public string AccountNumber { get; set; }
        [StringLength(255)]
        public string RegisteredAccountAddress { get; set; }
        [StringLength(50)]
        public string DebitAccountCurrency { get; set; }
        [StringLength(50)]
        public string CustomerCode { get; set; }
        [StringLength(50)]
        public string CustomerName { get; set; }
        [StringLength(50)]
        public string NewPaymentMethod { get; set; }
        [StringLength(1024)]
        public string Explanation { get; set; }
        [StringLength(50)]
        public string RemittanceCurrency { get; set; }
        [StringLength(50)]
        public string RemittanceAmount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? ExchangeRate { get; set; }
        [StringLength(50)]
        public string ExchangeRateInput { get; set; }
        [StringLength(50)]
        public string CustomerReferenceNumber { get; set; }
        [StringLength(50)]
        public string ReferenceAuthority { get; set; }
        [StringLength(255)]
        public string BankStaffName { get; set; }
        [StringLength(50)]
        public string ExchangeReservationNumber1 { get; set; }
        [StringLength(50)]
        public string ExchangeReservationNumber2 { get; set; }
        [StringLength(50)]
        public string ExchangeReservationNumber3 { get; set; }
        [StringLength(50)]
        public string ExchangeReservationNumber4 { get; set; }
        [StringLength(50)]
        public string ExchangeReservationNumber5 { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? TakeupAmount1 { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? TakeupAmount2 { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? TakeupAmount3 { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? TakeupAmount4 { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? TakeupAmount5 { get; set; }
        [StringLength(50)]
        public string ExchangeReservationRate1 { get; set; }
        [StringLength(50)]
        public string ExchangeReservationRate2 { get; set; }
        [StringLength(50)]
        public string ExchangeReservationRate3 { get; set; }
        [StringLength(50)]
        public string ExchangeReservationRate4 { get; set; }
        [StringLength(50)]
        public string ExchangeReservationRate5 { get; set; }
        [StringLength(50)]
        public string Usage { get; set; }
        [StringLength(1024)]
        public string RemarksChineseSimplified { get; set; }
        [StringLength(50)]
        public string BeneficiaryAccountNumber { get; set; }
        [Column("IBANcode")]
        [StringLength(50)]
        public string Ibancode { get; set; }
        [StringLength(255)]
        public string BeneficiarysNameChineseSimplified { get; set; }
        [StringLength(255)]
        public string BeneficiarysNameDoubleByteCharacter { get; set; }
        [StringLength(255)]
        public string BeneficiaryName1 { get; set; }
        [StringLength(255)]
        public string BeneficiaryName2 { get; set; }
        [StringLength(255)]
        public string BeneficiaryAddress1 { get; set; }
        [StringLength(255)]
        public string BeneficiaryAddress2 { get; set; }
        [StringLength(50)]
        public string BankCodeBeneficiaryBank { get; set; }
        [StringLength(50)]
        public string BankCodeBeneficiaryBankforChinese { get; set; }
        [StringLength(50)]
        public string FinancialInstitutionCodeBeneficiaryBank { get; set; }
        [StringLength(50)]
        public string SortCodeBeneficiaryBank { get; set; }
        [Column("SWIFTBICBeneficiaryBank")]
        [StringLength(50)]
        public string SwiftbicbeneficiaryBank { get; set; }
        [StringLength(50)]
        public string ChipsBeneficiaryBank { get; set; }
        [Column("ABANumberBeneficiaryBank")]
        [StringLength(50)]
        public string AbanumberBeneficiaryBank { get; set; }
        [StringLength(255)]
        public string BeneficiaryBankName1 { get; set; }
        [StringLength(255)]
        public string BeneficiaryBankName2 { get; set; }
        [StringLength(255)]
        public string BeneficiaryBankAddress1 { get; set; }
        [StringLength(255)]
        public string BeneficiaryBankAddress2 { get; set; }
        [StringLength(255)]
        public string BeneficiaryBankChineseSimplified { get; set; }
        [StringLength(50)]
        public string BankCodeIntermediaryBank { get; set; }
        [StringLength(50)]
        public string BankCodeIntermediaryBankforChinese { get; set; }
        [StringLength(50)]
        public string FinancialInstitutionCodeIntermediaryBank { get; set; }
        [StringLength(50)]
        public string SortcodeIntermediaryBank { get; set; }
        [Column("SWIFTBICIntermediaryBank")]
        [StringLength(50)]
        public string SwiftbicintermediaryBank { get; set; }
        [StringLength(50)]
        public string ChipsIntermediaryBank { get; set; }
        [Column("ABANumberIntermediaryBank")]
        [StringLength(50)]
        public string AbanumberIntermediaryBank { get; set; }
        [StringLength(50)]
        public string Province { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(255)]
        public string IntermediaryBankName1 { get; set; }
        [StringLength(255)]
        public string IntermediaryBankName2 { get; set; }
        [StringLength(255)]
        public string IntermediaryBankAddress1 { get; set; }
        [StringLength(255)]
        public string IntermediaryBankAddress2 { get; set; }
        [StringLength(255)]
        public string IntermediaryBankChineseSimplified { get; set; }
        [StringLength(50)]
        public string BankCharges { get; set; }
        [StringLength(50)]
        public string ChargeAccount { get; set; }
        [StringLength(50)]
        public string InstructionCode { get; set; }
        [StringLength(255)]
        public string RegulatoryReporting { get; set; }
        [StringLength(1024)]
        public string RemittanceInformation { get; set; }
        [StringLength(1024)]
        public string MessagetoBranch { get; set; }
        [StringLength(50)]
        public string RemittancetoPersonalAccount { get; set; }
        [StringLength(255)]
        public string Field1 { get; set; }
        [StringLength(255)]
        public string Field2 { get; set; }
        [StringLength(255)]
        public string Field3 { get; set; }
        [StringLength(255)]
        public string Field4 { get; set; }
        [StringLength(255)]
        public string Field5 { get; set; }
        [StringLength(255)]
        public string Field6 { get; set; }
        [StringLength(255)]
        public string Field7 { get; set; }
        [StringLength(255)]
        public string Field8 { get; set; }
        [StringLength(255)]
        public string Field9 { get; set; }
        [StringLength(255)]
        public string Field10 { get; set; }
        [StringLength(255)]
        public string Field11 { get; set; }
        [StringLength(255)]
        public string Field12 { get; set; }
        [StringLength(255)]
        public string Field13 { get; set; }
        [StringLength(255)]
        public string Field14 { get; set; }
        [StringLength(255)]
        public string Field15 { get; set; }
        [StringLength(255)]
        public string Field16 { get; set; }
        [StringLength(255)]
        public string Field17 { get; set; }
        [StringLength(255)]
        public string Field18 { get; set; }
        [StringLength(255)]
        public string Field19 { get; set; }
        [StringLength(255)]
        public string Field20 { get; set; }
        [StringLength(255)]
        public string Field21 { get; set; }
        [StringLength(255)]
        public string Field22 { get; set; }
        [StringLength(255)]
        public string Field23 { get; set; }
        [StringLength(255)]
        public string Field24 { get; set; }
        [StringLength(255)]
        public string Field25 { get; set; }
        [StringLength(255)]
        public string Field26 { get; set; }
        [StringLength(255)]
        public string Field27 { get; set; }
        [StringLength(255)]
        public string Field28 { get; set; }
        [StringLength(255)]
        public string Field29 { get; set; }
        [StringLength(255)]
        public string Field30 { get; set; }
        [StringLength(255)]
        public string Field31 { get; set; }
        [StringLength(255)]
        public string Field32 { get; set; }
        [StringLength(255)]
        public string Field33 { get; set; }
        [StringLength(255)]
        public string Field34 { get; set; }
        [StringLength(255)]
        public string Field35 { get; set; }
        [StringLength(255)]
        public string Field36 { get; set; }
        [StringLength(255)]
        public string Field37 { get; set; }
        [StringLength(255)]
        public string Field38 { get; set; }
        [StringLength(255)]
        public string Field39 { get; set; }
        [StringLength(255)]
        public string Field40 { get; set; }
        [StringLength(255)]
        public string Field41 { get; set; }
        [StringLength(255)]
        public string Field42 { get; set; }
        [StringLength(255)]
        public string Field43 { get; set; }
        [StringLength(255)]
        public string Field44 { get; set; }
        [StringLength(255)]
        public string Field45 { get; set; }
        [StringLength(255)]
        public string Field46 { get; set; }
        [StringLength(255)]
        public string Field47 { get; set; }
        [StringLength(255)]
        public string Field48 { get; set; }
        [StringLength(255)]
        public string Field49 { get; set; }
        [StringLength(255)]
        public string Field50 { get; set; }
        [StringLength(50)]
        public string Attachment { get; set; }
        [StringLength(1024)]
        public string RejectedReason { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }
        public bool Processed { get; set; }
        public int? PaymentId { get; set; }
        public int? PaymentLineId { get; set; }

        [ForeignKey(nameof(PaymentId))]
        [InverseProperty(nameof(DomesticClearingPayment.DomesticClearingBulkPaymentDetails))]
        public virtual DomesticClearingPayment Payment { get; set; }
        [ForeignKey(nameof(PaymentLineId))]
        [InverseProperty(nameof(DomesticClearingPaymentLine.DomesticClearingBulkPaymentDetails))]
        public virtual DomesticClearingPaymentLine PaymentLine { get; set; }
    }
}
