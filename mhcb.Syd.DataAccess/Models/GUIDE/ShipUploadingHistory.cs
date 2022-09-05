using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("SHIP_UPLOADING_HISTORY")]
    public partial class ShipUploadingHistory
    {
        [Key]
        [Column("UPLOADING_ID")]
        public int UploadingId { get; set; }
        [Required]
        [Column("SHIP_MIN_NO")]
        [StringLength(10)]
        public string ShipMinNo { get; set; }
        [Required]
        [Column("SHIP_SEQ_NO")]
        [StringLength(5)]
        public string ShipSeqNo { get; set; }
        [Column("UPLOAD_SEQ")]
        [StringLength(5)]
        public string UploadSeq { get; set; }
        [Column("TRAN_NUMBER")]
        [StringLength(5)]
        public string TranNumber { get; set; }
        [Column("STATUS")]
        [StringLength(2)]
        public string Status { get; set; }
        [Column("INSERT_DATE", TypeName = "datetime")]
        public DateTime? InsertDate { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(200)]
        public string Description { get; set; }
        [Column("SCENARIO")]
        [StringLength(3)]
        public string Scenario { get; set; }
        [Column("GBASE_REF")]
        [StringLength(12)]
        public string GbaseRef { get; set; }
        [Column("CCY")]
        [StringLength(4)]
        public string Ccy { get; set; }
    }
}
