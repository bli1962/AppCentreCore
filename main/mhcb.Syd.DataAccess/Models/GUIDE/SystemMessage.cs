﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("SYSTEM_MESSAGES", Schema = "dbo")]
    public partial class SystemMessage
    {
        [Key]
        [Column("MESSAGE_ID", TypeName = "decimal(8, 0)")]
        public decimal MessageId { get; set; }
        [Required]
        [Column("TEXT")]
        [StringLength(500)]
        [Unicode(false)]
        public string Text { get; set; }
        [Required]
        [Column("TYPE")]
        [StringLength(4)]
        [Unicode(false)]
        public string Type { get; set; }
        [Column("CREATED_AMENDED_DATE", TypeName = "datetime")]
        public DateTime CreatedAmendedDate { get; set; }
    }
}
