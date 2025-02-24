﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DREAMS_UPLOAD_EXCEPTION", Schema = "dbo")]
    public partial class DreamsUploadException
    {
        [Key]
        [Column("EXCEPTION_ID", TypeName = "decimal(18, 0)")]
        public decimal ExceptionId { get; set; }
        [Column("EXCEPTION_DATE", TypeName = "datetime")]
        public DateTime ExceptionDate { get; set; }
        [Required]
        [Column("UPLOAD_TYPE")]
        [StringLength(20)]
        [Unicode(false)]
        public string UploadType { get; set; }
        [Required]
        [Column("RECORD_ID")]
        [StringLength(20)]
        [Unicode(false)]
        public string RecordId { get; set; }
        [Required]
        [Column("UPLOAD_ERROR")]
        [StringLength(255)]
        [Unicode(false)]
        public string UploadError { get; set; }
    }
}
