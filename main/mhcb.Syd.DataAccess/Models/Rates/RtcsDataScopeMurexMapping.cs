using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.Rates
{
    [Table("RTCS_DataScope_Murex_Mapping")]
    public partial class RtcsDataScopeMurexMapping
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(45)]
        public string Index { get; set; }
        [StringLength(20)]
        public string Type { get; set; }
        [StringLength(6)]
        public string Pillar { get; set; }
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
