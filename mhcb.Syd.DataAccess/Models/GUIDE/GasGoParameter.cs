using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("GAS_GO_PARAMETER")]
    public partial class GasGoParameter
    {
        [Column("TYPE_TX")]
        [StringLength(2)]
        public string TypeTx { get; set; }
        [Column("ACUBU_TX")]
        [StringLength(3)]
        public string AcubuTx { get; set; }
        [Column("BACKVALUE_IND")]
        [StringLength(1)]
        public string BackvalueInd { get; set; }
        [Column("DR_ACC_CODE_TX")]
        [StringLength(5)]
        public string DrAccCodeTx { get; set; }
        [Column("DR_ENTITY_TX")]
        [StringLength(3)]
        public string DrEntityTx { get; set; }
        [Column("DR_DIVISION_TX")]
        [StringLength(3)]
        public string DrDivisionTx { get; set; }
        [Column("CR_ACC_CODE_TX")]
        [StringLength(5)]
        public string CrAccCodeTx { get; set; }
        [Column("CR_ENTITY_TX")]
        [StringLength(3)]
        public string CrEntityTx { get; set; }
        [Column("CR_DIVISION_TX")]
        [StringLength(3)]
        public string CrDivisionTx { get; set; }
        [Column("EXCHRATE_IND")]
        [StringLength(1)]
        public string ExchrateInd { get; set; }
        [Column("REMARKS_TX")]
        [StringLength(30)]
        public string RemarksTx { get; set; }
        [Column("DR_CHECKNO_TX")]
        [StringLength(10)]
        public string DrChecknoTx { get; set; }
        [Column("CR_CHECKNO_TX")]
        [StringLength(10)]
        public string CrChecknoTx { get; set; }
    }
}
