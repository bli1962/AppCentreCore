using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("EndOfDayStart")]
    public partial class EndOfDayStart
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [StringLength(50)]
        public string VerifiedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? VerifiedWhen { get; set; }
        [StringLength(50)]
        public string AuthorisedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AuthorisedWhen { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
    }
}
