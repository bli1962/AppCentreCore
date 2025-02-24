using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Keyless]
    [Table("CDM_CHECKLIST_GROUP")]
    public partial class CdmChecklistGroup
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("CDM_CHECKLIST_ID")]
        public int CdmChecklistId { get; set; }
        [Column("STATUS")]
        public short Status { get; set; }
    }
}
