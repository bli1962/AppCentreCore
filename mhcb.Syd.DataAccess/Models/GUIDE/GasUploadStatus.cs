using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("GAS_UPLOAD_STATUS")]
    public partial class GasUploadStatus
    {
        [Required]
        [Column("FILE_TYPE")]
        [StringLength(2)]
        public string FileType { get; set; }
        [Required]
        [Column("UPLOAD_CODE")]
        [StringLength(2)]
        public string UploadCode { get; set; }
        [Required]
        [Column("UPLOAD_TAG")]
        [StringLength(3)]
        public string UploadTag { get; set; }
        [Column("DESCRIPTION_TX")]
        [StringLength(40)]
        public string DescriptionTx { get; set; }
    }
}
