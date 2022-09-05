using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("MGeBCustomer")]
    [Index(nameof(MgeBcustCode), Name = "UQ__MGeBCust__1A42E58C5598C972", IsUnique = true)]
    [Index(nameof(CustCode), Name = "UQ__MGeBCust__4D554DC05875361D", IsUnique = true)]
    public partial class MgeBcustomer
    {
        [Required]
        [StringLength(6)]
        public string CustCode { get; set; }
        [Required]
        [Column("MGeBCustCode")]
        [StringLength(20)]
        public string MgeBcustCode { get; set; }
    }
}
