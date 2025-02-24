using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("FXFSwift_Mod_Codes_MurexRelease")]
    public partial class FxfswiftModCodesMurexRelease
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("SIF_ID")]
        public int SifId { get; set; }
        [Required]
        [Column("RECORD_KIND")]
        [StringLength(1)]
        public string RecordKind { get; set; }
        [Required]
        [Column("CUST_CODE")]
        [StringLength(6)]
        public string CustCode { get; set; }
        [Required]
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ID")]
        public int? CcyId { get; set; }
        [StringLength(35)]
        public string Addresse { get; set; }
        [StringLength(35)]
        public string PartyIdentifier56 { get; set; }
        [Column("BIC56_1")]
        [StringLength(35)]
        public string Bic561 { get; set; }
        [StringLength(35)]
        public string PartyIdentifier57 { get; set; }
        [Column("FXALM_PartyIdentifier57")]
        [StringLength(35)]
        public string FxalmPartyIdentifier57 { get; set; }
        [Column("BIC57_1")]
        [StringLength(35)]
        public string Bic571 { get; set; }
        [Column("BIC57_2")]
        [StringLength(35)]
        public string Bic572 { get; set; }
        [Column("BIC57_3")]
        [StringLength(35)]
        public string Bic573 { get; set; }
        [Column("BIC57_4")]
        [StringLength(35)]
        public string Bic574 { get; set; }
        [StringLength(35)]
        public string PartyIdentifier58 { get; set; }
        [Column("FXALM_PartyIdentifier58")]
        [StringLength(35)]
        public string FxalmPartyIdentifier58 { get; set; }
        [Column("BIC58_1")]
        [StringLength(35)]
        public string Bic581 { get; set; }
        [StringLength(35)]
        public string PartyIdentifier59 { get; set; }
        [Column("BIC59_1")]
        [StringLength(35)]
        public string Bic591 { get; set; }
        [Column("BIC59_2")]
        [StringLength(35)]
        public string Bic592 { get; set; }
        [Column("BIC59_3")]
        [StringLength(35)]
        public string Bic593 { get; set; }
        [Column("BIC59_4")]
        [StringLength(35)]
        public string Bic594 { get; set; }
        [Column("SpecialInstruction_1")]
        [StringLength(50)]
        public string SpecialInstruction1 { get; set; }
        [Column("SpecialInstruction_2")]
        [StringLength(50)]
        public string SpecialInstruction2 { get; set; }
        [Column("SpecialInstruction_3")]
        [StringLength(50)]
        public string SpecialInstruction3 { get; set; }
        [Column("SpecialInstruction_4")]
        [StringLength(50)]
        public string SpecialInstruction4 { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("DELETION_STATUS")]
        [StringLength(1)]
        public string DeletionStatus { get; set; }
        [Column("ADD_BY")]
        [StringLength(8)]
        public string AddBy { get; set; }
        [Column("ADD_ON", TypeName = "smalldatetime")]
        public DateTime? AddOn { get; set; }
        [Column("AUTHORIZE_BY")]
        [StringLength(8)]
        public string AuthorizeBy { get; set; }
        [Column("AUTHORIZE_ON", TypeName = "smalldatetime")]
        public DateTime? AuthorizeOn { get; set; }
    }
}
