using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.Rates
{
    [Table("Datascope_File_Retrieval_Log")]
    public partial class DatascopeFileRetrievalLog
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("Instrument_Group_Id")]
        public int? InstrumentGroupId { get; set; }
        public bool? Received { get; set; }
        public bool? Run { get; set; }
        [Column("Import_DateTime", TypeName = "datetime")]
        public DateTime? ImportDateTime { get; set; }
    }
}
