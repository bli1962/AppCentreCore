using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("LOAN_MASTER_RATING")]
    public partial class LoanMasterRating
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("LOAN_NO")]
        public int LoanNo { get; set; }
        [Required]
        [Column("RATING_TYPE")]
        [StringLength(25)]
        public string RatingType { get; set; }
        [Required]
        [Column("RATING_RANGE")]
        [StringLength(20)]
        public string RatingRange { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }

        [ForeignKey(nameof(LoanNo))]
        [InverseProperty(nameof(LoanMaster.LoanMasterRatings))]
        public virtual LoanMaster LoanNoNavigation { get; set; }
    }
}
