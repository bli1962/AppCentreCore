using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MxCustCounterpartyType")]
    public partial class MxCustCounterpartyType
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("CustID")]
        public int CustId { get; set; }
        [Column("CounterpartyTypeID")]
        public int CounterpartyTypeId { get; set; }

        [ForeignKey(nameof(CounterpartyTypeId))]
        [InverseProperty(nameof(MxCounterpartyType.MxCustCounterpartyTypes))]
        public virtual MxCounterpartyType CounterpartyType { get; set; }
        [ForeignKey(nameof(CustId))]
        [InverseProperty(nameof(Fxfcust.MxCustCounterpartyTypes))]
        public virtual Fxfcust Cust { get; set; }
    }
}
