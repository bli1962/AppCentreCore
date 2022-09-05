using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("FXFArbitrage")]
    [Index(nameof(SchemeNo), Name = "IX_FXFArbitrage_SCHEMENO", IsUnique = true)]
    public partial class Fxfarbitrage
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(6)]
        public string SchemeNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? Contractdate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ValueDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DueDate { get; set; }
        [StringLength(50)]
        public string Remarks { get; set; }
        [Column("TakePrinCCY")]
        [StringLength(3)]
        public string TakePrinCcy { get; set; }
        public double? TakePrinAmt { get; set; }
        public double? TakeIntRate { get; set; }
        public double? TakeIntAmount { get; set; }
        [Column("TakeDaysAYear")]
        public short? TakeDaysAyear { get; set; }
        [Column("LendPrinCCY")]
        [StringLength(3)]
        public string LendPrinCcy { get; set; }
        public double? LendPrinAmt { get; set; }
        public double? LendIntRate { get; set; }
        public double? LendIntAmount { get; set; }
        [Column("LendDaysAYear")]
        public short? LendDaysAyear { get; set; }
        [Column("SpotBghCCY")]
        [StringLength(3)]
        public string SpotBghCcy { get; set; }
        public double? SpotBghAmt { get; set; }
        public double? SpotExRate { get; set; }
        [Column("SpotSoldCCY")]
        [StringLength(3)]
        public string SpotSoldCcy { get; set; }
        public double? SpotSoldAmt { get; set; }
        [Column("FWDBghCCY")]
        [StringLength(3)]
        public string FwdbghCcy { get; set; }
        [Column("FWDBghAmt")]
        public double? FwdbghAmt { get; set; }
        [Column("FWDExRate")]
        public double? FwdexRate { get; set; }
        [Column("FWDSoldCCY")]
        [StringLength(3)]
        public string FwdsoldCcy { get; set; }
        [Column("FWDSoldAmt")]
        public double? FwdsoldAmt { get; set; }
        [Column("IFwdBghCCY")]
        [StringLength(3)]
        public string IfwdBghCcy { get; set; }
        [Column("IFwdBghAmt")]
        public double? IfwdBghAmt { get; set; }
        [Column("IFwdExRate")]
        public double? IfwdExRate { get; set; }
        [Column("IFwdSoldCCY")]
        [StringLength(3)]
        public string IfwdSoldCcy { get; set; }
        [Column("IFwdSoldAmt")]
        public double? IfwdSoldAmt { get; set; }
        [Column("IBF")]
        [StringLength(3)]
        public string Ibf { get; set; }
        public byte Upload { get; set; }
        [Column("PRINTED")]
        public bool Printed { get; set; }
        [Column("PRINTDATE", TypeName = "smalldatetime")]
        public DateTime? Printdate { get; set; }
        [Column("PRINTTIME", TypeName = "smalldatetime")]
        public DateTime? Printtime { get; set; }
        [StringLength(4)]
        public string FixedCurrency { get; set; }
    }
}
