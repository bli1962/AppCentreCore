using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("SystemSettings", Schema = "dbo")]
    public partial class SystemSetting
    {
        [Column("SettingID")]
        public int SettingId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string SystemName { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string SettingGroup { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string SettingName { get; set; }
        [Required]
        [StringLength(1000)]
        [Unicode(false)]
        public string SettingValue { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateUpdated { get; set; }
        [Required]
        [StringLength(26)]
        [Unicode(false)]
        public string UpdatedBy { get; set; }
        public bool Active { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Server { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Database { get; set; }
    }
}
