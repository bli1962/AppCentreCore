using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    //[Keyless]
    [Table("Facility_Type_Override")]
    [Index(nameof(RefNo), Name = "UQ__Facility__2D35E3905E4ADDA8", IsUnique = true)]
    public partial class FacilityTypeOverride
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string RefNo { get; set; }
        [Required]
        [Column("Facility_Type")]
        [StringLength(30)]
        public string FacilityType { get; set; }
    }
}
