using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_GOPosting")]
    public partial class DomesticClearingGoposting
    {
        public DomesticClearingGoposting()
        {
            DomesticClearingPaymentLineReturnFeePosts = new HashSet<DomesticClearingPaymentLine>();
            DomesticClearingPaymentLineReturnPosts = new HashSet<DomesticClearingPaymentLine>();
        }

        [Key]
        [Column("GOPostingId")]
        public int GopostingId { get; set; }
        [Required]
        [Column("GBaseRefNo")]
        [StringLength(20)]
        public string GbaseRefNo { get; set; }
        [StringLength(5)]
        public string TransNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ValueDate { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal Amount { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? Adjustment { get; set; }
        [StringLength(2)]
        public string CurrencyCode { get; set; }
        [Required]
        [StringLength(30)]
        public string Remark { get; set; }
        [StringLength(20)]
        public string DebitAccountCode { get; set; }
        [StringLength(20)]
        public string DebitAccountNo { get; set; }
        [StringLength(20)]
        public string CreditAccountCode { get; set; }
        [StringLength(20)]
        public string CreditAccountNo { get; set; }
        [StringLength(12)]
        public string DebitCustomerAbbreviation { get; set; }
        [StringLength(12)]
        public string CreditCustomerAbbreviation { get; set; }
        public int DirectionId { get; set; }
        [StringLength(18)]
        public string CreditMinNo { get; set; }
        [StringLength(18)]
        public string DebitMinNo { get; set; }
        public int? StatusId { get; set; }
        public int PostingTypeId { get; set; }
        [StringLength(50)]
        public string StatusIdUpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OperationDate { get; set; }
        public int? PaymentLineId { get; set; }
        [StringLength(3)]
        public string BranchNo { get; set; }
        [StringLength(2)]
        public string FileType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ProcessDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AvailableDate { get; set; }
        [StringLength(50)]
        public string ChequeNo { get; set; }
        [StringLength(1024)]
        public string GasDescription { get; set; }
        public int? PreviousStatusId { get; set; }

        [ForeignKey(nameof(DebitMinNo))]
        [InverseProperty(nameof(GasGoDebit.DomesticClearingGopostings))]
        public virtual GasGoDebit DebitMinNoNavigation { get; set; }
        [ForeignKey(nameof(DirectionId))]
        [InverseProperty(nameof(DomesticClearingDirection.DomesticClearingGopostings))]
        public virtual DomesticClearingDirection Direction { get; set; }
        [ForeignKey(nameof(PaymentLineId))]
        [InverseProperty(nameof(DomesticClearingPaymentLine.DomesticClearingGopostings))]
        public virtual DomesticClearingPaymentLine PaymentLine { get; set; }
        [ForeignKey(nameof(PostingTypeId))]
        [InverseProperty(nameof(DomesticClearingPostingType.DomesticClearingGopostings))]
        public virtual DomesticClearingPostingType PostingType { get; set; }
        [ForeignKey(nameof(StatusId))]
        [InverseProperty(nameof(DomesticClearingGasStatus.DomesticClearingGopostings))]
        public virtual DomesticClearingGasStatus Status { get; set; }
        [InverseProperty(nameof(DomesticClearingPayment.FeePost))]
        public virtual DomesticClearingPayment DomesticClearingPaymentFeePost { get; set; }
        [InverseProperty(nameof(DomesticClearingPayment.MainPost))]
        public virtual DomesticClearingPayment DomesticClearingPaymentMainPost { get; set; }
        [InverseProperty(nameof(DomesticClearingPaymentLine.ReturnFeePost))]
        public virtual ICollection<DomesticClearingPaymentLine> DomesticClearingPaymentLineReturnFeePosts { get; set; }
        [InverseProperty(nameof(DomesticClearingPaymentLine.ReturnPost))]
        public virtual ICollection<DomesticClearingPaymentLine> DomesticClearingPaymentLineReturnPosts { get; set; }
    }
}
