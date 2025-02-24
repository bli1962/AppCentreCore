using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("FXFCcy", Schema = "dbo")]
    public partial class Fxfccy
    {
        [Key]
        [Column("CCY_ID")]
        public int CcyId { get; set; }
        [Column("CCY")]
        [StringLength(3)]
        [Unicode(false)]
        public string Ccy { get; set; }
        [Column("CCYDESC")]
        [StringLength(50)]
        [Unicode(false)]
        public string Ccydesc { get; set; }
        [Column("DAYS")]
        public short? Days { get; set; }
        [Column("DIRECT")]
        public bool Direct { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string DreamsDesc { get; set; }
        [Column("SPREADVALUE")]
        public int Spreadvalue { get; set; }
        [Column("FXBLOTTERORDER")]
        public int? Fxblotterorder { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        [Unicode(false)]
        public string CcyCd { get; set; }
        [Column("AUDCrossCCYName")]
        [StringLength(3)]
        [Unicode(false)]
        public string AudcrossCcyname { get; set; }
        public bool? Active { get; set; }
        [Column("Reuters_Rate_Type")]
        [StringLength(20)]
        [Unicode(false)]
        public string ReutersRateType { get; set; }
        [Column("Murex_Rate_Quotation")]
        [StringLength(10)]
        [Unicode(false)]
        public string MurexRateQuotation { get; set; }
        [Column("GBase_Rates_Direction")]
        public bool? GbaseRatesDirection { get; set; }
    }
}
