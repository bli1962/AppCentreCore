using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("MISCELLANEOUS_INF", Schema = "EUC")]
    public partial class MiscellaneousInf
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("APPL_NO")]
        [StringLength(7)]
        public string ApplNo { get; set; }
        [Column("PARTICIPANT_ABBR")]
        [StringLength(12)]
        public string ParticipantAbbr { get; set; }
        [Column("SUB_NO")]
        [StringLength(2)]
        public string SubNo { get; set; }
        [Column("DEPARTMENT_CD")]
        [StringLength(2)]
        public string DepartmentCd { get; set; }
        [Column("SYSTEM_CD")]
        [StringLength(2)]
        public string SystemCd { get; set; }
        [Column("OPERATOR")]
        [StringLength(7)]
        public string Operator { get; set; }
        [Column("TABLE_NO")]
        [StringLength(2)]
        public string TableNo { get; set; }
        [Column("GEN_PUR_INF")]
        [StringLength(30)]
        public string GenPurInf { get; set; }
        [Column("REGISTERED", TypeName = "datetime")]
        public DateTime? Registered { get; set; }
        [Column("LAST_UPDATE", TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
