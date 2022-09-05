using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MoneyMarketTicket")]
    [Index(nameof(TicketCreatedTimestamp), Name = "NCI_MoneyMarketTicket_TimeCreatedTimestamp")]
    public partial class MoneyMarketTicket
    {
        [Key]
        [Column("MMTicketId")]
        public int MmticketId { get; set; }
        [Required]
        [StringLength(30)]
        public string TicketTemplate { get; set; }
        [Required]
        [StringLength(50)]
        public string LegalEntity { get; set; }
        [Required]
        [StringLength(30)]
        public string Event { get; set; }
        [Required]
        [StringLength(20)]
        public string Typology { get; set; }
        [Required]
        [StringLength(50)]
        public string CounterpartyShortName { get; set; }
        [Required]
        [StringLength(100)]
        public string CounterpartyDescription { get; set; }
        [Required]
        [StringLength(30)]
        public string MurexTradeId { get; set; }
        [Required]
        [StringLength(30)]
        public string PortfolioGroup { get; set; }
        [Required]
        [StringLength(30)]
        public string PortfolioDesk { get; set; }
        [Required]
        [StringLength(30)]
        public string PortfolioBook { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime OperationDate { get; set; }
        [StringLength(30)]
        public string DealingMethod { get; set; }
        [StringLength(50)]
        public string DealingContact { get; set; }
        [Column("GBaseRefNo")]
        [StringLength(20)]
        public string GbaseRefNo { get; set; }
        [Column("IBF")]
        [StringLength(1)]
        public string Ibf { get; set; }
        [Required]
        [StringLength(50)]
        public string CounterpartyAbbreviation { get; set; }
        public int DivisionCode { get; set; }
        public int? Discount { get; set; }
        [StringLength(20)]
        public string SchemeNumber { get; set; }
        [Required]
        [StringLength(30)]
        public string Authorised { get; set; }
        [StringLength(10)]
        public string Currency { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? PrincipalAmount { get; set; }
        public int? RolloverNumber { get; set; }
        [StringLength(30)]
        public string RateConvention { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ValueDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FinalDueDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DueDate { get; set; }
        [StringLength(50)]
        public string Broker { get; set; }
        [StringLength(50)]
        public string BrokerName { get; set; }
        public int? TermDays { get; set; }
        public int? RateType { get; set; }
        [Column(TypeName = "decimal(15, 8)")]
        public decimal? InterestRate { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? InterestAmount { get; set; }
        [StringLength(20)]
        public string FundType { get; set; }
        [Column(TypeName = "decimal(15, 8)")]
        public decimal? InternalRate { get; set; }
        [StringLength(50)]
        public string InterestSet { get; set; }
        [StringLength(50)]
        public string InterestSetLabel { get; set; }
        [StringLength(50)]
        public string WithholdingTaxBearer { get; set; }
        [StringLength(50)]
        public string WithholdingTaxBearerLabel { get; set; }
        [StringLength(10)]
        public string WithholdingTaxCode { get; set; }
        [Column(TypeName = "decimal(15, 8)")]
        public decimal? WithholdingTaxRate { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? WithholdingTaxAmount { get; set; }
        [StringLength(100)]
        public string Remarks { get; set; }
        [StringLength(50)]
        public string FrontOfficeInputBy { get; set; }
        [StringLength(50)]
        public string FrontOfficeAuthorisedBy { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ContractDate { get; set; }
        [StringLength(50)]
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
        public string RolloverType { get; set; }
        [StringLength(30)]
        public string RolloverTypeLabel { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? PrincipalAmountClosing { get; set; }
        [StringLength(10)]
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
        public string Issuer { get; set; }
        [StringLength(100)]
        public string IssuerFullName { get; set; }
        [Column("IssuerGBaseAbbreviation")]
        [StringLength(50)]
        public string IssuerGbaseAbbreviation { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? Yield { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? IssuePrice { get; set; }
        public int ContractVersion { get; set; }
        [Required]
        [StringLength(50)]
        public string CustomerCode { get; set; }
        public bool PrintStatus { get; set; }
        [Required]
        [StringLength(20)]
        public string PayoutType { get; set; }
        [Required]
        [StringLength(10)]
        public string BuySell { get; set; }
        [StringLength(20)]
        public string Nature { get; set; }
        [StringLength(100)]
        public string Instrument { get; set; }
        [Column(TypeName = "date")]
        public DateTime? TradeDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PaymentDate { get; set; }
        [StringLength(20)]
        public string TransactionStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TicketCreatedTimestamp { get; set; }
        [Column("GIDUpload")]
        public bool Gidupload { get; set; }

        [InverseProperty("Mmticket")]
        public virtual MoneyMarketTicketExt MoneyMarketTicketExt { get; set; }
    }
}
