using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("TRANCHE_MASTER")]
    public partial class TrancheMaster
    {
        public TrancheMaster()
        {
            TrancheContents = new HashSet<TrancheContent>();
            TrancheGuarantees = new HashSet<TrancheGuarantee>();
            TrancheMargins = new HashSet<TrancheMargin>();
        }

        [Key]
        [Column("TRANCHE_NO")]
        public int TrancheNo { get; set; }
        [Column("LOAN_NO")]
        public int? LoanNo { get; set; }
        [Column("TRANCHE_TYPE")]
        [StringLength(16)]
        public string TrancheType { get; set; }
        [Column("TRANCHE_NAME")]
        [StringLength(5)]
        public string TrancheName { get; set; }
        [Column("PROD_TYPE1")]
        public short? ProdType1 { get; set; }
        [Column("PROD_TYPE5")]
        public short? ProdType5 { get; set; }
        [Column("APPLN_NO")]
        [StringLength(11)]
        public string ApplnNo { get; set; }
        [Column("APPLN_DATE", TypeName = "datetime")]
        public DateTime? ApplnDate { get; set; }
        [Column("HO_APPR_DATE", TypeName = "datetime")]
        public DateTime? HoApprDate { get; set; }
        [Column("APPLN_NO_RELT")]
        [StringLength(11)]
        public string ApplnNoRelt { get; set; }
        [Column("APPLN_DATE_RELT", TypeName = "datetime")]
        public DateTime? ApplnDateRelt { get; set; }
        [Column("BASE_CCY")]
        [StringLength(3)]
        public string BaseCcy { get; set; }
        [Column("MULTI_CCY")]
        public bool? MultiCcy { get; set; }
        [Column("TRANCHE_PORTION", TypeName = "decimal(38, 2)")]
        public decimal? TranchePortion { get; set; }
        [Column("SYND_PORTION", TypeName = "decimal(38, 2)")]
        public decimal? SyndPortion { get; set; }
        [Column("PORTION_NOTES")]
        [StringLength(200)]
        public string PortionNotes { get; set; }
        [Column("AVAIL_START", TypeName = "datetime")]
        public DateTime? AvailStart { get; set; }
        [Column("AVAIL_END", TypeName = "datetime")]
        public DateTime? AvailEnd { get; set; }
        [Column("PERIOD_NOTES")]
        [StringLength(100)]
        public string PeriodNotes { get; set; }
        [Column("MAT_DATE", TypeName = "datetime")]
        public DateTime? MatDate { get; set; }
        [Column("MAT_DATE_NOTES")]
        [StringLength(100)]
        public string MatDateNotes { get; set; }
        [Column("MIN_DD")]
        [StringLength(200)]
        public string MinDd { get; set; }
        [Column("MULTIPLE")]
        [StringLength(200)]
        public string Multiple { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("PROC_BY")]
        [StringLength(6)]
        public string ProcBy { get; set; }
        [Column("PROC_ON", TypeName = "datetime")]
        public DateTime? ProcOn { get; set; }
        [Column("APPR_BY")]
        [StringLength(6)]
        public string ApprBy { get; set; }
        [Column("APPR_ON", TypeName = "datetime")]
        public DateTime? ApprOn { get; set; }
        [Required]
        [Column("MULTI_CCY_DESC")]
        [StringLength(64)]
        public string MultiCcyDesc { get; set; }
        [Column("MAXI_DRAWDOWN_PERIOD")]
        public short MaxiDrawdownPeriod { get; set; }
        [Column("MAXI_DRAWDOWN_DAYS")]
        public short MaxiDrawdownDays { get; set; }
        [Column("MAXI_DRAWDOWN_TIMES")]
        public short MaxiDrawdownTimes { get; set; }
        [Column("SILENT_MARGIN")]
        public bool SilentMargin { get; set; }
        [Required]
        [Column("TRD_INTERNAL_RATE")]
        [StringLength(50)]
        public string TrdInternalRate { get; set; }
        [Required]
        [Column("CFD_BASE_RATE")]
        [StringLength(50)]
        public string CfdBaseRate { get; set; }
        [Required]
        [Column("MARGIN_11AM")]
        [StringLength(100)]
        public string Margin11am { get; set; }
        [Required]
        [Column("MARGIN_REMARK_11AM")]
        [StringLength(100)]
        public string MarginRemark11am { get; set; }
        [Column("RATING_TYPE")]
        public bool RatingType { get; set; }
        [Column("RATIIO_TYPE")]
        public bool RatiioType { get; set; }
        [Required]
        [Column("FINANCIAL_NAME")]
        [StringLength(50)]
        public string FinancialName { get; set; }

        [ForeignKey(nameof(LoanNo))]
        [InverseProperty(nameof(LoanMaster.TrancheMasters))]
        public virtual LoanMaster LoanNoNavigation { get; set; }
        [ForeignKey(nameof(TrancheType))]
        [InverseProperty("TrancheMasters")]
        public virtual TrancheType TrancheTypeNavigation { get; set; }
        [InverseProperty(nameof(TrancheContent.TrancheNoNavigation))]
        public virtual ICollection<TrancheContent> TrancheContents { get; set; }
        [InverseProperty(nameof(TrancheGuarantee.TrancheNoNavigation))]
        public virtual ICollection<TrancheGuarantee> TrancheGuarantees { get; set; }
        [InverseProperty(nameof(TrancheMargin.TrancheNoNavigation))]
        public virtual ICollection<TrancheMargin> TrancheMargins { get; set; }
    }
}
