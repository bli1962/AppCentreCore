using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("MASS_GBASE_MENU_ACCESS")]
    public partial class MassGbaseMenuAccess
    {
        [Required]
        [Column("MODULE_ID")]
        [StringLength(15)]
        public string ModuleId { get; set; }
        [Required]
        [Column("MENU_SECTION")]
        [StringLength(2)]
        public string MenuSection { get; set; }
        [Required]
        [Column("SECTION_DESC")]
        [StringLength(20)]
        public string SectionDesc { get; set; }
        [Required]
        [Column("SOURCE_TABLE_NAME")]
        [StringLength(50)]
        public string SourceTableName { get; set; }
        [Required]
        [Column("SOURCE_TABLE_UPDATE_FLAG")]
        [StringLength(1)]
        public string SourceTableUpdateFlag { get; set; }
        [Required]
        [Column("APPROVAL_QUERY_STATUS")]
        [StringLength(2)]
        public string ApprovalQueryStatus { get; set; }
        [Required]
        [Column("APPROVAL_SUCCESS_STATUS")]
        [StringLength(2)]
        public string ApprovalSuccessStatus { get; set; }
        [Required]
        [Column("APPROVAL_FAILURE_STATUS")]
        [StringLength(2)]
        public string ApprovalFailureStatus { get; set; }
        [Required]
        [Column("ACTIVE_IND")]
        [StringLength(1)]
        public string ActiveInd { get; set; }
        [Column("REMARKS")]
        [StringLength(25)]
        public string Remarks { get; set; }
        [Column("UPDATE_COL_FOR_STATUS")]
        [StringLength(30)]
        public string UpdateColForStatus { get; set; }
        [Column("UPDATE_COL_FOR_DESC")]
        [StringLength(30)]
        public string UpdateColForDesc { get; set; }
        [Column("WHERE_COL_FOR_TRAN_NO")]
        [StringLength(30)]
        public string WhereColForTranNo { get; set; }
        [Column("WHERE_COL_FOR_REF_NO")]
        [StringLength(30)]
        public string WhereColForRefNo { get; set; }
        [Column("WHERE_COL_FOR_APP_BY")]
        [StringLength(30)]
        public string WhereColForAppBy { get; set; }
        [Column("WHERE_COL_FOR_APP_DT")]
        [StringLength(30)]
        public string WhereColForAppDt { get; set; }
        [Column("MASS_MODULE_FLAG")]
        [StringLength(1)]
        public string MassModuleFlag { get; set; }
        [Column("WHERE_COL_FOR_MIN_NO")]
        [StringLength(30)]
        public string WhereColForMinNo { get; set; }
    }
}
