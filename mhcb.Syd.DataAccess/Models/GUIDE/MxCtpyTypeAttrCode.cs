using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MxCtpyTypeAttrCode")]
    public partial class MxCtpyTypeAttrCode
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        public int CounterpartyType { get; set; }
        [Required]
        [StringLength(1)]
        public string AttributeCode { get; set; }
        [StringLength(3)]
        public string Branch { get; set; }

        [ForeignKey(nameof(CounterpartyType))]
        [InverseProperty(nameof(MxCounterpartyType.MxCtpyTypeAttrCodes))]
        public virtual MxCounterpartyType CounterpartyTypeNavigation { get; set; }
        [ForeignKey("AttributeCode,Branch")]
        [InverseProperty("MxCtpyTypeAttrCodes")]
        public virtual EucCustAttributeCode EucCustAttributeCode { get; set; }
    }
}
