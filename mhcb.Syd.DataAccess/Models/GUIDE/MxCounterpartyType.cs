using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MxCounterpartyType")]
    public partial class MxCounterpartyType
    {
        public MxCounterpartyType()
        {
            MxCtpyTypeAttrCodes = new HashSet<MxCtpyTypeAttrCode>();
            MxCustCounterpartyTypes = new HashSet<MxCustCounterpartyType>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Label { get; set; }
        [StringLength(70)]
        public string Description { get; set; }

        [InverseProperty(nameof(MxCtpyTypeAttrCode.CounterpartyTypeNavigation))]
        public virtual ICollection<MxCtpyTypeAttrCode> MxCtpyTypeAttrCodes { get; set; }
        [InverseProperty(nameof(MxCustCounterpartyType.CounterpartyType))]
        public virtual ICollection<MxCustCounterpartyType> MxCustCounterpartyTypes { get; set; }
    }
}
