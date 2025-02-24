using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("Isps_MurexGeneratorMapper", Schema = "dbo")]
    public partial class IspsMurexGeneratorMapper
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreateDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeleteDate { get; set; }
        [StringLength(128)]
        [Unicode(false)]
        public string DeletedBy { get; set; }
        [Required]
        [StringLength(128)]
        [Unicode(false)]
        public string IspsName { get; set; }
        [StringLength(128)]
        [Unicode(false)]
        public string MurexName { get; set; }
        [Column("Commited_C")]
        [StringLength(128)]
        [Unicode(false)]
        public string CommitedC { get; set; }
        [Column("Commited_A")]
        [StringLength(128)]
        [Unicode(false)]
        public string CommitedA { get; set; }
        [Column("FrontOfficeOSP")]
        public bool FrontOfficeOsp { get; set; }
        public bool UploadToMurex { get; set; }
    }
}
