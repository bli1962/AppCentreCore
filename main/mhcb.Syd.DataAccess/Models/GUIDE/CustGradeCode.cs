using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("CUST_GRADE_CODE", Schema = "dbo")]
    public partial class CustGradeCode
    {
        [Key]
        [Column("GRADE_CODE")]
        [StringLength(2)]
        [Unicode(false)]
        public string GradeCode { get; set; }
        [Column("GRADE_ABBR")]
        [StringLength(2)]
        [Unicode(false)]
        public string GradeAbbr { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(45)]
        [Unicode(false)]
        public string Description { get; set; }
    }
}
