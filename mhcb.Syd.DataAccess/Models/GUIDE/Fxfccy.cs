using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("FXFCcy")]
    public partial class Fxfccy
    {
        [Key]
        [Column("CCY_ID")]
        public int CcyId { get; set; }
        [Column("CCY")]
        [StringLength(3)]
        public string Ccy { get; set; }
        [Column("CCYDESC")]
        [StringLength(50)]
        public string Ccydesc { get; set; }
        [Column("DAYS")]
        public short? Days { get; set; }
        [Column("DIRECT")]
        public bool Direct { get; set; }
        [StringLength(5)]
        public string DreamsDesc { get; set; }
        [Column("SPREADVALUE")]
        public int Spreadvalue { get; set; }
        [Column("FXBLOTTERORDER")]
        public int? Fxblotterorder { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("AUDCrossCCYName")]
        [StringLength(3)]
        public string AudcrossCcyname { get; set; }
        public bool? Active { get; set; }
        [Column("Reuters_Rate_Type")]
        [StringLength(20)]
        public string ReutersRateType { get; set; }
        [Column("Murex_Rate_Quotation")]
        [StringLength(10)]
        public string MurexRateQuotation { get; set; }
    }
}
