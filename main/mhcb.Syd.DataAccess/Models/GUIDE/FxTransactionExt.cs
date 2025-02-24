using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("FX_TRANSACTION_EXT", Schema = "dbo")]
    public partial class FxTransactionExt
    {
        [Key]
        [Column("REF_NO")]
        [StringLength(12)]
        [Unicode(false)]
        public string RefNo { get; set; }
        public long? PackageId { get; set; }
        public long RootContractId { get; set; }
        public long BaseContractId { get; set; }
        public long ContractId { get; set; }
        public long TradeId { get; set; }
        [Required]
        [StringLength(40)]
        [Unicode(false)]
        public string Event { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string PortfolioGroup { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string PortfolioDesk { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string PortfolioBook { get; set; }
        [Column(TypeName = "decimal(16, 4)")]
        public decimal? BrokerFeeAmount { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string SourceSystem { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string SourceId { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string SourceCtpy { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string DealingMethod { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string AuthorisedDealer { get; set; }
        [Column("CONTRACT_CCY_ABBR_ORIG")]
        [StringLength(3)]
        [Unicode(false)]
        public string ContractCcyAbbrOrig { get; set; }
        [Column("EQUIV_CCY_ABBR_ORIG")]
        [StringLength(3)]
        [Unicode(false)]
        public string EquivCcyAbbrOrig { get; set; }
        public bool? Printed { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PrintDateTime { get; set; }
        [Column("GIDUpload")]
        public bool Gidupload { get; set; }
    }
}
