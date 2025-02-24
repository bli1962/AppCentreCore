using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("COVENANT_CONDITION")]
    public partial class CovenantCondition
    {
        public CovenantCondition()
        {
            CovenantMasters = new HashSet<CovenantMaster>();
        }

        [Key]
        [Column("CONDITION_TYPE")]
        public byte ConditionType { get; set; }
        [Column("CONDITION_DESC")]
        [StringLength(150)]
        public string ConditionDesc { get; set; }
        [Column("CONDITION_GROUP")]
        public byte? ConditionGroup { get; set; }

        [ForeignKey(nameof(ConditionGroup))]
        [InverseProperty(nameof(CovenantConditionGroup.CovenantConditions))]
        public virtual CovenantConditionGroup ConditionGroupNavigation { get; set; }
        [InverseProperty(nameof(CovenantMaster.ConditionTypeNavigation))]
        public virtual ICollection<CovenantMaster> CovenantMasters { get; set; }
    }
}
