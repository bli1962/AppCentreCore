using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.Rates
{
    [Table("BloombergToMurexMappingRule")]
    public partial class BloombergToMurexMappingRule
    {
        public BloombergToMurexMappingRule()
        {
            BloombergToMurexRates = new HashSet<BloombergToMurexRate>();
        }

        [Key]
        public int BloombergToMurexMappingRuleId { get; set; }
        [Required]
        [StringLength(60)]
        public string Ticker { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        [Column("Bid_Pref1_Field1")]
        [StringLength(20)]
        public string BidPref1Field1 { get; set; }
        [Column("Bid_Pref1_Field_Operator")]
        [StringLength(1)]
        public string BidPref1FieldOperator { get; set; }
        [Column("Bid_Pref1_Field2")]
        [StringLength(20)]
        public string BidPref1Field2 { get; set; }
        [Column("Bid_Pref1_Constant_Oprator")]
        [StringLength(1)]
        public string BidPref1ConstantOprator { get; set; }
        [Column("Bid_Pref1_Constant")]
        [StringLength(20)]
        public string BidPref1Constant { get; set; }
        [Column("Bid_Pref2_Field1")]
        [StringLength(20)]
        public string BidPref2Field1 { get; set; }
        [Column("Bid_Pref2_Field_Operator")]
        [StringLength(1)]
        public string BidPref2FieldOperator { get; set; }
        [Column("Bid_Pref2_Field2")]
        [StringLength(20)]
        public string BidPref2Field2 { get; set; }
        [Column("Bid_Pref2_Constant_Oprator")]
        [StringLength(1)]
        public string BidPref2ConstantOprator { get; set; }
        [Column("Bid_Pref2_Constant")]
        [StringLength(20)]
        public string BidPref2Constant { get; set; }
        [Column("Ask_Pref1_Field1")]
        [StringLength(20)]
        public string AskPref1Field1 { get; set; }
        [Column("Ask_Pref1_Field_Operator")]
        [StringLength(1)]
        public string AskPref1FieldOperator { get; set; }
        [Column("Ask_Pref1_Field2")]
        [StringLength(20)]
        public string AskPref1Field2 { get; set; }
        [Column("Ask_Pref1_Constant_Oprator")]
        [StringLength(1)]
        public string AskPref1ConstantOprator { get; set; }
        [Column("Ask_Pref1_Constant")]
        [StringLength(20)]
        public string AskPref1Constant { get; set; }
        [Column("Ask_Pref2_Field1")]
        [StringLength(20)]
        public string AskPref2Field1 { get; set; }
        [Column("Ask_Pref2_Field_Operator")]
        [StringLength(1)]
        public string AskPref2FieldOperator { get; set; }
        [Column("Ask_Pref2_Field2")]
        [StringLength(20)]
        public string AskPref2Field2 { get; set; }
        [Column("Ask_Pref2_Constant_Oprator")]
        [StringLength(1)]
        public string AskPref2ConstantOprator { get; set; }
        [Column("Ask_Pref2_Constant")]
        [StringLength(20)]
        public string AskPref2Constant { get; set; }
        [Column("Murex_Rates_Code")]
        [StringLength(20)]
        public string MurexRatesCode { get; set; }
        [Column("MUREX_LABLE")]
        [StringLength(50)]
        public string MurexLable { get; set; }
        [StringLength(50)]
        public string Lable1 { get; set; }
        [StringLength(50)]
        public string Lable2 { get; set; }
        [StringLength(50)]
        public string Lable3 { get; set; }
        [StringLength(50)]
        public string Lable4 { get; set; }
        [StringLength(50)]
        public string Lable5 { get; set; }
        public bool RequestFileProcessed { get; set; }
        [Column("BidPref1_IsValid")]
        public bool BidPref1IsValid { get; set; }
        [Column("BidPref2_IsValid")]
        public bool BidPref2IsValid { get; set; }
        [Column("AskPref1_IsValid")]
        public bool AskPref1IsValid { get; set; }
        [Column("AskPref2_IsValid")]
        public bool AskPref2IsValid { get; set; }
        public bool IsNotified { get; set; }
        public int? BloombergToMurexMappingRuleFileId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }
        [StringLength(10)]
        public string SnapType { get; set; }
        [Column("SnapType_IsValid")]
        public bool SnapTypeIsValid { get; set; }

        [ForeignKey(nameof(BloombergToMurexMappingRuleFileId))]
        [InverseProperty("BloombergToMurexMappingRules")]
        public virtual BloombergToMurexMappingRuleFile BloombergToMurexMappingRuleFile { get; set; }
        [InverseProperty(nameof(BloombergToMurexRate.BloombergToMurexMappingRule))]
        public virtual ICollection<BloombergToMurexRate> BloombergToMurexRates { get; set; }
    }
}
