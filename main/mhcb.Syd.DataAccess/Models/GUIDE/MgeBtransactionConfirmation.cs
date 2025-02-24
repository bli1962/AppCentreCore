using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MGeBTransactionConfirmation", Schema = "dbo")]
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
        [Unicode(false)]
        public string MgeBcustomerUnitCode { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string ReferenceNumber { get; set; }
        [Required]
        [StringLength(14)]
        [Unicode(false)]
        public string FileIdentificationName { get; set; }
        [Required]
        [StringLength(1000)]
        [Unicode(false)]
        public string ControlFilename { get; set; }
        [Required]
        [StringLength(1000)]
        [Unicode(false)]
        public string TransactionDataFileName { get; set; }
        [StringLength(2000)]
        [Unicode(false)]
        public string AttachmentList { get; set; }
        [Required]
        [StringLength(1000)]
        [Unicode(false)]
        public string ConfirmationFilename { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime AddDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? GenerateDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SendDate { get; set; }
        [StringLength(1000)]
        [Unicode(false)]
        public string ImportResultFilename { get; set; }
        public int ImportStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ImportDate { get; set; }
        [StringLength(4000)]
        [Unicode(false)]
        public string ImportErrorMessage { get; set; }
        [StringLength(1000)]
        [Unicode(false)]
        public string AnswerFilename { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AnswerDate { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string AnswerStatus { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string AnswerResponse { get; set; }
        [StringLength(1000)]
        [Unicode(false)]
        public string AnswerResponseDetail { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeleteDate { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string DeleteBy { get; set; }
        [Column(TypeName = "text")]
        public string SendErrorMessage { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SendErrorDate { get; set; }
    }
}
