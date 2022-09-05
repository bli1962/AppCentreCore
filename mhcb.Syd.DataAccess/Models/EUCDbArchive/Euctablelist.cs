using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("EUCTABLELIST")]
    public partial class Euctablelist
    {
        [Column("TBOWNER")]
        [StringLength(64)]
        public string Tbowner { get; set; }
        [Column("TBNAME")]
        [StringLength(255)]
        public string Tbname { get; set; }
        [Column("COLNAME")]
        [StringLength(255)]
        public string Colname { get; set; }
        [Column("COLTYPE")]
        [StringLength(64)]
        public string Coltype { get; set; }
        [Column("COLLENGTH")]
        [StringLength(64)]
        public string Collength { get; set; }
        [Column("COLPRECISION")]
        [StringLength(64)]
        public string Colprecision { get; set; }
        [Column("COLSCALE")]
        [StringLength(64)]
        public string Colscale { get; set; }
        [Column("COLNULLABLE")]
        [StringLength(64)]
        public string Colnullable { get; set; }
        [Column("COLID")]
        [StringLength(64)]
        public string Colid { get; set; }
    }
}
