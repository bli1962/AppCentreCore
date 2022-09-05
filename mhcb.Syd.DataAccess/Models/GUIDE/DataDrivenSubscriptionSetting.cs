using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("DataDrivenSubscription_Setting")]
    public partial class DataDrivenSubscriptionSetting
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("USER_ID")]
        [StringLength(20)]
        public string UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string Alias { get; set; }
        [Required]
        [Column("Email_Address")]
        [StringLength(50)]
        public string EmailAddress { get; set; }
        [Column("File_Name")]
        [StringLength(255)]
        public string FileName { get; set; }
        [StringLength(250)]
        public string Path { get; set; }
        [Column("Render_Format")]
        [StringLength(10)]
        public string RenderFormat { get; set; }
        [Column("Report_Include")]
        [StringLength(5)]
        public string ReportInclude { get; set; }
        [StringLength(5)]
        public string Linked { get; set; }
        [Column("FileEXTN")]
        public bool? FileExtn { get; set; }
        [StringLength(15)]
        public string WriteMode { get; set; }
        [StringLength(100)]
        public string Subject { get; set; }
        [StringLength(250)]
        public string Comments { get; set; }
        [Column("End_of_Day")]
        public bool? EndOfDay { get; set; }
        [Column("PW_Expired")]
        public bool? PwExpired { get; set; }
    }
}
