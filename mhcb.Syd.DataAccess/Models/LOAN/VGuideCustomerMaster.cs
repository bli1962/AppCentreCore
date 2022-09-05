using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Keyless]
    public partial class VGuideCustomerMaster
    {
        [Required]
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("CUST_NAME")]
        [StringLength(40)]
        public string CustName { get; set; }
        [Column("ADDRESS_1")]
        [StringLength(40)]
        public string Address1 { get; set; }
        [Column("ADDRESS_2")]
        [StringLength(30)]
        public string Address2 { get; set; }
        [Column("TEL_NO")]
        [StringLength(15)]
        public string TelNo { get; set; }
        [Column("FAX_NO")]
        [StringLength(15)]
        public string FaxNo { get; set; }
        [Column("NATIONALITY")]
        [StringLength(2)]
        public string Nationality { get; set; }
        [Column("STATUS_CD")]
        [StringLength(1)]
        public string StatusCd { get; set; }
        [Column("DEPARTMENT_CD")]
        [StringLength(2)]
        public string DepartmentCd { get; set; }
        [Column("STEPS_CUST_CD")]
        [StringLength(6)]
        public string StepsCustCd { get; set; }
        [Column("JAPANESE_FLG")]
        [StringLength(1)]
        public string JapaneseFlg { get; set; }
        [Required]
        [Column("GUIDE_STATUS")]
        [StringLength(1)]
        public string GuideStatus { get; set; }
        [Column("CCIF")]
        [StringLength(7)]
        public string Ccif { get; set; }
        [Column("CCIF_NAME")]
        [StringLength(70)]
        public string CcifName { get; set; }
    }
}
