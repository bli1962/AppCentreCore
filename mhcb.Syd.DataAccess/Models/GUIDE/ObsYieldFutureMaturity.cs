using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("OBS_Yield_Future_Maturity")]
    public partial class ObsYieldFutureMaturity
    {
        [StringLength(35)]
        public string ContractName { get; set; }
        [Column("CCY")]
        [StringLength(6)]
        public string Ccy { get; set; }
        [StringLength(15)]
        public string MurexMaturityLable { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Maturity { get; set; }
    }
}
