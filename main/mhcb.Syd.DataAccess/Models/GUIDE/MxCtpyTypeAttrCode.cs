using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MxCtpyTypeAttrCode", Schema = "dbo")]
    public partial class MxCtpyTypeAttrCode
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        public int CounterpartyType { get; set; }
        [Required]
        [StringLength(1)]
        [Unicode(false)]
        public string AttributeCode { get; set; }
        [StringLength(3)]
        [Unicode(false)]
        public string Branch { get; set; }

        [ForeignKey("CounterpartyType")]
        [InverseProperty("MxCtpyTypeAttrCodes")]
        public virtual MxCounterpartyType CounterpartyTypeNavigation { get; set; }
        [ForeignKey("AttributeCode,Branch")]
        [InverseProperty("MxCtpyTypeAttrCodes")]
        public virtual EucCustAttributeCode EucCustAttributeCode { get; set; }
    }
}
