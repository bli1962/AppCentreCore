﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("LOAN_MASTER")]
    public partial class LoanMaster
    {
        public LoanMaster()
        {
            LoanMasterAccountOfficers = new HashSet<LoanMasterAccountOfficer>();
            LoanMasterBorrowers = new HashSet<LoanMasterBorrower>();
            LoanMasterCovenants = new HashSet<LoanMasterCovenant>();
            LoanMasterRatings = new HashSet<LoanMasterRating>();
            LoanMasterSecurities = new HashSet<LoanMasterSecurity>();
            TrancheMasters = new HashSet<TrancheMaster>();
        }

        [Key]
        [Column("LOAN_NO")]
        public int LoanNo { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("MULTI_BRW")]
        public bool? MultiBrw { get; set; }
        [Column("AGREEM_DATE1", TypeName = "datetime")]
        public DateTime? AgreemDate1 { get; set; }
        [Column("AGREEM_DATE2", TypeName = "datetime")]
        public DateTime? AgreemDate2 { get; set; }
        [Column("AMENDMENT_DATE")]
        [StringLength(400)]
        public string AmendmentDate { get; set; }
        [Column("RATING")]
        [StringLength(2)]
        public string Rating { get; set; }
        [Column("PROD_TYPE2")]
        public short? ProdType2 { get; set; }
        [Column("PROD_TYPE4")]
        public short? ProdType4 { get; set; }
        [Column("REMARKS")]
        [StringLength(400)]
        public string Remarks { get; set; }
        [Column("AGENT")]
        [StringLength(50)]
        public string Agent { get; set; }
        [Column("ADDRESS")]
        [StringLength(70)]
        public string Address { get; set; }
        [Column("CONTACT")]
        [StringLength(200)]
        public string Contact { get; set; }
        [Column("TEL_NO")]
        [StringLength(25)]
        public string TelNo { get; set; }
        [Column("FAX_NO")]
        [StringLength(25)]
        public string FaxNo { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("PROC_BY")]
        [StringLength(6)]
        public string ProcBy { get; set; }
        [Column("PROC_ON", TypeName = "datetime")]
        public DateTime? ProcOn { get; set; }
        [Column("APPR_BY")]
        [StringLength(6)]
        public string ApprBy { get; set; }
        [Column("APPR_ON", TypeName = "datetime")]
        public DateTime? ApprOn { get; set; }
        [Required]
        [Column("CCIF")]
        [StringLength(7)]
        public string Ccif { get; set; }
        [Required]
        [Column("CCIF_NAME")]
        [StringLength(70)]
        public string CcifName { get; set; }
        [Required]
        [Column("GCIF")]
        [StringLength(6)]
        public string Gcif { get; set; }
        [Required]
        [Column("RATIO_SPREAD1")]
        [StringLength(20)]
        public string RatioSpread1 { get; set; }
        [Required]
        [Column("RATIO_SPREAD2")]
        [StringLength(20)]
        public string RatioSpread2 { get; set; }

        [InverseProperty(nameof(LoanMasterAccountOfficer.LoanNoNavigation))]
        public virtual ICollection<LoanMasterAccountOfficer> LoanMasterAccountOfficers { get; set; }
        [InverseProperty(nameof(LoanMasterBorrower.LoanNoNavigation))]
        public virtual ICollection<LoanMasterBorrower> LoanMasterBorrowers { get; set; }
        [InverseProperty(nameof(LoanMasterCovenant.LoanNoNavigation))]
        public virtual ICollection<LoanMasterCovenant> LoanMasterCovenants { get; set; }
        [InverseProperty(nameof(LoanMasterRating.LoanNoNavigation))]
        public virtual ICollection<LoanMasterRating> LoanMasterRatings { get; set; }
        [InverseProperty(nameof(LoanMasterSecurity.LoanNoNavigation))]
        public virtual ICollection<LoanMasterSecurity> LoanMasterSecurities { get; set; }
        [InverseProperty(nameof(TrancheMaster.LoanNoNavigation))]
        public virtual ICollection<TrancheMaster> TrancheMasters { get; set; }
    }
}
