﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    public partial class ViewMmTicketDetail
    {
        [Column("MMTicketId")]
        [StringLength(25)]
        [Unicode(false)]
        public string MmticketId { get; set; }
        [Required]
        [StringLength(30)]
        [Unicode(false)]
        public string TicketTemplate { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string LegalEntity { get; set; }
        [Required]
        [StringLength(30)]
        [Unicode(false)]
        public string Event { get; set; }
        [Required]
        [StringLength(20)]
        [Unicode(false)]
        public string Typology { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string CounterpartyShortName { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string CounterpartyDescription { get; set; }
        [Required]
        [StringLength(30)]
        [Unicode(false)]
        public string MurexTradeId { get; set; }
        [Required]
        [StringLength(30)]
        [Unicode(false)]
        public string PortfolioGroup { get; set; }
        [Required]
        [StringLength(30)]
        [Unicode(false)]
        public string PortfolioDesk { get; set; }
        [Required]
        [StringLength(30)]
        [Unicode(false)]
        public string PortfolioBook { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime OperationDate { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string DealingMethod { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string DealingContact { get; set; }
        [Column("GBaseRefNo")]
        [StringLength(20)]
        [Unicode(false)]
        public string GbaseRefNo { get; set; }
        [Column("IBF")]
        [StringLength(1)]
        [Unicode(false)]
        public string Ibf { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string CounterpartyAbbreviation { get; set; }
        public int DivisionCode { get; set; }
        public int? Discount { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string SchemeNumber { get; set; }
        [Required]
        [StringLength(30)]
        [Unicode(false)]
        public string Authorised { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string Currency { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? PrincipalAmount { get; set; }
        public int? RolloverNumber { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string RateConvention { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ValueDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FinalDueDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DueDate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Broker { get; set; }
        public int? TermDays { get; set; }
        public int? RateType { get; set; }
        [Column(TypeName = "decimal(15, 8)")]
        public decimal? InterestRate { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? InterestAmount { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string FundType { get; set; }
        [Column(TypeName = "decimal(15, 8)")]
        public decimal? InternalRate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string InterestSet { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string InterestSetLabel { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string WithholdingTaxBearer { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string WithholdingTaxBearerLabel { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string WithholdingTaxCode { get; set; }
        [Column(TypeName = "decimal(15, 8)")]
        public decimal? WithholdingTaxRate { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? WithholdingTaxAmount { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Remarks { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string FrontOfficeInputBy { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string FrontOfficeAuthorisedBy { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ContractDate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string SettlementDetails { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? NetInterest { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? TotalDue { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? Brokerage { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? PrincipalAmountPrevious { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string RolloverType { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string RolloverTypeLabel { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? PrincipalAmountClosing { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string SettlementDirectionLabel { get; set; }
        [Column(TypeName = "decimal(15, 8)")]
        public decimal? Denomination { get; set; }
        [Column(TypeName = "decimal(16, 4)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? FaceAmount { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? ConsiderationAmount { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Issuer { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string IssuerFullName { get; set; }
        [Column("IssuerGBaseAbbreviation")]
        [StringLength(50)]
        [Unicode(false)]
        public string IssuerGbaseAbbreviation { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? Yield { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? IssuePrice { get; set; }
        public int ContractVersion { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string CustomerCode { get; set; }
        public bool PrintStatus { get; set; }
        [Required]
        [StringLength(20)]
        [Unicode(false)]
        public string PayoutType { get; set; }
        [Required]
        [StringLength(10)]
        [Unicode(false)]
        public string BuySell { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TicketCreatedTimestamp { get; set; }
        [Column(TypeName = "date")]
        public DateTime? TradeDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PaymentDate { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string Nature { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Instrument { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string TransactionStatus { get; set; }
        [StringLength(35)]
        [Unicode(false)]
        public string Addresse { get; set; }
        [StringLength(35)]
        [Unicode(false)]
        public string PartyIdentifier56 { get; set; }
        [Column("BIC56_1")]
        [StringLength(35)]
        [Unicode(false)]
        public string Bic561 { get; set; }
        [StringLength(35)]
        [Unicode(false)]
        public string PartyIdentifier57 { get; set; }
        [Column("FXALM_PartyIdentifier57")]
        [StringLength(35)]
        [Unicode(false)]
        public string FxalmPartyIdentifier57 { get; set; }
        [Column("BIC57_1")]
        [StringLength(35)]
        [Unicode(false)]
        public string Bic571 { get; set; }
        [Column("BIC57_2")]
        [StringLength(35)]
        [Unicode(false)]
        public string Bic572 { get; set; }
        [Column("BIC57_3")]
        [StringLength(35)]
        [Unicode(false)]
        public string Bic573 { get; set; }
        [Column("BIC57_4")]
        [StringLength(35)]
        [Unicode(false)]
        public string Bic574 { get; set; }
        [StringLength(35)]
        [Unicode(false)]
        public string PartyIdentifier58 { get; set; }
        [Column("FXALM_PartyIdentifier58")]
        [StringLength(35)]
        [Unicode(false)]
        public string FxalmPartyIdentifier58 { get; set; }
        [Column("BIC58_1")]
        [StringLength(35)]
        [Unicode(false)]
        public string Bic581 { get; set; }
        [StringLength(35)]
        [Unicode(false)]
        public string PartyIdentifier59 { get; set; }
        [Column("BIC59_1")]
        [StringLength(35)]
        [Unicode(false)]
        public string Bic591 { get; set; }
        [Column("BIC59_2")]
        [StringLength(35)]
        [Unicode(false)]
        public string Bic592 { get; set; }
        [Column("BIC59_3")]
        [StringLength(35)]
        [Unicode(false)]
        public string Bic593 { get; set; }
        [Column("BIC59_4")]
        [StringLength(35)]
        [Unicode(false)]
        public string Bic594 { get; set; }
        [Column("SpecialInstruction_1")]
        [StringLength(50)]
        [Unicode(false)]
        public string SpecialInstruction1 { get; set; }
        [Column("SpecialInstruction_2")]
        [StringLength(50)]
        [Unicode(false)]
        public string SpecialInstruction2 { get; set; }
        [Column("SpecialInstruction_3")]
        [StringLength(50)]
        [Unicode(false)]
        public string SpecialInstruction3 { get; set; }
        [Column("SpecialInstruction_4")]
        [StringLength(50)]
        [Unicode(false)]
        public string SpecialInstruction4 { get; set; }
        public int AdvancedNoticeDepo { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string MizuhoTicketProduct { get; set; }
        public bool? IsProduction { get; set; }
    }
}
