using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("GBase_ErrorCode")]
    public partial class GbaseErrorCode
    {
        [Key]
        [Column("ERROR_CODE")]
        [StringLength(3)]
        public string ErrorCode { get; set; }
        [Column("SHORT_DESC")]
        [StringLength(5)]
        public string ShortDesc { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("MESSAGE")]
        [StringLength(80)]
        public string Message { get; set; }
    }
}
