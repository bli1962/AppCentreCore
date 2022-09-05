using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EDocument
{
    [Table("gBaseDocuments")]
    public partial class GBaseDocument
    {
        public GBaseDocument()
        {
            ForeignExchangeConfirmations = new HashSet<ForeignExchangeConfirmation>();
            MoneyMarketConfirmations = new HashSet<MoneyMarketConfirmation>();
            Statements = new HashSet<Statement>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(250)]
        public string ReportType { get; set; }
        [Required]
        public string ReportFileName { get; set; }
        [Required]
        public string ReportArchiveLocation { get; set; }
        public bool Processed { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateProcessed { get; set; }
        public bool Errored { get; set; }
        [Column(TypeName = "text")]
        public string ErrorMessage { get; set; }

        [InverseProperty(nameof(ForeignExchangeConfirmation.GBaseDocument))]
        public virtual ICollection<ForeignExchangeConfirmation> ForeignExchangeConfirmations { get; set; }
        [InverseProperty(nameof(MoneyMarketConfirmation.GBaseDocument))]
        public virtual ICollection<MoneyMarketConfirmation> MoneyMarketConfirmations { get; set; }
        [InverseProperty(nameof(Statement.GBaseDocument))]
        public virtual ICollection<Statement> Statements { get; set; }
    }
}
