using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MGeBTransactionConfirmation")]
    public partial class MgeBtransactionConfirmation
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("gBaseDocumentId")]
        public int GBaseDocumentId { get; set; }
        [Required]
        [Column("MGeBCustomerUnitCode")]
        [StringLength(12)]
        public string MgeBcustomerUnitCode { get; set; }
        [Required]
        [StringLength(100)]
        public string ReferenceNumber { get; set; }
        [Required]
        [StringLength(14)]
        public string FileIdentificationName { get; set; }
        [Required]
        [StringLength(1000)]
        public string ControlFilename { get; set; }
        [Required]
        [StringLength(1000)]
        public string TransactionDataFileName { get; set; }
        [StringLength(2000)]
        public string AttachmentList { get; set; }
        [Required]
        [StringLength(1000)]
        public string ConfirmationFilename { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime AddDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime GenerateDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SendDate { get; set; }
        [StringLength(1000)]
        public string ImportResultFilename { get; set; }
        public int ImportStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ImportDate { get; set; }
        [StringLength(4000)]
        public string ImportErrorMessage { get; set; }
        [StringLength(1000)]
        public string AnswerFilename { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AnswerDate { get; set; }
        [StringLength(100)]
        public string AnswerStatus { get; set; }
        [StringLength(100)]
        public string AnswerResponse { get; set; }
        [StringLength(1000)]
        public string AnswerResponseDetail { get; set; }
    }
}
