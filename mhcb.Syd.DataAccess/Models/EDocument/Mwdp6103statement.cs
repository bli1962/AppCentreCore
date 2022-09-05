using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EDocument
{
    [Table("MWDP6103Statements")]
    public partial class Mwdp6103statement
    {
        [Key]
        public int Id { get; set; }
        public int StatementId { get; set; }
        [StringLength(20)]
        public string Date { get; set; }
        [StringLength(20)]
        public string ValueDate { get; set; }
        [StringLength(50)]
        public string Balance { get; set; }
        [StringLength(50)]
        public string IntRate { get; set; }
        [StringLength(50)]
        public string Interest { get; set; }
        [StringLength(100)]
        public string Remarks { get; set; }

        [ForeignKey(nameof(StatementId))]
        [InverseProperty("Mwdp6103statements")]
        public virtual Statement Statement { get; set; }
    }
}
