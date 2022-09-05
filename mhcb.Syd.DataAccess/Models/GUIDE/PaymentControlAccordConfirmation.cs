using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("PaymentControl_AccordConfirmation")]
    public partial class PaymentControlAccordConfirmation
    {
        [Key]
        public int AccordConfirmationId { get; set; }
        [StringLength(255)]
        public string Entity { get; set; }
        [StringLength(255)]
        public string UserStatus { get; set; }
        [StringLength(255)]
        public string LockedBy { get; set; }
        [StringLength(255)]
        public string TaggedTo { get; set; }
        [StringLength(255)]
        public string Direction { get; set; }
        [Required]
        [Column("A20SendersReference")]
        [StringLength(255)]
        public string A20sendersReference { get; set; }
        [StringLength(255)]
        public string Counterparty { get; set; }
        [StringLength(255)]
        public string DealStatus { get; set; }
        [StringLength(255)]
        public string NumberOfPairs { get; set; }
        [StringLength(255)]
        public string ErrorWarning { get; set; }
        [Column("B30TTradeDate", TypeName = "datetime")]
        public DateTime? B30ttradeDate { get; set; }
        [Column("B30VValueDate", TypeName = "datetime")]
        public DateTime? B30vvalueDate { get; set; }
        [Column("B132BBoughtAmt", TypeName = "decimal(19, 4)")]
        public decimal? B132bboughtAmt { get; set; }
        [Column("B132BBoughtCcy")]
        [StringLength(255)]
        public string B132bboughtCcy { get; set; }
        [Column("B233BSoldAmt", TypeName = "decimal(19, 4)")]
        public decimal? B233bsoldAmt { get; set; }
        [Column("B233BSoldCcy")]
        [StringLength(255)]
        public string B233bsoldCcy { get; set; }
        [Column("A22AOperationType")]
        [StringLength(255)]
        public string A22aoperationType { get; set; }
        [Column("B36ExchangeRate", TypeName = "decimal(19, 4)")]
        public decimal? B36exchangeRate { get; set; }
        [Column("A94AOperationScope")]
        [StringLength(255)]
        public string A94aoperationScope { get; set; }
        [Column("A82APartyA")]
        [StringLength(255)]
        public string A82apartyA { get; set; }
        [Column("A87APartyB")]
        [StringLength(255)]
        public string A87apartyB { get; set; }
        [StringLength(255)]
        public string ThirdParty { get; set; }
        [StringLength(255)]
        public string ManuallyMatched { get; set; }
        [StringLength(255)]
        public string Note { get; set; }
        [StringLength(255)]
        public string ItemStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ArchivalDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DealStatusDate { get; set; }
        [StringLength(255)]
        public string CounterpartyReport { get; set; }
        [StringLength(255)]
        public string LastInChain { get; set; }
        [StringLength(255)]
        public string ConfirmationType { get; set; }
        [StringLength(255)]
        public string NumberOfLinks { get; set; }
        [StringLength(255)]
        public string ThirdPartyStatus { get; set; }
        [StringLength(255)]
        public string IsLocked { get; set; }
        [StringLength(255)]
        public string IsTagged { get; set; }
        [StringLength(255)]
        public string MatchingComments { get; set; }
        [Column("CounterpartyTRN")]
        [StringLength(255)]
        public string CounterpartyTrn { get; set; }
        [Column("CounterpartyBIC")]
        [StringLength(255)]
        public string CounterpartyBic { get; set; }
        [Column("A83Funds")]
        [StringLength(255)]
        public string A83funds { get; set; }
        [Column("B153DeliveryAgent")]
        [StringLength(255)]
        public string B153deliveryAgent { get; set; }
        [Column("B156Intermediary")]
        [StringLength(255)]
        public string B156intermediary { get; set; }
        [Column("B157ReceivingAgent")]
        [StringLength(255)]
        public string B157receivingAgent { get; set; }
        [Column("B253DeliveryAgent")]
        [StringLength(255)]
        public string B253deliveryAgent { get; set; }
        [Column("B256Intermediary")]
        [StringLength(255)]
        public string B256intermediary { get; set; }
        [Column("B257ReceivingAgent")]
        [StringLength(255)]
        public string B257receivingAgent { get; set; }
        [Column("B258Beneficiary")]
        [StringLength(255)]
        public string B258beneficiary { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DealChangeDate { get; set; }
        [StringLength(255)]
        public string NumberOfChasersSent { get; set; }
        [StringLength(255)]
        public string TypeOfLinks { get; set; }
        [Column("FirstUTINamespace")]
        [StringLength(255)]
        public string FirstUtinamespace { get; set; }
        [StringLength(255)]
        public string FirstTransactionId { get; set; }
        [Column("CounterpartyFirstUTINamespace")]
        [StringLength(255)]
        public string CounterpartyFirstUtinamespace { get; set; }
        [StringLength(255)]
        public string CounterpartyFirstTransactionId { get; set; }
        public bool Processed { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        public int? PaymentId { get; set; }
        [StringLength(255)]
        public string UpdatedWho { get; set; }
        [Column("B30PMaturityDate", TypeName = "datetime")]
        public DateTime? B30pmaturityDate { get; set; }
        [Column("B32BPrincipalCcy")]
        [StringLength(255)]
        public string B32bprincipalCcy { get; set; }
        [Column("B32BPrincipalAmount", TypeName = "decimal(19, 4)")]
        public decimal? B32bprincipalAmount { get; set; }
        [Column("B34EInterestAmount", TypeName = "decimal(19, 4)")]
        public decimal? B34einterestAmount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }
        [Column("B17RPartyAsRole")]
        [StringLength(255)]
        public string B17rpartyAsRole { get; set; }
        [Column("A22BTypeOfEvent")]
        [StringLength(255)]
        public string A22btypeOfEvent { get; set; }
        [Column("B37GInterestRate", TypeName = "decimal(19, 4)")]
        public decimal? B37ginterestRate { get; set; }
        [Column("A21NContractNumber")]
        [StringLength(255)]
        public string A21ncontractNumber { get; set; }
        [Column("B32HSettlementAmount")]
        [StringLength(255)]
        public string B32hsettlementAmount { get; set; }
        [Column("C56IntermediaryPartyA")]
        [StringLength(255)]
        public string C56intermediaryPartyA { get; set; }
        [Column("C57ReceivingAgentPartyA")]
        [StringLength(255)]
        public string C57receivingAgentPartyA { get; set; }
        [Column("D56IntermediaryPartyB")]
        [StringLength(255)]
        public string D56intermediaryPartyB { get; set; }
        [Column("D57ReceivingAgentPartyB")]
        [StringLength(255)]
        public string D57receivingAgentPartyB { get; set; }
        [Column("E56IntermediaryInterestPartyA")]
        [StringLength(255)]
        public string E56intermediaryInterestPartyA { get; set; }
        [Column("E57ReceivingAgentInterestPartyA")]
        [StringLength(255)]
        public string E57receivingAgentInterestPartyA { get; set; }
        [Column("F56IntermediaryInterestPartyB")]
        [StringLength(255)]
        public string F56intermediaryInterestPartyB { get; set; }
        [Column("F57ReceivingAgentInterestPartyB")]
        [StringLength(255)]
        public string F57receivingAgentInterestPartyB { get; set; }
        [Column("B30XNextInterestDate", TypeName = "datetime")]
        public DateTime? B30xnextInterestDate { get; set; }

        [ForeignKey(nameof(PaymentId))]
        [InverseProperty(nameof(PaymentControlPayment.PaymentControlAccordConfirmations))]
        public virtual PaymentControlPayment Payment { get; set; }
    }
}
