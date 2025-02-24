using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("GBase_ErrorCode", Schema = "dbo")]
    public partial class GbaseErrorCode
    {
        [Key]
        [Column("ERROR_CODE")]
        [StringLength(3)]
        [Unicode(false)]
        public string ErrorCode { get; set; }
        [Column("SHORT_DESC")]
        [StringLength(5)]
        [Unicode(false)]
        public string ShortDesc { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string Status { get; set; }
        [Column("MESSAGE")]
        [StringLength(80)]
        [Unicode(false)]
        public string Message { get; set; }
    }
}
