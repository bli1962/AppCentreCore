using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MxCategoryMapping")]
    [Index(nameof(DepartmentCd), nameof(AttributeCd), Name = "IX_DepartmentCD_Attributed_CD", IsUnique = true)]
    public partial class MxCategoryMapping
    {
        [Key]
        public short Id { get; set; }
        [Required]
        [Column("ATTRIBUTE_CD")]
        [StringLength(1)]
        public string AttributeCd { get; set; }
        [Required]
        [Column("ATTRIBUTE_DESP")]
        [StringLength(50)]
        public string AttributeDesp { get; set; }
        [Required]
        [Column("DEPARTMENT_CD")]
        [StringLength(2)]
        public string DepartmentCd { get; set; }
        [Required]
        [StringLength(50)]
        public string MxCategory { get; set; }
    }
}
