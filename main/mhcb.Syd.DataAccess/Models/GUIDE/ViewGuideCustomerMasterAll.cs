using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    public partial class ViewGuideCustomerMasterAll
    {
        [Column("CUST_ID")]
        public int CustId { get; set; }
        [Required]
        [Column("CUST_CODE")]
        [StringLength(6)]
        [Unicode(false)]
        public string CustCode { get; set; }
        [Required]
        [Column("BRANCH_NO")]
        [StringLength(3)]
        [Unicode(false)]
        public string BranchNo { get; set; }
        [Required]
        [Column("CUST_ABBR")]
        [StringLength(12)]
        [Unicode(false)]
        public string CustAbbr { get; set; }
        [Column("CUST_NAME")]
        [StringLength(40)]
        [Unicode(false)]
        public string CustName { get; set; }
        [Column("ADDRESS")]
        [StringLength(40)]
        [Unicode(false)]
        public string Address { get; set; }
        [Column("ADDRESS2")]
        [StringLength(30)]
        [Unicode(false)]
        public string Address2 { get; set; }
        [Required]
        [Column("CODE")]
        [StringLength(6)]
        [Unicode(false)]
        public string Code { get; set; }
        [Required]
        [Column("IBOSNO")]
        [StringLength(10)]
        [Unicode(false)]
        public string Ibosno { get; set; }
        [Required]
        [Column("LOCATION_COUNTRY")]
        [StringLength(2)]
        [Unicode(false)]
        public string LocationCountry { get; set; }
        [Required]
        [Column("INDUSTRY_CD")]
        [StringLength(6)]
        [Unicode(false)]
        public string IndustryCd { get; set; }
        [Column("BANK")]
        public bool? Bank { get; set; }
        public int Active { get; set; }
        [Required]
        [Column("STATUS_CD")]
        [StringLength(1)]
        [Unicode(false)]
        public string StatusCd { get; set; }
        [Required]
        [Column("TRAN_NO")]
        [StringLength(5)]
        [Unicode(false)]
        public string TranNo { get; set; }
        [Required]
        [Column("ADD_BY1")]
        [StringLength(8)]
        [Unicode(false)]
        public string AddBy1 { get; set; }
        [Required]
        [Column("AUTHORIZE_BY1")]
        [StringLength(8)]
        [Unicode(false)]
        public string AuthorizeBy1 { get; set; }
        [Required]
        [Column("MODIFY_BY1")]
        [StringLength(8)]
        [Unicode(false)]
        public string ModifyBy1 { get; set; }
        [Required]
        [Column("DELETE_BY1")]
        [StringLength(8)]
        [Unicode(false)]
        public string DeleteBy1 { get; set; }
        [Required]
        [Column("STATUS1")]
        [StringLength(1)]
        [Unicode(false)]
        public string Status1 { get; set; }
        [Required]
        [Column("DELETION_STATUS1")]
        [StringLength(1)]
        [Unicode(false)]
        public string DeletionStatus1 { get; set; }
        [Required]
        [Column("ADD_BY2")]
        [StringLength(8)]
        [Unicode(false)]
        public string AddBy2 { get; set; }
        [Required]
        [Column("AUTHORIZE_BY2")]
        [StringLength(8)]
        [Unicode(false)]
        public string AuthorizeBy2 { get; set; }
        [Required]
        [Column("MODIFY_BY2")]
        [StringLength(8)]
        [Unicode(false)]
        public string ModifyBy2 { get; set; }
        [Required]
        [Column("DELETE_BY2")]
        [StringLength(8)]
        [Unicode(false)]
        public string DeleteBy2 { get; set; }
        [Required]
        [Column("STATUS2")]
        [StringLength(1)]
        [Unicode(false)]
        public string Status2 { get; set; }
        [Required]
        [Column("DELETION_STATUS2")]
        [StringLength(1)]
        [Unicode(false)]
        public string DeletionStatus2 { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string Status { get; set; }
        [Required]
        [StringLength(35)]
        [Unicode(false)]
        public string MxName { get; set; }
        [Required]
        [StringLength(1)]
        [Unicode(false)]
        public string AttributeCode { get; set; }
        [Required]
        [StringLength(20)]
        public string MxStatus { get; set; }
    }
}
