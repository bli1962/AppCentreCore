using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("FXFCust", Schema = "dbo")]
    [Index("Abbreviation", Name = "IX_FXFCust_Abbreviation")]
    [Index("Shortname", Name = "IX_FXFCust_SHORTNAME")]
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
        [Unicode(false)]
        public string Code { get; set; }
        [Required]
        [Column("SHORTNAME")]
        [StringLength(35)]
        [Unicode(false)]
        public string Shortname { get; set; }
        [StringLength(12)]
        [Unicode(false)]
        public string Abbreviation { get; set; }
        [Column("IBOSNO")]
        [StringLength(10)]
        [Unicode(false)]
        public string Ibosno { get; set; }
        [Column("BRANCH")]
        [StringLength(3)]
        [Unicode(false)]
        public string Branch { get; set; }
        [Column("ParentEntity_ID")]
        public int? ParentEntityId { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string Location { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string Notes { get; set; }
        public int? Active { get; set; }
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
        [Column("ADD_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string AddBy { get; set; }
        [Column("ADD_ON", TypeName = "smalldatetime")]
        public DateTime AddOn { get; set; }
        [Required]
        [Column("MODIFY_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string ModifyBy { get; set; }
        [Required]
        [Column("DELETE_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string DeleteBy { get; set; }
        [Column("DELETE_ON", TypeName = "smalldatetime")]
        public DateTime DeleteOn { get; set; }
        [Column("MODIFY_ON", TypeName = "smalldatetime")]
        public DateTime ModifyOn { get; set; }
        [Required]
        [Column("AUTHORIZE_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string AuthorizeBy { get; set; }
        [Column("AUTHORIZE_ON", TypeName = "smalldatetime")]
        public DateTime AuthorizeOn { get; set; }
        [Column("Call_Deposit_AUD_type")]
        [StringLength(4)]
        [Unicode(false)]
        public string CallDepositAudType { get; set; }
        [Column("Call_Deposit_FGN_type")]
        [StringLength(4)]
        [Unicode(false)]
        public string CallDepositFgnType { get; set; }
        [Column("Call_Loan_AUD_type")]
        [StringLength(4)]
        [Unicode(false)]
        public string CallLoanAudType { get; set; }
        [Column("Call_Loan_FGN_type")]
        [StringLength(4)]
        [Unicode(false)]
        public string CallLoanFgnType { get; set; }
        [StringLength(70)]
        [Unicode(false)]
        public string Description { get; set; }
        [Column("CCIF")]
        [StringLength(7)]
        [Unicode(false)]
        public string Ccif { get; set; }
        [StringLength(2)]
        [Unicode(false)]
        public string DeptCode { get; set; }
        [StringLength(2)]
        [Unicode(false)]
        public string TaxCode { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string Category { get; set; }
        [StringLength(6)]
        [Unicode(false)]
        public string Sector { get; set; }
        [StringLength(70)]
        [Unicode(false)]
        public string Street1 { get; set; }
        [StringLength(70)]
        [Unicode(false)]
        public string Street2 { get; set; }
        [StringLength(70)]
        [Unicode(false)]
        public string Street3 { get; set; }
        [StringLength(70)]
        [Unicode(false)]
        public string Street4 { get; set; }
        [StringLength(70)]
        [Unicode(false)]
        public string City { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string PostCode { get; set; }
        [StringLength(2)]
        [Unicode(false)]
        public string Country { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string Tel { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string Fax { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string Telex { get; set; }
        [StringLength(11)]
        [Unicode(false)]
        public string Swift { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Email { get; set; }
        [Column("ParentID")]
        public int? ParentId { get; set; }
        public int? MxGuideCustDetailId { get; set; }

        [ForeignKey("MxGuideCustDetailId")]
        [InverseProperty("Fxfcusts")]
        public virtual MxGuideCustDetail MxGuideCustDetail { get; set; }
        [InverseProperty("Cust")]
        public virtual ICollection<MxCustCounterpartyType> MxCustCounterpartyTypes { get; set; }
    }
}
