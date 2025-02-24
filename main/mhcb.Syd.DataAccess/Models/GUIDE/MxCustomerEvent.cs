using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MxCustomerEvent", Schema = "dbo")]
    public partial class MxCustomerEvent
    {
        public MxCustomerEvent()
        {
            MxGuideCustDetails = new HashSet<MxGuideCustDetail>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Event { get; set; }

        [InverseProperty("MxCustomerEventNavigation")]
        public virtual ICollection<MxGuideCustDetail> MxGuideCustDetails { get; set; }
    }
}
