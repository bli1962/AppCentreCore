using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("SHIP_UPLOADING_HISTORY", Schema = "dbo")]
    public partial class ShipUploadingHistory
    {
        [Key]
        [Column("UPLOADING_ID")]
        public int UploadingId { get; set; }
        [Required]
        [Column("SHIP_MIN_NO")]
        [StringLength(10)]
        [Unicode(false)]
        public string ShipMinNo { get; set; }
        [Required]
        [Column("SHIP_SEQ_NO")]
        [StringLength(5)]
        [Unicode(false)]
        public string ShipSeqNo { get; set; }
        [Column("UPLOAD_SEQ")]
        [StringLength(5)]
        [Unicode(false)]
        public string UploadSeq { get; set; }
        [Column("TRAN_NUMBER")]
        [StringLength(5)]
        [Unicode(false)]
        public string TranNumber { get; set; }
        [Column("STATUS")]
        [StringLength(2)]
        [Unicode(false)]
        public string Status { get; set; }
        [Column("INSERT_DATE", TypeName = "datetime")]
        public DateTime? InsertDate { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(200)]
        [Unicode(false)]
        public string Description { get; set; }
        [Column("SCENARIO")]
        [StringLength(3)]
        [Unicode(false)]
        public string Scenario { get; set; }
        [Column("GBASE_REF")]
        [StringLength(12)]
        [Unicode(false)]
        public string GbaseRef { get; set; }
        [Column("CCY")]
        [StringLength(4)]
        [Unicode(false)]
        public string Ccy { get; set; }
    }
}
