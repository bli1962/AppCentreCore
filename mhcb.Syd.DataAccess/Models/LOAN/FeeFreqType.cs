using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("FEE_FREQ_TYPE")]
    public partial class FeeFreqType
    {
        public FeeFreqType()
        {
            FacilityMasters = new HashSet<FacilityMaster>();
            FeeFreqRefTypes = new HashSet<FeeFreqRefType>();
        }

        [Key]
        [Column("FREQ_TYPE")]
        public byte FreqType { get; set; }
        [Column("FREQ_DESC")]
        [StringLength(20)]
        public string FreqDesc { get; set; }
        [Column("PERIOD")]
        public byte? Period { get; set; }
        [Column("FIXED_DATE")]
        public bool? FixedDate { get; set; }

        [InverseProperty(nameof(FacilityMaster.FreqTypeNavigation))]
        public virtual ICollection<FacilityMaster> FacilityMasters { get; set; }
        [InverseProperty(nameof(FeeFreqRefType.FreqTypeNavigation))]
        public virtual ICollection<FeeFreqRefType> FeeFreqRefTypes { get; set; }
    }
}
