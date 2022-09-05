using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    public partial class VgasSelectwebgastransaction
    {
        [Required]
        [Column("MIN_NO")]
        [StringLength(18)]
        public string MinNo { get; set; }
        [Column("TYPE_TX")]
        [StringLength(2)]
        public string TypeTx { get; set; }
        [Required]
        [Column("GROUPNO_TX")]
        [StringLength(2)]
        public string GroupnoTx { get; set; }
        [Column("ACUBU_TX")]
        [StringLength(3)]
        public string AcubuTx { get; set; }
        [Column("VALUEDATE_DT")]
        [StringLength(11)]
        public string ValuedateDt { get; set; }
        [Column("DREAMS_REF_CODE")]
        [StringLength(12)]
        public string DreamsRefCode { get; set; }
        [Column("REMARKS_TX")]
        [StringLength(30)]
        public string RemarksTx { get; set; }
        [Column("BACKVALUE_IND")]
        [StringLength(1)]
        public string BackvalueInd { get; set; }
        [Column("CCY_TX")]
        [StringLength(4)]
        public string CcyTx { get; set; }
        [Column("AMOUNT_AMT", TypeName = "decimal(16, 2)")]
        public decimal? AmountAmt { get; set; }
        [Column("CUSTID_TX")]
        [StringLength(12)]
        public string CustidTx { get; set; }
        [Column("ACC_CD_TX")]
        [StringLength(5)]
        public string AccCdTx { get; set; }
        [Column("ACCNUM_TX")]
        [StringLength(12)]
        public string AccnumTx { get; set; }
        [Column("DETAILS_TX")]
        [StringLength(30)]
        public string DetailsTx { get; set; }
        [Column("CHECKNO_TX")]
        [StringLength(10)]
        public string ChecknoTx { get; set; }
        [Column("ADVISEPRINT_TX")]
        [StringLength(1)]
        public string AdviseprintTx { get; set; }
        [Column("FXCCY_TX")]
        [StringLength(4)]
        public string FxccyTx { get; set; }
        [Column("INTERRATE_INT", TypeName = "decimal(9, 5)")]
        public decimal? InterrateInt { get; set; }
        [Column("EXCHRATE_INT", TypeName = "decimal(9, 5)")]
        public decimal? ExchrateInt { get; set; }
        [Column("ENTITY_TX")]
        [StringLength(3)]
        public string EntityTx { get; set; }
        [Column("DIVISION_TX")]
        [StringLength(2)]
        public string DivisionTx { get; set; }
        [Column("DESCRIPTION_TX")]
        [StringLength(200)]
        public string DescriptionTx { get; set; }
        [Column("CREATED_BY")]
        [StringLength(8)]
        public string CreatedBy { get; set; }
        [Column("CREATED_DATE")]
        [StringLength(11)]
        public string CreatedDate { get; set; }
        [Column("LAST_EDITED_BY")]
        [StringLength(8)]
        public string LastEditedBy { get; set; }
        [Column("LAST_EDITED_DATE")]
        [StringLength(11)]
        public string LastEditedDate { get; set; }
        [Column("APPROVED_BY")]
        [StringLength(8)]
        public string ApprovedBy { get; set; }
        [Column("APPROVED_DATE")]
        [StringLength(11)]
        public string ApprovedDate { get; set; }
        [Column("DELETED_BY")]
        [StringLength(8)]
        public string DeletedBy { get; set; }
        [Column("DELETED_DATE")]
        [StringLength(11)]
        public string DeletedDate { get; set; }
        [Column("DELETION_IND")]
        [StringLength(1)]
        public string DeletionInd { get; set; }
        [Column("REASON_TX")]
        [StringLength(30)]
        public string ReasonTx { get; set; }
        [Column("UPLOADED_BY")]
        [StringLength(8)]
        public string UploadedBy { get; set; }
        [Column("UPLOADED_DATE")]
        [StringLength(11)]
        public string UploadedDate { get; set; }
        [Column("REVERSED_BY")]
        [StringLength(8)]
        public string ReversedBy { get; set; }
        [Column("REVERSED_DATE")]
        [StringLength(11)]
        public string ReversedDate { get; set; }
        [Column("TRANSNO_TX")]
        [StringLength(5)]
        public string TransnoTx { get; set; }
        [Column("STATUS_INT", TypeName = "decimal(18, 0)")]
        public decimal? StatusInt { get; set; }
        [Column("TRAN_TYPE")]
        [StringLength(1)]
        public string TranType { get; set; }
        [Column("FUND_TX")]
        [StringLength(1)]
        public string FundTx { get; set; }
        [Column("NAME")]
        [StringLength(40)]
        public string Name { get; set; }
        [Required]
        [Column("RECORD_TYPE")]
        [StringLength(1)]
        public string RecordType { get; set; }
        [Column("STATUS_CODE_DESC")]
        [StringLength(100)]
        public string StatusCodeDesc { get; set; }
        [Column("SEQ_NO", TypeName = "decimal(18, 0)")]
        public decimal? SeqNo { get; set; }
        [Column("RECTYPE_TX")]
        [StringLength(1)]
        public string RectypeTx { get; set; }
        [Column("BULK_UPLOAD_IND")]
        [StringLength(1)]
        public string BulkUploadInd { get; set; }
        [Column("IBF_TX")]
        [StringLength(1)]
        public string IbfTx { get; set; }
        [Column("AVAILABLE_DATE")]
        [StringLength(11)]
        public string AvailableDate { get; set; }
    }
}
