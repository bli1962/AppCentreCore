using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("RATING1")]
    public partial class Rating1
    {
        public Rating1()
        {
            FacilityMasters = new HashSet<FacilityMaster>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [Key]
        [Column("RATING1")]
        [StringLength(1)]
        public string Rating11 { get; set; }

        [InverseProperty(nameof(FacilityMaster.Rating1Navigation))]
        public virtual ICollection<FacilityMaster> FacilityMasters { get; set; }
    }
}
