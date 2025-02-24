using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("FXFCreditParent", Schema = "dbo")]
    [Index("CorpNo", Name = "IX_FXFCreditParent_CorpNo")]
    public partial class FxfcreditParent
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("CustType_ID")]
        public int? CustTypeId { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string CorpNo { get; set; }
        [Column("CIF")]
        [StringLength(10)]
        [Unicode(false)]
        public string Cif { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; }
        public int? Active { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Description { get; set; }
        [Column("IBOSNo")]
        [StringLength(10)]
        [Unicode(false)]
        public string Ibosno { get; set; }
        [StringLength(6)]
        [Unicode(false)]
        public string Code { get; set; }
        [Column("SamedayFX")]
        public bool SamedayFx { get; set; }
        [Column("DepositALM")]
        public bool DepositAlm { get; set; }
    }
}
