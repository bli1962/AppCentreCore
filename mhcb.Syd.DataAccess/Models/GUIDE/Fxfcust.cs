using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("FXFCust")]
    [Index(nameof(Abbreviation), Name = "IX_FXFCust_Abbreviation")]
    [Index(nameof(Shortname), Name = "IX_FXFCust_SHORTNAME")]
    public partial class Fxfcust
    {
        public Fxfcust()
        {
            MxCustCounterpartyTypes = new HashSet<MxCustCounterpartyType>();
        }

        [Key]
        [Column("CUST_ID")]
        public int CustId { get; set; }
        [Required]
        [Column("CODE")]
        [StringLength(6)]
        public string Code { get; set; }
        [Required]
        [Column("SHORTNAME")]
        [StringLength(35)]
        public string Shortname { get; set; }
        [StringLength(12)]
        public string Abbreviation { get; set; }
        [Column("IBOSNO")]
        [StringLength(10)]
        public string Ibosno { get; set; }
        [Column("BRANCH")]
        [StringLength(3)]
        public string Branch { get; set; }
        [Column("ParentEntity_ID")]
        public int? ParentEntityId { get; set; }
        [StringLength(20)]
        public string Location { get; set; }
        [StringLength(150)]
        public string Notes { get; set; }
        public int? Active { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
        [Required]
        [Column("DELETION_STATUS")]
        [StringLength(1)]
        public string DeletionStatus { get; set; }
        [Required]
        [Column("ADD_BY")]
        [StringLength(8)]
        public string AddBy { get; set; }
        [Column("ADD_ON", TypeName = "smalldatetime")]
        public DateTime AddOn { get; set; }
        [Required]
        [Column("MODIFY_BY")]
        [StringLength(8)]
        public string ModifyBy { get; set; }
        [Required]
        [Column("DELETE_BY")]
        [StringLength(8)]
        public string DeleteBy { get; set; }
        [Column("DELETE_ON", TypeName = "smalldatetime")]
        public DateTime DeleteOn { get; set; }
        [Column("MODIFY_ON", TypeName = "smalldatetime")]
        public DateTime ModifyOn { get; set; }
        [Required]
        [Column("AUTHORIZE_BY")]
        [StringLength(8)]
        public string AuthorizeBy { get; set; }
        [Column("AUTHORIZE_ON", TypeName = "smalldatetime")]
        public DateTime AuthorizeOn { get; set; }
        [Column("Call_Deposit_AUD_type")]
        [StringLength(4)]
        public string CallDepositAudType { get; set; }
        [Column("Call_Deposit_FGN_type")]
        [StringLength(4)]
        public string CallDepositFgnType { get; set; }
        [Column("Call_Loan_AUD_type")]
        [StringLength(4)]
        public string CallLoanAudType { get; set; }
        [Column("Call_Loan_FGN_type")]
        [StringLength(4)]
        public string CallLoanFgnType { get; set; }
        [StringLength(70)]
        public string Description { get; set; }
        [Column("CCIF")]
        [StringLength(7)]
        public string Ccif { get; set; }
        [StringLength(2)]
        public string DeptCode { get; set; }
        [StringLength(2)]
        public string TaxCode { get; set; }
        [StringLength(15)]
        public string Category { get; set; }
        [StringLength(6)]
        public string Sector { get; set; }
        [StringLength(70)]
        public string Street1 { get; set; }
        [StringLength(70)]
        public string Street2 { get; set; }
        [StringLength(70)]
        public string Street3 { get; set; }
        [StringLength(70)]
        public string Street4 { get; set; }
        [StringLength(70)]
        public string City { get; set; }
        [StringLength(15)]
        public string PostCode { get; set; }
        [StringLength(2)]
        public string Country { get; set; }
        [StringLength(30)]
        public string Tel { get; set; }
        [StringLength(30)]
        public string Fax { get; set; }
        [StringLength(30)]
        public string Telex { get; set; }
        [StringLength(11)]
        public string Swift { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [Column("ParentID")]
        public int? ParentId { get; set; }
        public int? MxGuideCustDetailId { get; set; }

        [ForeignKey(nameof(MxGuideCustDetailId))]
        [InverseProperty("Fxfcusts")]
        public virtual MxGuideCustDetail MxGuideCustDetail { get; set; }
        [InverseProperty(nameof(MxCustCounterpartyType.Cust))]
        public virtual ICollection<MxCustCounterpartyType> MxCustCounterpartyTypes { get; set; }
    }
}
