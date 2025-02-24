using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Rec_Collection", Schema = "dbo")]
    public partial class DomesticClearingRecCollection
    {
        public DomesticClearingRecCollection()
        {
            DomesticClearingRecCollateGos = new HashSet<DomesticClearingRecCollateGo>();
            DomesticClearingRecCollateInwardClearings = new HashSet<DomesticClearingRecCollateInwardClearing>();
            DomesticClearingRecCollatePaymentCreations = new HashSet<DomesticClearingRecCollatePaymentCreation>();
            DomesticClearingRecCollatePayments = new HashSet<DomesticClearingRecCollatePayment>();
            DomesticClearingRecCollectGoEuconDemandLogAccounts = new HashSet<DomesticClearingRecCollectGoEuconDemandLogAccount>();
            DomesticClearingRecCollectGoEuconDemandLogCommons = new HashSet<DomesticClearingRecCollectGoEuconDemandLogCommon>();
            DomesticClearingRecCollectGoGasGoCredits = new HashSet<DomesticClearingRecCollectGoGasGoCredit>();
            DomesticClearingRecCollectGoGasGoDebits = new HashSet<DomesticClearingRecCollectGoGasGoDebit>();
            DomesticClearingRecCollectGoGopostings = new HashSet<DomesticClearingRecCollectGoGoposting>();
            DomesticClearingRecCollectInwardClearingAnzSummaries = new HashSet<DomesticClearingRecCollectInwardClearingAnzSummary>();
            DomesticClearingRecCollectInwardClearingPayments = new HashSet<DomesticClearingRecCollectInwardClearingPayment>();
            DomesticClearingRecCollectPaymentBulkPaymentSummaries = new HashSet<DomesticClearingRecCollectPaymentBulkPaymentSummary>();
            DomesticClearingRecCollectPaymentCreationBulkPaymentSummaries = new HashSet<DomesticClearingRecCollectPaymentCreationBulkPaymentSummary>();
            DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionAttachments = new HashSet<DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionAttachment>();
            DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionDetails = new HashSet<DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionDetail>();
            DomesticClearingRecCollectPaymentCreationPayments = new HashSet<DomesticClearingRecCollectPaymentCreationPayment>();
            DomesticClearingRecCollectPaymentDereplyDetails = new HashSet<DomesticClearingRecCollectPaymentDereplyDetail>();
            DomesticClearingRecCollectPaymentDereplyHeaders = new HashSet<DomesticClearingRecCollectPaymentDereplyHeader>();
            DomesticClearingRecCollectPaymentMultiPurposeInstructionAttachments = new HashSet<DomesticClearingRecCollectPaymentMultiPurposeInstructionAttachment>();
            DomesticClearingRecCollectPaymentMultiPurposeInstructionDetails = new HashSet<DomesticClearingRecCollectPaymentMultiPurposeInstructionDetail>();
            DomesticClearingRecCollectPaymentPayments = new HashSet<DomesticClearingRecCollectPaymentPayment>();
        }

        [Key]
        public int RecCollectionId { get; set; }
        public int RecSourceId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [ForeignKey("RecSourceId")]
        [InverseProperty("DomesticClearingRecCollections")]
        public virtual DomesticClearingRecSource RecSource { get; set; }
        [InverseProperty("RecCollection")]
        public virtual ICollection<DomesticClearingRecCollateGo> DomesticClearingRecCollateGos { get; set; }
        [InverseProperty("RecCollection")]
        public virtual ICollection<DomesticClearingRecCollateInwardClearing> DomesticClearingRecCollateInwardClearings { get; set; }
        [InverseProperty("RecCollection")]
        public virtual ICollection<DomesticClearingRecCollatePaymentCreation> DomesticClearingRecCollatePaymentCreations { get; set; }
        [InverseProperty("RecCollection")]
        public virtual ICollection<DomesticClearingRecCollatePayment> DomesticClearingRecCollatePayments { get; set; }
        [InverseProperty("RecCollection")]
        public virtual ICollection<DomesticClearingRecCollectGoEuconDemandLogAccount> DomesticClearingRecCollectGoEuconDemandLogAccounts { get; set; }
        [InverseProperty("RecCollection")]
        public virtual ICollection<DomesticClearingRecCollectGoEuconDemandLogCommon> DomesticClearingRecCollectGoEuconDemandLogCommons { get; set; }
        [InverseProperty("RecCollection")]
        public virtual ICollection<DomesticClearingRecCollectGoGasGoCredit> DomesticClearingRecCollectGoGasGoCredits { get; set; }
        [InverseProperty("RecCollection")]
        public virtual ICollection<DomesticClearingRecCollectGoGasGoDebit> DomesticClearingRecCollectGoGasGoDebits { get; set; }
        [InverseProperty("RecCollection")]
        public virtual ICollection<DomesticClearingRecCollectGoGoposting> DomesticClearingRecCollectGoGopostings { get; set; }
        [InverseProperty("RecCollection")]
        public virtual ICollection<DomesticClearingRecCollectInwardClearingAnzSummary> DomesticClearingRecCollectInwardClearingAnzSummaries { get; set; }
        [InverseProperty("RecCollection")]
        public virtual ICollection<DomesticClearingRecCollectInwardClearingPayment> DomesticClearingRecCollectInwardClearingPayments { get; set; }
        [InverseProperty("RecCollection")]
        public virtual ICollection<DomesticClearingRecCollectPaymentBulkPaymentSummary> DomesticClearingRecCollectPaymentBulkPaymentSummaries { get; set; }
        [InverseProperty("RecCollection")]
        public virtual ICollection<DomesticClearingRecCollectPaymentCreationBulkPaymentSummary> DomesticClearingRecCollectPaymentCreationBulkPaymentSummaries { get; set; }
        [InverseProperty("RecCollection")]
        public virtual ICollection<DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionAttachment> DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionAttachments { get; set; }
        [InverseProperty("RecCollection")]
        public virtual ICollection<DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionDetail> DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionDetails { get; set; }
        [InverseProperty("RecCollection")]
        public virtual ICollection<DomesticClearingRecCollectPaymentCreationPayment> DomesticClearingRecCollectPaymentCreationPayments { get; set; }
        [InverseProperty("RecCollection")]
        public virtual ICollection<DomesticClearingRecCollectPaymentDereplyDetail> DomesticClearingRecCollectPaymentDereplyDetails { get; set; }
        [InverseProperty("RecCollection")]
        public virtual ICollection<DomesticClearingRecCollectPaymentDereplyHeader> DomesticClearingRecCollectPaymentDereplyHeaders { get; set; }
        [InverseProperty("RecCollection")]
        public virtual ICollection<DomesticClearingRecCollectPaymentMultiPurposeInstructionAttachment> DomesticClearingRecCollectPaymentMultiPurposeInstructionAttachments { get; set; }
        [InverseProperty("RecCollection")]
        public virtual ICollection<DomesticClearingRecCollectPaymentMultiPurposeInstructionDetail> DomesticClearingRecCollectPaymentMultiPurposeInstructionDetails { get; set; }
        [InverseProperty("RecCollection")]
        public virtual ICollection<DomesticClearingRecCollectPaymentPayment> DomesticClearingRecCollectPaymentPayments { get; set; }
    }
}
