using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EDocument
{
    [Table("AdvanceNoticeDepositsConfirmationPaymentInfo")]
    public partial class AdvanceNoticeDepositsConfirmationPaymentInfo
    {
        [Key]
        public int Id { get; set; }
        [Column("CCYAbbr")]
        [StringLength(10)]
        public string Ccyabbr { get; set; }
        [Column("MHCBPayTo")]
        [StringLength(800)]
        public string MhcbpayTo { get; set; }
        [StringLength(800)]
        public string CustomerPayTo { get; set; }
    }
}
