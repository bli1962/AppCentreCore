﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("OPD-37_FileProcessHistory", Schema = "dbo")]
    public partial class Opd37FileProcessHistory
    {
        [Key]
        [Column("FileProcessHistoryID")]
        public int FileProcessHistoryId { get; set; }
        [Required]
        [StringLength(128)]
        [Unicode(false)]
        public string FileName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ProcessDate { get; set; }
    }
}
