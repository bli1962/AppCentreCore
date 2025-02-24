using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("FXFCalendar", Schema = "dbo")]
    public partial class Fxfcalendar
    {
        [Required]
        [Column("CCYCODE")]
        [StringLength(3)]
        [Unicode(false)]
        public string Ccycode { get; set; }
        [Column("DATE", TypeName = "smalldatetime")]
        public DateTime Date { get; set; }
        [Required]
        [Column("DESCRIPTION")]
        [StringLength(200)]
        [Unicode(false)]
        public string Description { get; set; }
    }
}
