using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("Business_Condition_B", Schema = "dbo")]
    public partial class BusinessConditionB
    {
        [Key]
        [Column("CODE")]
        [StringLength(1)]
        [Unicode(false)]
        public string Code { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(50)]
        [Unicode(false)]
        public string Description { get; set; }
    }
}
