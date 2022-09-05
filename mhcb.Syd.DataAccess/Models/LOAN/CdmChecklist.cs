using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("CDM_CHECKLIST")]
    public partial class CdmChecklist
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("FILE_ID")]
        [StringLength(50)]
        public string FileId { get; set; }
        [Required]
        [Column("NEW_AMEND_FLAG")]
        [StringLength(20)]
        public string NewAmendFlag { get; set; }
        [Column("BOOK_OFFICE_CD")]
        [StringLength(6)]
        public string BookOfficeCd { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(50)]
        public string CustAbbr { get; set; }
        [Column("GBASE_REF")]
        [StringLength(20)]
        public string GbaseRef { get; set; }
        [Required]
        [Column("EL_MASTER_NO")]
        [StringLength(10)]
        public string ElMasterNo { get; set; }
        [Required]
        [Column("EL_TRANCHE_NO")]
        [StringLength(10)]
        public string ElTrancheNo { get; set; }
        [Column("MULTI_NAME1")]
        [StringLength(40)]
        public string MultiName1 { get; set; }
        [Column("MULTI_NAME2")]
        [StringLength(40)]
        public string MultiName2 { get; set; }
        [Column("MULTI_NAME3")]
        [StringLength(40)]
        public string MultiName3 { get; set; }
        [Column("MULTI_NAME4")]
        [StringLength(40)]
        public string MultiName4 { get; set; }
        [Column("MULTI_NAME5")]
        [StringLength(40)]
        public string MultiName5 { get; set; }
        [Column("MULTI_NAME6")]
        [StringLength(40)]
        public string MultiName6 { get; set; }
        [Column("MULTI_NAME7")]
        [StringLength(40)]
        public string MultiName7 { get; set; }
        [Column("MULTI_NAME8")]
        [StringLength(40)]
        public string MultiName8 { get; set; }
        [Column("MULTI_NAME9")]
        [StringLength(40)]
        public string MultiName9 { get; set; }
        [Column("MULTI_NAME10")]
        [StringLength(40)]
        public string MultiName10 { get; set; }
        [Column("MULTI_NAME11")]
        [StringLength(40)]
        public string MultiName11 { get; set; }
        [Column("MULTI_NAME12")]
        [StringLength(40)]
        public string MultiName12 { get; set; }
        [Column("MULTI_NAME13")]
        [StringLength(40)]
        public string MultiName13 { get; set; }
        [Column("MULTI_NAME14")]
        [StringLength(40)]
        public string MultiName14 { get; set; }
        [Column("MULTI_NAME15")]
        [StringLength(40)]
        public string MultiName15 { get; set; }
        [Column("MULTI_NAME16")]
        [StringLength(40)]
        public string MultiName16 { get; set; }
        [Column("MULTI_NAME17")]
        [StringLength(40)]
        public string MultiName17 { get; set; }
        [Column("MULTI_NAME18")]
        [StringLength(40)]
        public string MultiName18 { get; set; }
        [Column("MULTI_NAME19")]
        [StringLength(40)]
        public string MultiName19 { get; set; }
        [Column("MULTI_NAME20")]
        [StringLength(40)]
        public string MultiName20 { get; set; }
        [Column("AGREEMENT_SIGNING_DATE")]
        [StringLength(50)]
        public string AgreementSigningDate { get; set; }
        [Column("AGREEMENT_SIGNING_DATE2")]
        [StringLength(50)]
        public string AgreementSigningDate2 { get; set; }
        [Column("AMENDMENT_DATE")]
        [StringLength(100)]
        public string AmendmentDate { get; set; }
        [Column("OBLIGOR_RATING_NM")]
        [StringLength(2)]
        public string ObligorRatingNm { get; set; }
        [Column("COMMITMENT")]
        [StringLength(27)]
        public string Commitment { get; set; }
        [Column("TYPE_OF_TRANSACTION")]
        [StringLength(11)]
        public string TypeOfTransaction { get; set; }
        [Column("CIF_NO")]
        [StringLength(7)]
        public string CifNo { get; set; }
        [Column("OBLIGOR_NAME")]
        [StringLength(40)]
        public string ObligorName { get; set; }
        [Column("RM_NAME")]
        [StringLength(20)]
        public string RmName { get; set; }
        [Column("ANALYST_NAME")]
        [StringLength(20)]
        public string AnalystName { get; set; }
        [Column("EL_PROTECTION_TYPE1")]
        [StringLength(50)]
        public string ElProtectionType1 { get; set; }
        [Column("EL_PROTECTION_TYPE2")]
        [StringLength(50)]
        public string ElProtectionType2 { get; set; }
        [Column("EL_PROTECTION_TYPE3")]
        [StringLength(50)]
        public string ElProtectionType3 { get; set; }
        [Column("EL_PROTECTION_TYPE4")]
        [StringLength(50)]
        public string ElProtectionType4 { get; set; }
        [Column("EL_PROTECTION_TYPE5")]
        [StringLength(50)]
        public string ElProtectionType5 { get; set; }
        [Column("EL_PROTECTION_TYPE6")]
        [StringLength(50)]
        public string ElProtectionType6 { get; set; }
        [Column("EL_PROTECTION_TYPE7")]
        [StringLength(50)]
        public string ElProtectionType7 { get; set; }
        [Column("EL_PROTECTION_TYPE8")]
        [StringLength(50)]
        public string ElProtectionType8 { get; set; }
        [Column("EL_PROTECTION_TYPE9")]
        [StringLength(50)]
        public string ElProtectionType9 { get; set; }
        [Column("EL_PROTECTION_TYPE10")]
        [StringLength(50)]
        public string ElProtectionType10 { get; set; }
        [Column("EL_PROTECTION_DETAIL1")]
        [StringLength(200)]
        public string ElProtectionDetail1 { get; set; }
        [Column("EL_PROTECTION_DETAIL2")]
        [StringLength(200)]
        public string ElProtectionDetail2 { get; set; }
        [Column("EL_PROTECTION_DETAIL3")]
        [StringLength(200)]
        public string ElProtectionDetail3 { get; set; }
        [Column("EL_PROTECTION_DETAIL4")]
        [StringLength(200)]
        public string ElProtectionDetail4 { get; set; }
        [Column("EL_PROTECTION_DETAIL5")]
        [StringLength(200)]
        public string ElProtectionDetail5 { get; set; }
        [Column("EL_PROTECTION_DETAIL6")]
        [StringLength(200)]
        public string ElProtectionDetail6 { get; set; }
        [Column("EL_PROTECTION_DETAIL7")]
        [StringLength(200)]
        public string ElProtectionDetail7 { get; set; }
        [Column("EL_PROTECTION_DETAIL8")]
        [StringLength(200)]
        public string ElProtectionDetail8 { get; set; }
        [Column("EL_PROTECTION_DETAIL9")]
        [StringLength(200)]
        public string ElProtectionDetail9 { get; set; }
        [Column("EL_PROTECTION_DETAIL10")]
        [StringLength(200)]
        public string ElProtectionDetail10 { get; set; }
        [Column("EL_PROTECTION_DUEDATE1")]
        [StringLength(10)]
        public string ElProtectionDuedate1 { get; set; }
        [Column("EL_PROTECTION_DUEDATE2")]
        [StringLength(10)]
        public string ElProtectionDuedate2 { get; set; }
        [Column("EL_PROTECTION_DUEDATE3")]
        [StringLength(10)]
        public string ElProtectionDuedate3 { get; set; }
        [Column("EL_PROTECTION_DUEDATE4")]
        [StringLength(10)]
        public string ElProtectionDuedate4 { get; set; }
        [Column("EL_PROTECTION_DUEDATE5")]
        [StringLength(10)]
        public string ElProtectionDuedate5 { get; set; }
        [Column("EL_PROTECTION_DUEDATE6")]
        [StringLength(10)]
        public string ElProtectionDuedate6 { get; set; }
        [Column("EL_PROTECTION_DUEDATE7")]
        [StringLength(10)]
        public string ElProtectionDuedate7 { get; set; }
        [Column("EL_PROTECTION_DUEDATE8")]
        [StringLength(10)]
        public string ElProtectionDuedate8 { get; set; }
        [Column("EL_PROTECTION_DUEDATE9")]
        [StringLength(10)]
        public string ElProtectionDuedate9 { get; set; }
        [Column("EL_PROTECTION_DUEDATE10")]
        [StringLength(10)]
        public string ElProtectionDuedate10 { get; set; }
        [Column("APPLI_TYPE")]
        [StringLength(20)]
        public string AppliType { get; set; }
        [Column("APPLI_NO")]
        [StringLength(9)]
        public string AppliNo { get; set; }
        [Column("APPLI_DATE")]
        [StringLength(50)]
        public string AppliDate { get; set; }
        [Column("RELATED_APPLI_NO")]
        [StringLength(9)]
        public string RelatedAppliNo { get; set; }
        [Column("RELATED_APPLI_DATE")]
        [StringLength(50)]
        public string RelatedAppliDate { get; set; }
        [Column("FINAL_CCY_SWIFT")]
        [StringLength(3)]
        public string FinalCcySwift { get; set; }
        [Column("MULTI")]
        [StringLength(3)]
        public string Multi { get; set; }
        [Column("GB_FINAL_TAKE_AMT")]
        [StringLength(50)]
        public string GbFinalTakeAmt { get; set; }
        [Column("EL_LIMIT")]
        [StringLength(50)]
        public string ElLimit { get; set; }
        [Column("SYNDICATION")]
        [StringLength(50)]
        public string Syndication { get; set; }
        [Column("COMMIT_COMMENCEMENT_DATE")]
        [StringLength(50)]
        public string CommitCommencementDate { get; set; }
        [Column("TERM_END_DATE")]
        [StringLength(50)]
        public string TermEndDate { get; set; }
        [Column("MULTI_CCY_DETAILS")]
        [StringLength(100)]
        public string MultiCcyDetails { get; set; }
        [Column("MAX_DRAWN1")]
        [StringLength(10)]
        public string MaxDrawn1 { get; set; }
        [Column("MAX_DRAWN2")]
        [StringLength(10)]
        public string MaxDrawn2 { get; set; }
        [Column("MAX_DRAWN3")]
        [StringLength(10)]
        public string MaxDrawn3 { get; set; }
        [Column("SPREAD")]
        [StringLength(50)]
        public string Spread { get; set; }
        [Column("STATUS")]
        public short Status { get; set; }
        [Column("DATE_IMPORTED", TypeName = "smalldatetime")]
        public DateTime DateImported { get; set; }
    }
}
