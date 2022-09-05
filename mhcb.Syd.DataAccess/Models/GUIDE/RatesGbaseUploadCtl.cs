using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("RATES_GBASE_UPLOAD_CTL")]
    public partial class RatesGbaseUploadCtl
    {
        [Key]
        [Column("RATE_TYPE")]
        [StringLength(16)]
        public string RateType { get; set; }
        [Key]
        [Column("OPR_DATE", TypeName = "datetime")]
        public DateTime OprDate { get; set; }
        [Key]
        [Column("CCY")]
        [StringLength(4)]
        public string Ccy { get; set; }
        [Column("UPLOADED_BY")]
        [StringLength(8)]
        public string UploadedBy { get; set; }
        [Column("ACU_STATUS")]
        [StringLength(1)]
        public string AcuStatus { get; set; }
        [Column("BU_STATUS")]
        [StringLength(1)]
        public string BuStatus { get; set; }
        [Column("GBASE_MSG")]
        [StringLength(100)]
        public string GbaseMsg { get; set; }
        [Column("ACU_TRANS_STATUS")]
        [StringLength(1)]
        public string AcuTransStatus { get; set; }
        [Column("BU_TRANS_STATUS")]
        [StringLength(1)]
        public string BuTransStatus { get; set; }
    }
}
