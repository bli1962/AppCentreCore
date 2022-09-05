using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("GAS_GO_UPLOAD_PARAMETER")]
    public partial class GasGoUploadParameter
    {
        [Column("TYPE_TX")]
        [StringLength(2)]
        public string TypeTx { get; set; }
        [Column("MASTER_MENU_TX")]
        [StringLength(2)]
        public string MasterMenuTx { get; set; }
        [Column("SUB_MENU_SCREEN_TX")]
        [StringLength(7)]
        public string SubMenuScreenTx { get; set; }
        [Column("SUB_MENU_TX")]
        [StringLength(2)]
        public string SubMenuTx { get; set; }
        [Column("GO_SCREEN_TX")]
        [StringLength(7)]
        public string GoScreenTx { get; set; }
        [Column("SECTION_TX")]
        [StringLength(2)]
        public string SectionTx { get; set; }
    }
}
