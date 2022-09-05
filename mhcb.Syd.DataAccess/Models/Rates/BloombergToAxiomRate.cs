using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.Rates
{
    [Table("BloombergToAxiomRate")]
    public partial class BloombergToAxiomRate
    {
        [Key]
        [Column("BloombergToAxiomRate")]
        public int BloombergToAxiomRate1 { get; set; }
        [Required]
        [StringLength(50)]
        public string Ticker { get; set; }
    }
}
