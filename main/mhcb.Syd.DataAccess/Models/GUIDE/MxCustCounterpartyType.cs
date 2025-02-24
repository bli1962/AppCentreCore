using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MxCustCounterpartyType", Schema = "dbo")]
    public partial class MxCustCounterpartyType
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("CustID")]
        public int CustId { get; set; }
        [Column("CounterpartyTypeID")]
        public int CounterpartyTypeId { get; set; }

        [ForeignKey("CounterpartyTypeId")]
        [InverseProperty("MxCustCounterpartyTypes")]
        public virtual MxCounterpartyType CounterpartyType { get; set; }
        [ForeignKey("CustId")]
        [InverseProperty("MxCustCounterpartyTypes")]
        public virtual Fxfcust Cust { get; set; }
    }
}
