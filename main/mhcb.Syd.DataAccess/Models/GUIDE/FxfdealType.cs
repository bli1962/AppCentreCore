﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("FXFDealType", Schema = "dbo")]
    public partial class FxfdealType
    {
        [Key]
        [Column("DEALTYPE_ID")]
        public int DealtypeId { get; set; }
        [Column("TRANNAME")]
        [StringLength(30)]
        [Unicode(false)]
        public string Tranname { get; set; }
        [Column("DEALTYPE")]
        [StringLength(4)]
        [Unicode(false)]
        public string Dealtype { get; set; }
        [Column("SUBTYPE")]
        [StringLength(4)]
        [Unicode(false)]
        public string Subtype { get; set; }
        [Column("PROD_ID")]
        public short? ProdId { get; set; }
        public int? UseInCredit { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string ShortName { get; set; }
        [Column("FILimitType_ID")]
        public short? FilimitTypeId { get; set; }
        [Column("CorpLimitType_ID")]
        public short? CorpLimitTypeId { get; set; }
        [Column("CalcType_ID")]
        public short? CalcTypeId { get; set; }
        [Column("Productcode_ID")]
        public short? ProductcodeId { get; set; }
        [Column("FactorType_ID")]
        public short? FactorTypeId { get; set; }
        public bool? Active { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string Typology { get; set; }
        [StringLength(3)]
        [Unicode(false)]
        public string RefType { get; set; }
    }
}
