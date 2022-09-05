using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    public partial class ViewFxsystemCreditparent
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("CustType_ID")]
        public int? CustTypeId { get; set; }
        [StringLength(10)]
        public string CorpNo { get; set; }
        [Column("CIF")]
        [StringLength(10)]
        public string Cif { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int? Active { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        [Column("IBOSNo")]
        [StringLength(10)]
        public string Ibosno { get; set; }
        [StringLength(6)]
        public string Code { get; set; }
        [Column("SamedayFX")]
        public bool SamedayFx { get; set; }
        [Column("DepositALM")]
        public bool DepositAlm { get; set; }
    }
}
