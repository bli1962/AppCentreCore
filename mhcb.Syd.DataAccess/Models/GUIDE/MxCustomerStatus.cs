using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MxCustomerStatus")]
    public partial class MxCustomerStatus
    {
        public MxCustomerStatus()
        {
            MxGuideCustDetails = new HashSet<MxGuideCustDetail>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Status { get; set; }

        [InverseProperty(nameof(MxGuideCustDetail.MxCustomerStatusNavigation))]
        public virtual ICollection<MxGuideCustDetail> MxGuideCustDetails { get; set; }
    }
}
