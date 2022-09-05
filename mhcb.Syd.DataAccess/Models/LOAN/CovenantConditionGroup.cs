using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("COVENANT_CONDITION_GROUP")]
    public partial class CovenantConditionGroup
    {
        public CovenantConditionGroup()
        {
            CovenantConditions = new HashSet<CovenantCondition>();
        }

        [Key]
        [Column("CONDITION_GROUP_TYPE")]
        public byte ConditionGroupType { get; set; }
        [Column("CONDITION_GROUP_DESC")]
        [StringLength(50)]
        public string ConditionGroupDesc { get; set; }

        [InverseProperty(nameof(CovenantCondition.ConditionGroupNavigation))]
        public virtual ICollection<CovenantCondition> CovenantConditions { get; set; }
    }
}
