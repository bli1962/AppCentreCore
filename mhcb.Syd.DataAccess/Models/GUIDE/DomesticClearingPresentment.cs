using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Presentment")]
    public partial class DomesticClearingPresentment
    {
        [Key]
        public int PresentmentId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TransmissionDate { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? Amount { get; set; }
        [StringLength(50)]
        public string DrawerAccountNo { get; set; }
        [Column("BSBLedgerFI")]
        [StringLength(50)]
        public string BsbledgerFi { get; set; }
        [Column("BSBCapturingFI")]
        [StringLength(50)]
        public string BsbcapturingFi { get; set; }
        [Column("BSBCollectingFI")]
        [StringLength(50)]
        public string BsbcollectingFi { get; set; }
        [StringLength(50)]
        public string TransactionIdentifier { get; set; }
        [StringLength(50)]
        public string AuxillaryDomestic { get; set; }
        public bool Processed { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedWhen { get; set; }
        public int? PaymentId { get; set; }
        [StringLength(1024)]
        public string Filename { get; set; }
        [StringLength(50)]
        public string BsbDepositorsNominatedFi { get; set; }
        [StringLength(50)]
        public string DepositorNominatedAccountNumber { get; set; }
        [StringLength(50)]
        public string ExtraAuxiliaryDomestic { get; set; }
        [StringLength(50)]
        public string CaptureDeviceIdentifier { get; set; }
        [StringLength(50)]
        public string VoucherIndicator { get; set; }
        [StringLength(50)]
        public string ManualRepair { get; set; }
        [StringLength(3)]
        public string TransactionCode { get; set; }
        [Column("BSBSendingFI")]
        [StringLength(50)]
        public string BsbsendingFi { get; set; }
        [Column("BSBReceivingFI")]
        [StringLength(50)]
        public string BsbreceivingFi { get; set; }

        [ForeignKey(nameof(PaymentId))]
        [InverseProperty(nameof(DomesticClearingPayment.DomesticClearingPresentments))]
        public virtual DomesticClearingPayment Payment { get; set; }
    }
}
