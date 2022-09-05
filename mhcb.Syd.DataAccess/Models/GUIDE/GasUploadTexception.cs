using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("GAS_UPLOAD_TEXCEPTIONS")]
    public partial class GasUploadTexception
    {
        [Column("LOGDATE_DT", TypeName = "datetime")]
        public DateTime LogdateDt { get; set; }
        [Required]
        [Column("MINNO_TX")]
        [StringLength(26)]
        public string MinnoTx { get; set; }
        [Column("GROUPNO_TX")]
        [StringLength(2)]
        public string GroupnoTx { get; set; }
        [Column("MAINMODULE_TX")]
        [StringLength(50)]
        public string MainmoduleTx { get; set; }
        [Column("FUNCTION_TX")]
        [StringLength(50)]
        public string FunctionTx { get; set; }
        [Column("DESCRIPTION_TX")]
        [StringLength(200)]
        public string DescriptionTx { get; set; }
        [Required]
        [Column("LOGID_TX")]
        [StringLength(15)]
        public string LogidTx { get; set; }
        [Required]
        [Column("SEQUENCENO_TX")]
        [StringLength(2)]
        public string SequencenoTx { get; set; }
    }
}
