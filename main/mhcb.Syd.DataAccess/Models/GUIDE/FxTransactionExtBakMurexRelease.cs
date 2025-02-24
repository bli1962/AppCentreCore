using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("FX_TRANSACTION_EXT_Bak_MurexRelease")]
    public partial class FxTransactionExtBakMurexRelease
    {
        [Required]
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        public long? PackageId { get; set; }
        public long RootContractId { get; set; }
        public long BaseContractId { get; set; }
        public long ContractId { get; set; }
        public long TradeId { get; set; }
        [Required]
        [StringLength(40)]
        public string Event { get; set; }
        [Required]
        [StringLength(50)]
        public string PortfolioGroup { get; set; }
        [Required]
        [StringLength(50)]
        public string PortfolioDesk { get; set; }
        [Required]
        [StringLength(50)]
        public string PortfolioBook { get; set; }
        [Column(TypeName = "decimal(16, 4)")]
        public decimal? BrokerFeeAmount { get; set; }
        [StringLength(20)]
        public string SourceSystem { get; set; }
        [StringLength(20)]
        public string SourceId { get; set; }
        [StringLength(20)]
        public string SourceCtpy { get; set; }
        [StringLength(20)]
        public string DealingMethod { get; set; }
        [StringLength(100)]
        public string AuthorisedDealer { get; set; }
        [Column("CONTRACT_CCY_ABBR_ORIG")]
        [StringLength(3)]
        public string ContractCcyAbbrOrig { get; set; }
        [Column("EQUIV_CCY_ABBR_ORIG")]
        [StringLength(3)]
        public string EquivCcyAbbrOrig { get; set; }
        public bool? Printed { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PrintDateTime { get; set; }
    }
}
