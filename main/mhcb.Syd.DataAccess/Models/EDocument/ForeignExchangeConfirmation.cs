using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EDocument
{
    public partial class ForeignExchangeConfirmation
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
        public string OurPurchaseAmount { get; set; }
        [StringLength(250)]
        public string OurPurchaseRate { get; set; }
        [StringLength(250)]
        public string OurSaleAmount { get; set; }
        [StringLength(10)]
        public string OurSaleDeliveryDate { get; set; }
        [StringLength(10)]
        public string OurDueDate { get; set; }
        [Column(TypeName = "text")]
        public string PleasePayTo { get; set; }
        [Column(TypeName = "text")]
        public string WeWillPayTo { get; set; }
        [Required]
        [StringLength(250)]
        public string Broker { get; set; }
        [StringLength(250)]
        public string Remarks { get; set; }
        [Required]
        [StringLength(250)]
        public string OperationDate { get; set; }
        [Required]
        [StringLength(250)]
        public string TransactionNumber { get; set; }
        [Required]
        [StringLength(250)]
        public string Operator { get; set; }

        [ForeignKey(nameof(GBaseDocumentId))]
        [InverseProperty("ForeignExchangeConfirmations")]
        public virtual GBaseDocument GBaseDocument { get; set; }
    }
}
