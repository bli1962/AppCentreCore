using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EDocument
{
    [Index(nameof(ReferenceNumber), Name = "IX_MoneyMarketConfirmations")]
    public partial class MoneyMarketConfirmation
    {
        [Key]
        public int Id { get; set; }
        [Column("gBaseDocumentId")]
        public int GBaseDocumentId { get; set; }
        [Required]
        [StringLength(250)]
        public string CompanyName { get; set; }
        [Required]
        [StringLength(250)]
        public string CompanyAddress { get; set; }
        [StringLength(250)]
        public string ContractDate { get; set; }
        [Required]
        [StringLength(250)]
        public string ReferenceNumber { get; set; }
        [StringLength(250)]
        public string ValueDate { get; set; }
        [StringLength(250)]
        public string DueDate { get; set; }
        [StringLength(250)]
        public string Rate { get; set; }
        [StringLength(250)]
        public string OldRate { get; set; }
        [StringLength(250)]
        public string PrincipalAmount { get; set; }
        [StringLength(250)]
        public string IncreaseDecrease { get; set; }
        [StringLength(250)]
        public string ClosingBalance { get; set; }
        [Column("MHCBPayTo", TypeName = "text")]
        public string MhcbpayTo { get; set; }
        [Column(TypeName = "text")]
        public string CustomerPayTo { get; set; }
        [Required]
        [StringLength(250)]
        public string Broker { get; set; }
        [StringLength(250)]
        public string Remarks { get; set; }
        [StringLength(250)]
        public string Days { get; set; }
        [Required]
        [StringLength(250)]
        public string OperationDate { get; set; }
        [Required]
        [StringLength(250)]
        public string TransactionNumber { get; set; }
        [Required]
        [StringLength(250)]
        public string Operator { get; set; }
        [StringLength(200)]
        public string MurexEvent { get; set; }
        [StringLength(300)]
        public string MurexGenerator { get; set; }

        [ForeignKey(nameof(GBaseDocumentId))]
        [InverseProperty("MoneyMarketConfirmations")]
        public virtual GBaseDocument GBaseDocument { get; set; }
    }
}
