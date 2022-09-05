using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("CUSTOMER_MASTER_Mod_Codes_MurexRelease")]
    public partial class CustomerMasterModCodesMurexRelease
    {
        [Required]
        [Column("Cust_Abbr")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("ProdCustID")]
        public int? ProdCustId { get; set; }
        [Column("ParallelCustID")]
        public int? ParallelCustId { get; set; }
        [StringLength(6)]
        public string ProdCustCode { get; set; }
        [StringLength(6)]
        public string ParallelCustCode { get; set; }
        [Required]
        [Column("ProdBRANCH_NO")]
        [StringLength(3)]
        public string ProdBranchNo { get; set; }
    }
}
