﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MxCategory", Schema = "dbo")]
    public partial class MxCategory
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Label { get; set; }
    }
}
