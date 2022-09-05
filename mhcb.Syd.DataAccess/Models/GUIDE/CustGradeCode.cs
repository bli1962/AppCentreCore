using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("CUST_GRADE_CODE")]
    public partial class CustGradeCode
    {
        [Key]
        [Column("GRADE_CODE")]
        [StringLength(2)]
        public string GradeCode { get; set; }
        [Column("GRADE_ABBR")]
        [StringLength(2)]
        public string GradeAbbr { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(45)]
        public string Description { get; set; }
    }
}
