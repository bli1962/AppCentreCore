using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.Rates
{
    [Table("FXSM_DataScope_Murex_Mapping")]
    public partial class FxsmDataScopeMurexMapping
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("MUREX_LABLE")]
        [StringLength(25)]
        public string MurexLable { get; set; }
        [StringLength(20)]
        public string Maturity { get; set; }
        [Column(TypeName = "decimal(25, 9)")]
        public decimal? Ordinate { get; set; }
        [Column("RIC")]
        [StringLength(50)]
        public string Ric { get; set; }
        [Column("Murex_Rate_Code")]
        [StringLength(10)]
        public string MurexRateCode { get; set; }
    }
}
