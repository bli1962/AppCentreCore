using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("D_EVENT_BY_CCY", Schema = "EUC")]
    public partial class DEventByCcy
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("EVENT_DATE", TypeName = "datetime")]
        public DateTime? EventDate { get; set; }
        [Column("SYSTEM_CD")]
        [StringLength(2)]
        public string SystemCd { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("DD_NO")]
        [StringLength(3)]
        public string DdNo { get; set; }
        [Column("RO_NO")]
        [StringLength(3)]
        public string RoNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("INCOMING_AMOUNT", TypeName = "decimal(15, 3)")]
        public decimal? IncomingAmount { get; set; }
        [Column("OUTGOING_AMOUNT", TypeName = "decimal(15, 3)")]
        public decimal? OutgoingAmount { get; set; }
        [Column("INT_AMOUNT", TypeName = "decimal(15, 3)")]
        public decimal? IntAmount { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
