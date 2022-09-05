using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.Rates
{
    [Table("BloombergRateLastSnapFile")]
    public partial class BloombergRateLastSnapFile
    {
        [Key]
        public int BloombergRateLastSnapFileId { get; set; }
        public int BloombergRateFileId { get; set; }
        [StringLength(1024)]
        public string Filename { get; set; }
        [StringLength(50)]
        public string FileType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }
    }
}
