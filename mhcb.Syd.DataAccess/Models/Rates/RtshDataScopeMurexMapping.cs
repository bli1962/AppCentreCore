using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.Rates
{
    [Table("RTSH_DataScope_Murex_Mapping")]
    public partial class RtshDataScopeMurexMapping
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("CCY")]
        [StringLength(3)]
        public string Ccy { get; set; }
        [Column("MUREX_LABLE")]
        [StringLength(8)]
        public string MurexLable { get; set; }
        [StringLength(25)]
        public string Type { get; set; }
        [StringLength(30)]
        public string Generator { get; set; }
        [StringLength(30)]
        public string Market { get; set; }
        [StringLength(20)]
        public string Maturity { get; set; }
        [Column("RIC")]
        [StringLength(50)]
        public string Ric { get; set; }
        [Column("Murex_Rate_Code")]
        [StringLength(10)]
        public string MurexRateCode { get; set; }
    }
}
