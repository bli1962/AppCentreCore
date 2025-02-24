using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("CUSTOMER_MASTER", Schema = "dbo")]
    [Index("CustAbbr", Name = "IX_CUSTOMER_MASTER_CUST_ABBR")]
    [Index("CustId", Name = "IX_CUSTOMER_MASTER_CUST_ID")]
    public partial class CustomerMaster
    {
        public CustomerMaster()
        {
            FxTransactions = new HashSet<FxTransaction>();
        }

        [Column("CUST_ID")]
        public int? CustId { get; set; }
        [Column("CUST_CODE")]
        [StringLength(6)]
        [Unicode(false)]
        public string CustCode { get; set; }
        [Key]
        [Column("BRANCH_NO")]
        [StringLength(3)]
        [Unicode(false)]
        public string BranchNo { get; set; }
        [Key]
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
        [Column("TEL_NO")]
        [StringLength(15)]
        [Unicode(false)]
        public string TelNo { get; set; }
        [Column("TELEX_NO")]
        [StringLength(15)]
        [Unicode(false)]
        public string TelexNo { get; set; }
        [Column("STAFF_LOAN_FLG")]
        [StringLength(1)]
        [Unicode(false)]
        public string StaffLoanFlg { get; set; }
        [Column("MAIL_COUNTRY")]
        [StringLength(2)]
        [Unicode(false)]
        public string MailCountry { get; set; }
        [Column("LOCATION_COUNTRY")]
        [StringLength(2)]
        [Unicode(false)]
        public string LocationCountry { get; set; }
        [Column("NATIONALITY")]
        [StringLength(2)]
        [Unicode(false)]
        public string Nationality { get; set; }
        [Column("STATUS_CD")]
        [StringLength(1)]
        [Unicode(false)]
        public string StatusCd { get; set; }
        [Column("DEPARTMENT_CD")]
        [StringLength(2)]
        [Unicode(false)]
        public string DepartmentCd { get; set; }
        [Column("OFFICER_CD")]
        [StringLength(4)]
        [Unicode(false)]
        public string OfficerCd { get; set; }
        [Column("OPENING_DATE", TypeName = "smalldatetime")]
        public DateTime? OpeningDate { get; set; }
        [Column("LAST_UPDATED", TypeName = "smalldatetime")]
        public DateTime? LastUpdated { get; set; }
        [Column("STEPS_CUST_CD")]
        [StringLength(6)]
        [Unicode(false)]
        public string StepsCustCd { get; set; }
        [Column("INDUSTRY_CD")]
        [StringLength(6)]
        [Unicode(false)]
        public string IndustryCd { get; set; }
        [Column("DKB_COMPANY_CD")]
        [StringLength(1)]
        [Unicode(false)]
        public string DkbCompanyCd { get; set; }
        [Column("GROUP_COMPANY_CD")]
        [StringLength(4)]
        [Unicode(false)]
        public string GroupCompanyCd { get; set; }
        [Column("STANCE")]
        [StringLength(1)]
        [Unicode(false)]
        public string Stance { get; set; }
        [Column("JAPANESE_FLG")]
        [StringLength(1)]
        [Unicode(false)]
        public string JapaneseFlg { get; set; }
        [Column("ATTRIBUTE_CD")]
        [StringLength(1)]
        [Unicode(false)]
        public string AttributeCd { get; set; }
        [Column("ATTRIBUTE_SUB_CD")]
        [StringLength(3)]
        [Unicode(false)]
        public string AttributeSubCd { get; set; }
        [Column("RATIO_OF_INV_JP", TypeName = "decimal(5, 2)")]
        public decimal? RatioOfInvJp { get; set; }
        [Column("RATIO_OF_INV_DKB", TypeName = "decimal(5, 2)")]
        public decimal? RatioOfInvDkb { get; set; }
        [Column("RATIO_OF_INV_GVN", TypeName = "decimal(5, 2)")]
        public decimal? RatioOfInvGvn { get; set; }
        [Column("PARENT_CUST_CD")]
        [StringLength(10)]
        [Unicode(false)]
        public string ParentCustCd { get; set; }
        [Column("PARENT_NATIONALITY")]
        [StringLength(2)]
        [Unicode(false)]
        public string ParentNationality { get; set; }
        [Column("TAX_NO")]
        [StringLength(10)]
        [Unicode(false)]
        public string TaxNo { get; set; }
        [Column("GOOD_ASSET_FLG")]
        [StringLength(1)]
        [Unicode(false)]
        public string GoodAssetFlg { get; set; }
        [Column("OFFSHORE_CD")]
        [StringLength(1)]
        [Unicode(false)]
        public string OffshoreCd { get; set; }
        [Column("TAX_CD")]
        [StringLength(2)]
        [Unicode(false)]
        public string TaxCd { get; set; }
        [Column("TAX_ID")]
        [StringLength(1)]
        [Unicode(false)]
        public string TaxId { get; set; }
        [Column("BOE_CD")]
        [StringLength(5)]
        [Unicode(false)]
        public string BoeCd { get; set; }
        [Column("AREA_CD")]
        [StringLength(2)]
        [Unicode(false)]
        public string AreaCd { get; set; }
        [Column("BUSINESS_CONDITION")]
        [StringLength(1)]
        [Unicode(false)]
        public string BusinessCondition { get; set; }
        [Column("OBLIGOR_SUPERVISION")]
        [StringLength(1)]
        [Unicode(false)]
        public string ObligorSupervision { get; set; }
        [Column("CREDIT_SUPERVISION")]
        [StringLength(1)]
        [Unicode(false)]
        public string CreditSupervision { get; set; }
        [Column("LOCAL_INDUSTRY_CD")]
        [StringLength(3)]
        [Unicode(false)]
        public string LocalIndustryCd { get; set; }
        [Column("LICENCE_FLG")]
        [StringLength(1)]
        [Unicode(false)]
        public string LicenceFlg { get; set; }
        [Column("BANK_FLG")]
        [StringLength(1)]
        [Unicode(false)]
        public string BankFlg { get; set; }
        [Column("CFS_IO")]
        [StringLength(1)]
        [Unicode(false)]
        public string CfsIo { get; set; }
        [Column("BANK_MANAGEMENT_CD")]
        [StringLength(12)]
        [Unicode(false)]
        public string BankManagementCd { get; set; }
        [Column("GROUP_CD")]
        [StringLength(12)]
        [Unicode(false)]
        public string GroupCd { get; set; }
        [Column("COMPANY_CD")]
        [StringLength(12)]
        [Unicode(false)]
        public string CompanyCd { get; set; }
        [Column("GUARANTOR_CD")]
        [StringLength(1)]
        [Unicode(false)]
        public string GuarantorCd { get; set; }
        [Column("GUARANTOR_COUNTRY")]
        [StringLength(2)]
        [Unicode(false)]
        public string GuarantorCountry { get; set; }
        [Column("GUARANTOR_ATTR_CD")]
        [StringLength(1)]
        [Unicode(false)]
        public string GuarantorAttrCd { get; set; }
        [Column("GUARANTOR_NAME")]
        [StringLength(40)]
        [Unicode(false)]
        public string GuarantorName { get; set; }
        [Column("COLLATERAL_NO")]
        [StringLength(5)]
        [Unicode(false)]
        public string CollateralNo { get; set; }
        [Column("BANK_GROUP_ABBR")]
        [StringLength(12)]
        [Unicode(false)]
        public string BankGroupAbbr { get; set; }
        [Column("SUBLIMIT_BANK_ABBR")]
        [StringLength(12)]
        [Unicode(false)]
        public string SublimitBankAbbr { get; set; }
        [Column("MARK3_CD")]
        [StringLength(8)]
        [Unicode(false)]
        public string Mark3Cd { get; set; }
        [Column("CORRES_BANK_CD")]
        [StringLength(7)]
        [Unicode(false)]
        public string CorresBankCd { get; set; }
        [Column("GRADE_CD")]
        [StringLength(2)]
        [Unicode(false)]
        public string GradeCd { get; set; }
        [Column("RATING_POINT")]
        public int? RatingPoint { get; set; }
        [Column("RATING_DATE", TypeName = "smalldatetime")]
        public DateTime? RatingDate { get; set; }
        [Column("NEXT_REVIEW_DATE", TypeName = "smalldatetime")]
        public DateTime? NextReviewDate { get; set; }
        [Column("RETAIL_ACT_NO")]
        [StringLength(12)]
        [Unicode(false)]
        public string RetailActNo { get; set; }
        [Column("REMARKS_1")]
        [StringLength(5)]
        [Unicode(false)]
        public string Remarks1 { get; set; }
        [Column("REMARKS_2")]
        [StringLength(5)]
        [Unicode(false)]
        public string Remarks2 { get; set; }
        [Column("REMARKS_3")]
        [StringLength(10)]
        [Unicode(false)]
        public string Remarks3 { get; set; }
        [Required]
        [Column("ADD_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string AddBy { get; set; }
        [Column("ADD_ON", TypeName = "smalldatetime")]
        public DateTime AddOn { get; set; }
        [Required]
        [Column("AUTHORIZE_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string AuthorizeBy { get; set; }
        [Column("AUTHORIZE_ON", TypeName = "smalldatetime")]
        public DateTime AuthorizeOn { get; set; }
        [Required]
        [Column("MODIFY_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string ModifyBy { get; set; }
        [Column("MODIFY_ON", TypeName = "smalldatetime")]
        public DateTime ModifyOn { get; set; }
        [Required]
        [Column("DELETE_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string DeleteBy { get; set; }
        [Column("DELETE_ON", TypeName = "smalldatetime")]
        public DateTime DeleteOn { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string Status { get; set; }
        [Required]
        [Column("DELETION_STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string DeletionStatus { get; set; }
        [Required]
        [Column("GIP_STATUS")]
        [StringLength(2)]
        [Unicode(false)]
        public string GipStatus { get; set; }
        [Required]
        [Column("GIP_DESCRIPTION")]
        [StringLength(100)]
        [Unicode(false)]
        public string GipDescription { get; set; }
        [Required]
        [Column("TRAN_NO")]
        [StringLength(5)]
        [Unicode(false)]
        public string TranNo { get; set; }

        [InverseProperty("CustomerMaster")]
        public virtual ICollection<FxTransaction> FxTransactions { get; set; }
    }
}
