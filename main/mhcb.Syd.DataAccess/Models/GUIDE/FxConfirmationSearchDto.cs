using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("FxConfirmationSearchDTO", Schema = "dbo")]
    public partial class FxConfirmationSearchDto
    {
        [Column("REF_NO")]
        [StringLength(100)]
        [Unicode(false)]
        public string RefNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(100)]
        [Unicode(false)]
        public string CustAbbr { get; set; }
        [Column("CUST_NAME")]
        [StringLength(100)]
        [Unicode(false)]
        public string CustName { get; set; }
        [Column("CUST_CODE")]
        [StringLength(10)]
        [Unicode(false)]
        public string CustCode { get; set; }
        [Column("CONTRACT_DATE_OPE", TypeName = "datetime")]
        public DateTime? ContractDateOpe { get; set; }
        [Column("DELIVARY_DATE", TypeName = "datetime")]
        public DateTime? DelivaryDate { get; set; }
        [Column("CONTRACT_CCY_ABBR")]
        [StringLength(10)]
        [Unicode(false)]
        public string ContractCcyAbbr { get; set; }
        [Column("CONTRACT_CCY_AMT", TypeName = "decimal(16, 3)")]
        public decimal? ContractCcyAmt { get; set; }
        [Column("EXCHANGE_RATE", TypeName = "decimal(16, 8)")]
        public decimal? ExchangeRate { get; set; }
        [Column("EQUIV_CCY_ABBR")]
        [StringLength(10)]
        [Unicode(false)]
        public string EquivCcyAbbr { get; set; }
        [Column("EQUIV_CCY_AMT", TypeName = "decimal(16, 3)")]
        public decimal? EquivCcyAmt { get; set; }
        [Column("DELETION_STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string DeletionStatus { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string Status { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string DistributionChannel { get; set; }
        public int? DistributionChannelId { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string FxConfirmationStatus { get; set; }
        public int? FxConfirmationStatusId { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string FinalStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReminderEmaildate { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string ReminderEmailSummary { get; set; }
        [Column("ID")]
        public int Id { get; set; }
        [Column("searchGuid")]
        [StringLength(100)]
        [Unicode(false)]
        public string SearchGuid { get; set; }
    }
}
