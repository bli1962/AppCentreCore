using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    public partial class SystemSetting
    {
        [Column("SettingID")]
        public int SettingId { get; set; }
        [Required]
        [StringLength(50)]
        public string SystemName { get; set; }
        [Required]
        [StringLength(50)]
        public string SettingGroup { get; set; }
        [Required]
        [StringLength(100)]
        public string SettingName { get; set; }
        [Required]
        [StringLength(1000)]
        public string SettingValue { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateUpdated { get; set; }
        [Required]
        [StringLength(26)]
        public string UpdatedBy { get; set; }
        public bool Active { get; set; }
        [Required]
        [StringLength(50)]
        public string Server { get; set; }
        [Required]
        [StringLength(50)]
        public string Database { get; set; }
    }
}
