using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("CUST_MASTER_BAK20090423")]
    public partial class CustMasterBak20090423
    {
        [Key]
        [Column("CUST_ID")]
        public int CustId { get; set; }
        [Required]
        [Column("CUST_ABBR")]
        [StringLength(20)]
        public string CustAbbr { get; set; }
        [Required]
        [Column("CUST_NAME")]
        [StringLength(50)]
        public string CustName { get; set; }
        [Required]
        [Column("CUST_TYPE")]
        [StringLength(3)]
        public string CustType { get; set; }
        [Column("ACTIVE")]
        public bool Active { get; set; }
        [Required]
        [Column("ADDRESS_1")]
        [StringLength(50)]
        public string Address1 { get; set; }
        [Required]
        [Column("ADDRESS_2")]
        [StringLength(50)]
        public string Address2 { get; set; }
        [Required]
        [Column("ADDRESS_3")]
        [StringLength(50)]
        public string Address3 { get; set; }
        [Required]
        [Column("ADDRESS_4")]
        [StringLength(50)]
        public string Address4 { get; set; }
        [Required]
        [Column("CONTACT")]
        [StringLength(50)]
        public string Contact { get; set; }
        [Required]
        [Column("POSITIONS")]
        [StringLength(50)]
        public string Positions { get; set; }
        [Required]
        [Column("FAX_NO")]
        [StringLength(30)]
        public string FaxNo { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("PREP_BY")]
        [StringLength(6)]
        public string PrepBy { get; set; }
        [Column("PREP_ON", TypeName = "datetime")]
        public DateTime? PrepOn { get; set; }
        [Column("APPR_BY")]
        [StringLength(6)]
        public string ApprBy { get; set; }
        [Column("APPR_ON", TypeName = "datetime")]
        public DateTime? ApprOn { get; set; }
    }
}
