using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EDocument
{
    public partial class Statement
    {
        public Statement()
        {
            CurrentSavingsStatements = new HashSet<CurrentSavingsStatement>();
            ForeignExchangeStatements = new HashSet<ForeignExchangeStatement>();
            MoneyMarketStatements = new HashSet<MoneyMarketStatement>();
            Mwdp6103statements = new HashSet<Mwdp6103statement>();
        }

        [Key]
        public int Id { get; set; }
        [Column("gBaseDocumentId")]
        public int GBaseDocumentId { get; set; }
        [StringLength(250)]
        public string AccountType { get; set; }
        [StringLength(250)]
        public string AccountNo { get; set; }
        [StringLength(250)]
        public string Currency { get; set; }
        [StringLength(250)]
        public string Period { get; set; }
        [StringLength(250)]
        public string CompanyName { get; set; }
        [StringLength(250)]
        public string CompanyAddress { get; set; }

        [ForeignKey(nameof(GBaseDocumentId))]
        [InverseProperty("Statements")]
        public virtual GBaseDocument GBaseDocument { get; set; }
        [InverseProperty(nameof(CurrentSavingsStatement.Statement))]
        public virtual ICollection<CurrentSavingsStatement> CurrentSavingsStatements { get; set; }
        [InverseProperty(nameof(ForeignExchangeStatement.Statement))]
        public virtual ICollection<ForeignExchangeStatement> ForeignExchangeStatements { get; set; }
        [InverseProperty(nameof(MoneyMarketStatement.Statement))]
        public virtual ICollection<MoneyMarketStatement> MoneyMarketStatements { get; set; }
        [InverseProperty(nameof(Mwdp6103statement.Statement))]
        public virtual ICollection<Mwdp6103statement> Mwdp6103statements { get; set; }
    }
}
