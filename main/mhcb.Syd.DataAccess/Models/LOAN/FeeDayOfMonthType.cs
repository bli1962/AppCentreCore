using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("FEE_DAY_OF_MONTH_TYPE")]
    public partial class FeeDayOfMonthType
    {
        public FeeDayOfMonthType()
        {
            FacilityMasters = new HashSet<FacilityMaster>();
        }

        [Key]
        [Column("DAY_OF_MONTH_TYPE")]
        public byte DayOfMonthType { get; set; }
        [Column("DAY_OF_MONTH_DESC")]
        [StringLength(10)]
        public string DayOfMonthDesc { get; set; }

        [InverseProperty(nameof(FacilityMaster.DayOfMonthTypeNavigation))]
        public virtual ICollection<FacilityMaster> FacilityMasters { get; set; }
    }
}
