using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("RATES_GBASE_UPLOAD_CTL", Schema = "dbo")]
    public partial class RatesGbaseUploadCtl
    {
        [Key]
        [Column("RATE_TYPE")]
        [StringLength(16)]
        [Unicode(false)]
        public string RateType { get; set; }
        [Key]
        [Column("OPR_DATE", TypeName = "datetime")]
        public DateTime OprDate { get; set; }
        [Key]
        [Column("CCY")]
        [StringLength(4)]
        [Unicode(false)]
        public string Ccy { get; set; }
        [Required]
        [Column("UPLOADED_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string UploadedBy { get; set; }
        [Column("ACU_STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string AcuStatus { get; set; }
        [Column("BU_STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string BuStatus { get; set; }
        [Required]
        [Column("GBASE_MSG")]
        [StringLength(100)]
        [Unicode(false)]
        public string GbaseMsg { get; set; }
        [Column("ACU_TRANS_STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string AcuTransStatus { get; set; }
        [Column("BU_TRANS_STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string BuTransStatus { get; set; }
    }

    public partial class RatesGbaseUploadCtl
    {
        [StringLength(50)]
        public string NavigatorLink { get; set; }
    }
}
