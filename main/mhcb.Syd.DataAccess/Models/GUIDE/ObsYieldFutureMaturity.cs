using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("OBS_Yield_Future_Maturity", Schema = "dbo")]
    public partial class ObsYieldFutureMaturity
    {
        [StringLength(35)]
        [Unicode(false)]
        public string ContractName { get; set; }
        [Column("CCY")]
        [StringLength(6)]
        [Unicode(false)]
        public string Ccy { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string MurexMaturityLable { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Maturity { get; set; }
    }
}
