using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EDocument
{
    public partial class CurrentSavingsStatement
    {
        [Key]
        public int Id { get; set; }
        public int StatementId { get; set; }
        [StringLength(250)]
        public string Date { get; set; }
        [StringLength(250)]
        public string ValueDate { get; set; }
        [StringLength(250)]
        public string RefNo { get; set; }
        [StringLength(250)]
        public string Debit { get; set; }
        [StringLength(250)]
        public string Credit { get; set; }
        [StringLength(250)]
        public string Balance { get; set; }
        [StringLength(250)]
        public string Remarks { get; set; }

        [ForeignKey(nameof(StatementId))]
        [InverseProperty("CurrentSavingsStatements")]
        public virtual Statement Statement { get; set; }
    }
}
