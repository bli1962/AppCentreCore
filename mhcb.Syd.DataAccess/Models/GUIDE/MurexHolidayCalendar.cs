using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("MUREX_HolidayCalendar")]
    public partial class MurexHolidayCalendar
    {
        [Required]
        [Column("CURRENCY")]
        [StringLength(4)]
        public string Currency { get; set; }
        [Required]
        [Column("CALENDAR_LABEL")]
        [StringLength(4)]
        public string CalendarLabel { get; set; }
        [Required]
        [Column("CALENDAR_DESC")]
        [StringLength(200)]
        public string CalendarDesc { get; set; }
        [Column("HOLIDAY_DATE", TypeName = "datetime")]
        public DateTime HolidayDate { get; set; }
        [Required]
        [Column("HOLIDAY_DESC")]
        [StringLength(200)]
        public string HolidayDesc { get; set; }
    }
}
