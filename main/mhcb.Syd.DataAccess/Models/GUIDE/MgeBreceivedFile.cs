﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MGeBReceivedFile", Schema = "dbo")]
    public partial class MgeBreceivedFile
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(4000)]
        [Unicode(false)]
        public string FileFullPath { get; set; }
        public int Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DownloadDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ProcessDate { get; set; }
        [StringLength(4000)]
        [Unicode(false)]
        public string Notes { get; set; }
    }
}
