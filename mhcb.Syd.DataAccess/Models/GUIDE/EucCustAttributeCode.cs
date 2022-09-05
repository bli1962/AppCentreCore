using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("EUC_CUST_ATTRIBUTE_CODE")]
    public partial class EucCustAttributeCode
    {
        public EucCustAttributeCode()
        {
            MxCtpyTypeAttrCodes = new HashSet<MxCtpyTypeAttrCode>();
        }

        [Key]
        [Column("ATTRIBUTE_CD")]
        [StringLength(1)]
        public string AttributeCd { get; set; }
        [Column("ATTRIBUTE_NAME")]
        [StringLength(50)]
        public string AttributeName { get; set; }
        [Key]
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }

        [InverseProperty(nameof(MxCtpyTypeAttrCode.EucCustAttributeCode))]
        public virtual ICollection<MxCtpyTypeAttrCode> MxCtpyTypeAttrCodes { get; set; }
    }
}
