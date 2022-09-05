using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.Rates
{
    [Table("BloombergToMurexMappingRuleFile")]
    public partial class BloombergToMurexMappingRuleFile
    {
        public BloombergToMurexMappingRuleFile()
        {
            BloombergToMurexMappingRules = new HashSet<BloombergToMurexMappingRule>();
        }

        [Key]
        public int BloombergToMurexMappingRuleFileId { get; set; }
        [Required]
        [StringLength(1000)]
        public string FileName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [InverseProperty(nameof(BloombergToMurexMappingRule.BloombergToMurexMappingRuleFile))]
        public virtual ICollection<BloombergToMurexMappingRule> BloombergToMurexMappingRules { get; set; }
    }
}
