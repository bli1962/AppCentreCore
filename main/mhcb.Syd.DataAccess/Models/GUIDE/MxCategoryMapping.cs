using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MxCategoryMapping", Schema = "dbo")]
    [Index("DepartmentCd", "AttributeCd", Name = "IX_DepartmentCD_Attributed_CD", IsUnique = true)]
    public partial class MxCategoryMapping
    {
        [Key]
        public short Id { get; set; }
        [Required]
        [Column("ATTRIBUTE_CD")]
        [StringLength(1)]
        [Unicode(false)]
        public string AttributeCd { get; set; }
        [Required]
        [Column("ATTRIBUTE_DESP")]
        [StringLength(50)]
        [Unicode(false)]
        public string AttributeDesp { get; set; }
        [Required]
        [Column("DEPARTMENT_CD")]
        [StringLength(2)]
        [Unicode(false)]
        public string DepartmentCd { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string MxCategory { get; set; }
    }
}
