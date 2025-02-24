﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("DealTypeGroups", Schema = "dbo")]
    public partial class DealTypeGroup
    {
        [Required]
        [StringLength(3)]
        public string ThreeLetterCode { get; set; }
        [Required]
        [StringLength(2)]
        public string FamilyCode { get; set; }
    }
}
