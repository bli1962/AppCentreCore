using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("RATES_GBASE_UPLOAD_CRITERIA", Schema = "dbo")]
    public partial class RatesGbaseUploadCriterion
    {
        [Key]
        [Column("RATE_TYPE")]
        [StringLength(16)]
        [Unicode(false)]
        public string RateType { get; set; }
        [Key]
        [Column("CCY")]
        [StringLength(4)]
        [Unicode(false)]
        public string Ccy { get; set; }
        [Column("CRITERIA_TYPE")]
        [StringLength(10)]
        [Unicode(false)]
        public string CriteriaType { get; set; }
        [Column("ACU_FLAG")]
        [StringLength(1)]
        [Unicode(false)]
        public string AcuFlag { get; set; }
        [Column("BU_FLAG")]
        [StringLength(1)]
        [Unicode(false)]
        public string BuFlag { get; set; }
    }
}
