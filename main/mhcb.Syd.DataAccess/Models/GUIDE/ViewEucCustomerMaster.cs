using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    public partial class ViewEucCustomerMaster
    {
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("STEPS_CUST_CD")]
        [StringLength(7)]
        public string StepsCustCd { get; set; }
        [Column("CUST_NAME")]
        [StringLength(40)]
        public string CustName { get; set; }
        [Column("ADDRESS")]
        [StringLength(70)]
        public string Address { get; set; }
        [Column("TEL_NO")]
        [StringLength(15)]
        public string TelNo { get; set; }
        [Column("TELEX_NO")]
        [StringLength(15)]
        public string TelexNo { get; set; }
        [Column("ATTRIBUTE_CD")]
        [StringLength(1)]
        public string AttributeCd { get; set; }
        [Column("INDUSTRY_CD")]
        [StringLength(6)]
        public string IndustryCd { get; set; }
        [Column("GRADE_CD")]
        [StringLength(2)]
        public string GradeCd { get; set; }
        [Column("RATING_POINT", TypeName = "decimal(3, 0)")]
        public decimal? RatingPoint { get; set; }
        [Column("RATING_DATE", TypeName = "datetime")]
        public DateTime? RatingDate { get; set; }
        [Column("NEXT_REVIEW_DATE", TypeName = "datetime")]
        public DateTime? NextReviewDate { get; set; }
        [Column("STANCE")]
        [StringLength(1)]
        public string Stance { get; set; }
        [Column("MAIL_COUNTRY")]
        [StringLength(2)]
        public string MailCountry { get; set; }
        [Column("JAPANESE_FLG")]
        [StringLength(1)]
        public string JapaneseFlg { get; set; }
        [Column("GOOD_ASSET_FLG")]
        [StringLength(1)]
        public string GoodAssetFlg { get; set; }
        [Column("NATIONALITY")]
        [StringLength(2)]
        public string Nationality { get; set; }
        [Column("ATTRIBUTE_SUB_CD")]
        [StringLength(3)]
        public string AttributeSubCd { get; set; }
        [Column("RATIO_OF_INV_JP", TypeName = "decimal(4, 1)")]
        public decimal? RatioOfInvJp { get; set; }
        [Column("RATIO_OF_INV_DKB", TypeName = "decimal(4, 1)")]
        public decimal? RatioOfInvDkb { get; set; }
        [Column("RATIO_OF_INV_GVN", TypeName = "decimal(4, 1)")]
        public decimal? RatioOfInvGvn { get; set; }
        [Column("LOCATION_COUNTRY")]
        [StringLength(2)]
        public string LocationCountry { get; set; }
        [Column("PARENT_NATIONALITY")]
        [StringLength(2)]
        public string ParentNationality { get; set; }
        [Column("PARENT_CUST_CD")]
        [StringLength(10)]
        public string ParentCustCd { get; set; }
        [Column("DEPARTMENT_CD")]
        [StringLength(2)]
        public string DepartmentCd { get; set; }
        [Column("OFFICER_CD")]
        [StringLength(4)]
        public string OfficerCd { get; set; }
        [Column("TAX_CD")]
        [StringLength(2)]
        public string TaxCd { get; set; }
        [Column("STATUS_CD")]
        [StringLength(1)]
        public string StatusCd { get; set; }
    }
}
