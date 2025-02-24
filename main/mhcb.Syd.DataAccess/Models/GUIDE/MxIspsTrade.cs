using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MxIspsTrade", Schema = "dbo")]
    public partial class MxIspsTrade
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreateDate { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime StatusUpdateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeleteDate { get; set; }
        [StringLength(128)]
        [Unicode(false)]
        public string DeleteBy { get; set; }
        [Column("ExtractID")]
        public int ExtractId { get; set; }
        [Unicode(false)]
        public string TransformationMessage { get; set; }
        public int EventId { get; set; }
        [Required]
        [StringLength(20)]
        [Unicode(false)]
        public string Category { get; set; }
        [Required]
        [StringLength(20)]
        [Unicode(false)]
        public string EventType { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string TradeType { get; set; }
        [Required]
        [Column("REFNO")]
        [Unicode(false)]
        public string Refno { get; set; }
        [Required]
        [Unicode(false)]
        public string InitialApp { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Instrument { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Payout { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string Currency { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string Nominal { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string TradeDate { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string StartDate { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string MaturityDate { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string SalesMargin { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string FacilityEndDate { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Counterparty { get; set; }
        [StringLength(1000)]
        [Unicode(false)]
        public string Comments { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string TraderName { get; set; }
        [Column("OSP_Status")]
        [StringLength(50)]
        [Unicode(false)]
        public string OspStatus { get; set; }
    }
}
