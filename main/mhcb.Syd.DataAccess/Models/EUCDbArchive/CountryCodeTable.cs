using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("COUNTRY_CODE_TABLE", Schema = "EUC")]
    public partial class CountryCodeTable
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("COUNTRY_CD")]
        [StringLength(2)]
        public string CountryCd { get; set; }
        [Column("COUNTRY_NAME")]
        [StringLength(25)]
        public string CountryName { get; set; }
        [Column("AREA_CD")]
        [StringLength(2)]
        public string AreaCd { get; set; }
        [Column("FRB_CD")]
        [StringLength(5)]
        public string FrbCd { get; set; }
        [Column("BOE_CD")]
        [StringLength(4)]
        public string BoeCd { get; set; }
        [Column("HOME_CCY_CD")]
        [StringLength(2)]
        public string HomeCcyCd { get; set; }
        [Column("BOE_AREA_CD")]
        [StringLength(2)]
        public string BoeAreaCd { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
