using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("RATES_GBASE_UPLOAD_CRITERIA")]
    public partial class RatesGbaseUploadCriterion
    {
        [Key]
        [Column("RATE_TYPE")]
        [StringLength(16)]
        public string RateType { get; set; }
        [Key]
        [Column("CCY")]
        [StringLength(4)]
        public string Ccy { get; set; }
        [Column("CRITERIA_TYPE")]
        [StringLength(10)]
        public string CriteriaType { get; set; }
        [Column("ACU_FLAG")]
        [StringLength(1)]
        public string AcuFlag { get; set; }
        [Column("BU_FLAG")]
        [StringLength(1)]
        public string BuFlag { get; set; }
    }
}
