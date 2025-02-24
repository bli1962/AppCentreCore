using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("FEE_CALC_METHOD")]
    public partial class FeeCalcMethod
    {
        public FeeCalcMethod()
        {
            FacilityMasters = new HashSet<FacilityMaster>();
        }

        [Key]
        [Column("FEE_CALC_METHOD_TYPE")]
        public byte FeeCalcMethodType { get; set; }
        [Column("FEE_CALC_METHOD_DESC")]
        [StringLength(3)]
        public string FeeCalcMethodDesc { get; set; }

        [InverseProperty(nameof(FacilityMaster.FeeCalcMethodTypeNavigation))]
        public virtual ICollection<FacilityMaster> FacilityMasters { get; set; }
    }
}
