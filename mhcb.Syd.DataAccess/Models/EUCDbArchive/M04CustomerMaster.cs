using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("M04_CUSTOMER_MASTER", Schema = "EUC")]
    public partial class M04CustomerMaster
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
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
        [Column("GUARANTOR_CD")]
        [StringLength(1)]
        public string GuarantorCd { get; set; }
        [Column("GUARANTOR_NAME")]
        [StringLength(40)]
        public string GuarantorName { get; set; }
        [Column("GUARANTOR_COUNTRY")]
        [StringLength(2)]
        public string GuarantorCountry { get; set; }
        [Column("GUARANTOR_ATTR_CD")]
        [StringLength(1)]
        public string GuarantorAttrCd { get; set; }
        [Column("COLLATERAL_NO")]
        [StringLength(5)]
        public string CollateralNo { get; set; }
        [Column("BANK_MANAGEMENT_CD")]
        [StringLength(12)]
        public string BankManagementCd { get; set; }
        [Column("GROUP_CD")]
        [StringLength(12)]
        public string GroupCd { get; set; }
        [Column("COMPANY_CD")]
        [StringLength(12)]
        public string CompanyCd { get; set; }
        [Column("DEPARTMENT_CD")]
        [StringLength(2)]
        public string DepartmentCd { get; set; }
        [Column("OFFICER_CD")]
        [StringLength(4)]
        public string OfficerCd { get; set; }
        [Column("MARK3_CD")]
        [StringLength(8)]
        public string Mark3Cd { get; set; }
        [Column("BOE_CD")]
        [StringLength(5)]
        public string BoeCd { get; set; }
        [Column("AREA_CD")]
        [StringLength(2)]
        public string AreaCd { get; set; }
        [Column("BANK_GROUP_ABBR")]
        [StringLength(12)]
        public string BankGroupAbbr { get; set; }
        [Column("SUBLIMIT_BANK_ABBR")]
        [StringLength(12)]
        public string SublimitBankAbbr { get; set; }
        [Column("CORRES_BANK_CD")]
        [StringLength(7)]
        public string CorresBankCd { get; set; }
        [Column("OFFSHORE_CD")]
        [StringLength(1)]
        public string OffshoreCd { get; set; }
        [Column("LICENCE_FLG")]
        [StringLength(1)]
        public string LicenceFlg { get; set; }
        [Column("BANK_FLG")]
        [StringLength(1)]
        public string BankFlg { get; set; }
        [Column("LOCAL_INDUSTRY_CD")]
        [StringLength(3)]
        public string LocalIndustryCd { get; set; }
        [Column("BUSINESS_CONDITION")]
        [StringLength(1)]
        public string BusinessCondition { get; set; }
        [Column("OBLIGOR_SUPERVISION")]
        [StringLength(1)]
        public string ObligorSupervision { get; set; }
        [Column("CREDIT_SUPERVISION")]
        [StringLength(1)]
        public string CreditSupervision { get; set; }
        [Column("TAX_NO")]
        [StringLength(10)]
        public string TaxNo { get; set; }
        [Column("TAX_CD")]
        [StringLength(2)]
        public string TaxCd { get; set; }
        [Column("TAX_ID")]
        [StringLength(1)]
        public string TaxId { get; set; }
        [Column("REMARKS_1")]
        [StringLength(5)]
        public string Remarks1 { get; set; }
        [Column("REMARKS_2")]
        [StringLength(5)]
        public string Remarks2 { get; set; }
        [Column("REMARKS_3")]
        [StringLength(10)]
        public string Remarks3 { get; set; }
        [Column("RETAIL_ACT_NO")]
        [StringLength(12)]
        public string RetailActNo { get; set; }
        [Column("STAFF_LOAN_FLG")]
        [StringLength(1)]
        public string StaffLoanFlg { get; set; }
        [Column("STATUS_CD")]
        [StringLength(1)]
        public string StatusCd { get; set; }
        [Column("OPENING_DATE", TypeName = "datetime")]
        public DateTime? OpeningDate { get; set; }
        [Column("LAST_UPDATED", TypeName = "datetime")]
        public DateTime? LastUpdated { get; set; }
        [Column("DKB_COMPANY_CD")]
        [StringLength(1)]
        public string DkbCompanyCd { get; set; }
        [Column("GROUP_COMPANY_CD")]
        [StringLength(3)]
        public string GroupCompanyCd { get; set; }
        [Column("CFS_IO")]
        [StringLength(1)]
        public string CfsIo { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
