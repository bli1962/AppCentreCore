using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("MxGuideCustDetail_Bak_MurexRelease")]
    public partial class MxGuideCustDetailBakMurexRelease
    {
        [Column("ID")]
        public int Id { get; set; }
        public int? MxCustomerEvent { get; set; }
        public int? MxCustomerStatus { get; set; }
        [StringLength(50)]
        public string EventId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeSent { get; set; }
    }
}
