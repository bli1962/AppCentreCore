using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("GAS_UPLOAD_HISTORY")]
    public partial class GasUploadHistory
    {
        [Required]
        [Column("MIN_NO")]
        [StringLength(26)]
        public string MinNo { get; set; }
        [Column("DREAMS_REF_CODE")]
        [StringLength(12)]
        public string DreamsRefCode { get; set; }
        [Column("STATUS", TypeName = "decimal(2, 0)")]
        public decimal? Status { get; set; }
        [Column("TRAN_NUMBER")]
        [StringLength(5)]
        public string TranNumber { get; set; }
        [Column("GROUP_NO")]
        [StringLength(2)]
        public string GroupNo { get; set; }
        [Column("DESCRIPTION_TX")]
        [StringLength(200)]
        public string DescriptionTx { get; set; }
        [Required]
        [Column("SEQUENCENO_TX")]
        [StringLength(2)]
        public string SequencenoTx { get; set; }
        [Column("UPLOAD_MODE")]
        [StringLength(3)]
        public string UploadMode { get; set; }
        [Column("CREATED_DATE", TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
    }
}
