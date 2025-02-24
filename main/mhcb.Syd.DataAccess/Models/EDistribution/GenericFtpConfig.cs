using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.EDistribution
{
    [Table("GenericFtpConfig", Schema = "dbo")]
    public partial class GenericFtpConfig
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string Client { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string ServerAddress { get; set; }
        public int ServerPort { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string Account { get; set; }
        [Required]
        [Column("PPK")]
        [Unicode(false)]
        public string Ppk { get; set; }
        [Required]
        [Unicode(false)]
        public string LocalPath { get; set; }
        [Required]
        [Unicode(false)]
        public string RemotePath { get; set; }
        public int DirectionId { get; set; }
        public int Disabled { get; set; }
        [Unicode(false)]
        public string ArchivePath { get; set; }

        [ForeignKey("DirectionId")]
        [InverseProperty("GenericFtpConfigs")]
        public virtual GenericFtpDirection Direction { get; set; }
    }
}
