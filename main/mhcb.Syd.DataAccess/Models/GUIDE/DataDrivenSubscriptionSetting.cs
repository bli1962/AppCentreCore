using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("DataDrivenSubscription_Setting", Schema = "dbo")]
    public partial class DataDrivenSubscriptionSetting
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("USER_ID")]
        [StringLength(20)]
        [Unicode(false)]
        public string UserId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Alias { get; set; }
        [Required]
        [Column("Email_Address")]
        [StringLength(50)]
        [Unicode(false)]
        public string EmailAddress { get; set; }
        [Column("File_Name")]
        [StringLength(255)]
        [Unicode(false)]
        public string FileName { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string Path { get; set; }
        [Column("Render_Format")]
        [StringLength(10)]
        [Unicode(false)]
        public string RenderFormat { get; set; }
        [Column("Report_Include")]
        [StringLength(5)]
        [Unicode(false)]
        public string ReportInclude { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string Linked { get; set; }
        [Column("FileEXTN")]
        public bool? FileExtn { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string WriteMode { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Subject { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string Comments { get; set; }
        [Column("End_of_Day")]
        public bool? EndOfDay { get; set; }
        [Column("PW_Expired")]
        public bool? PwExpired { get; set; }
    }
}
