using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.Rates
{
    [Keyless]
    [Table("Instrument_Group")]
    public partial class InstrumentGroup
    {
        [Column("Instrument_Group_Id")]
        public int InstrumentGroupId { get; set; }
        [Required]
        [Column("Instrument_Group_Name")]
        [StringLength(40)]
        public string InstrumentGroupName { get; set; }
        [Column("File_Name")]
        [StringLength(40)]
        public string FileName { get; set; }
        [Column("Instrument_Type")]
        [StringLength(10)]
        public string InstrumentType { get; set; }
        [Column("Instrument_Count")]
        public int? InstrumentCount { get; set; }
    }
}
