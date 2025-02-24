using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("EUC_COUNTRY_CODE", Schema = "dbo")]
    public partial class EucCountryCode
    {
        [Key]
        [Column("COUNTRY_CD")]
        [StringLength(2)]
        [Unicode(false)]
        public string CountryCd { get; set; }
        [Column("COUNTRY_NAME")]
        [StringLength(25)]
        [Unicode(false)]
        public string CountryName { get; set; }
        [Column("AREA_CD")]
        [StringLength(2)]
        [Unicode(false)]
        public string AreaCd { get; set; }
        [Column("FRB_CD")]
        [StringLength(5)]
        [Unicode(false)]
        public string FrbCd { get; set; }
        [Column("BOE_CD")]
        [StringLength(4)]
        [Unicode(false)]
        public string BoeCd { get; set; }
        [Column("HOME_CCY_CD")]
        [StringLength(2)]
        [Unicode(false)]
        public string HomeCcyCd { get; set; }
        [Column("BOE_AREA_CD")]
        [StringLength(2)]
        [Unicode(false)]
        public string BoeAreaCd { get; set; }
    }
}
