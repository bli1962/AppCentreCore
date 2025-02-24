﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MxGuideCustDetail", Schema = "dbo")]
    public partial class MxGuideCustDetail
    {
        public MxGuideCustDetail()
        {
            Fxfcusts = new HashSet<Fxfcust>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        public int? MxCustomerEvent { get; set; }
        public int? MxCustomerStatus { get; set; }
        [StringLength(50)]
        public string EventId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeSent { get; set; }

        [ForeignKey("MxCustomerEvent")]
        [InverseProperty("MxGuideCustDetails")]
        public virtual MxCustomerEvent MxCustomerEventNavigation { get; set; }
        [ForeignKey("MxCustomerStatus")]
        [InverseProperty("MxGuideCustDetails")]
        public virtual MxCustomerStatus MxCustomerStatusNavigation { get; set; }
        [InverseProperty("MxGuideCustDetail")]
        public virtual ICollection<Fxfcust> Fxfcusts { get; set; }
    }
}
