using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.Rates
{
    [Keyless]
    [Table("Datascope_Column_Selector_by_RICs_RTSH")]
    [Index(nameof(Ric), Name = "UQ__Datascop__CAFF41327EC1CEDB", IsUnique = true)]
    public partial class DatascopeColumnSelectorByRicsRtsh
    {
        [Required]
        [Column("RIC")]
        [StringLength(30)]
        public string Ric { get; set; }
        [StringLength(20)]
        public string BidPriceFrom { get; set; }
        [StringLength(20)]
        public string AskPriceFrom { get; set; }
    }
}
