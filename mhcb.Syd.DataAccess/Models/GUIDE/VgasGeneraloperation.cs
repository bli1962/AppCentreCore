using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    public partial class VgasGeneraloperation
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
        [Column("VALUEDATE_DT", TypeName = "datetime")]
        public DateTime? ValuedateDt { get; set; }
        [Column("VALUEDATE_DT_DD")]
        [StringLength(2)]
        public string ValuedateDtDd { get; set; }
        [Column("VALUEDATE_DT_MM")]
        [StringLength(2)]
        public string ValuedateDtMm { get; set; }
        [Column("VALUEDATE_DT_YY")]
        [StringLength(2)]
        public string ValuedateDtYy { get; set; }
        [Column("DREAMS_REF_CODE")]
        [StringLength(12)]
        public string DreamsRefCode { get; set; }
        [Column("REMARKS_TX")]
        [StringLength(30)]
        public string RemarksTx { get; set; }
        [Column("BACKVALUE_IND")]
        [StringLength(1)]
        public string BackvalueInd { get; set; }
        [Column("DR_CCY_TX")]
        [StringLength(4)]
        public string DrCcyTx { get; set; }
        [Column("DR_CCY_UPLOAD")]
        [StringLength(4)]
        public string DrCcyUpload { get; set; }
        [Column("DR_AMOUNT_AMT")]
        [StringLength(30)]
        public string DrAmountAmt { get; set; }
        [Column("DR_CUSTID_TX")]
        [StringLength(12)]
        public string DrCustidTx { get; set; }
        [Column("DR_ACC_CD_TX")]
        [StringLength(5)]
        public string DrAccCdTx { get; set; }
        [Column("DR_ACCNUM_TX")]
        [StringLength(12)]
        public string DrAccnumTx { get; set; }
        [Column("DR_DETAILS_TX")]
        [StringLength(30)]
        public string DrDetailsTx { get; set; }
        [Column("DR_CHECKNO_TX")]
        [StringLength(10)]
        public string DrChecknoTx { get; set; }
        [Column("DR_ADVISEPRINT_TX")]
        [StringLength(1)]
        public string DrAdviseprintTx { get; set; }
        [Column("DR_FXCCY_TX")]
        [StringLength(4)]
        public string DrFxccyTx { get; set; }
        [Column("DR_FXCCY_UPLOAD")]
        [StringLength(4)]
        public string DrFxccyUpload { get; set; }
        [Column("DR_INTERRATE_INT", TypeName = "decimal(9, 5)")]
        public decimal? DrInterrateInt { get; set; }
        [Column("DR_EXCHRATE_INT", TypeName = "decimal(9, 5)")]
        public decimal? DrExchrateInt { get; set; }
        [Column("DR_ENTITY_TX")]
        [StringLength(3)]
        public string DrEntityTx { get; set; }
        [Column("DR_DIVISION_TX")]
        [StringLength(2)]
        public string DrDivisionTx { get; set; }
        [Column("STATUS_INT", TypeName = "decimal(18, 0)")]
        public decimal? StatusInt { get; set; }
        [Column("STATUS_DESC")]
        [StringLength(100)]
        public string StatusDesc { get; set; }
        [Column("TRANSNO_TX")]
        [StringLength(5)]
        public string TransnoTx { get; set; }
        [Column("DESCRIPTION_TX")]
        [StringLength(200)]
        public string DescriptionTx { get; set; }
        [Column("CREATED_BY")]
        [StringLength(8)]
        public string CreatedBy { get; set; }
        [Column("CREATED_DATE", TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("USERID")]
        [StringLength(8)]
        public string Userid { get; set; }
        [Column("LAST_EDITED_BY")]
        [StringLength(8)]
        public string LastEditedBy { get; set; }
        [Column("LAST_EDITED_DATE", TypeName = "datetime")]
        public DateTime? LastEditedDate { get; set; }
        [Column("UPLOADED_BY")]
        [StringLength(8)]
        public string UploadedBy { get; set; }
        [Column("UPLOADED_DATE", TypeName = "datetime")]
        public DateTime? UploadedDate { get; set; }
        [Column("APPROVED_BY")]
        [StringLength(8)]
        public string ApprovedBy { get; set; }
        [Column("APPROVED_DATE", TypeName = "datetime")]
        public DateTime? ApprovedDate { get; set; }
        [Column("DELETED_BY")]
        [StringLength(8)]
        public string DeletedBy { get; set; }
        [Column("DELETED_DATE", TypeName = "datetime")]
        public DateTime? DeletedDate { get; set; }
        [Column("DELETION_IND")]
        [StringLength(1)]
        public string DeletionInd { get; set; }
        [Column("REASON_TX")]
        [StringLength(30)]
        public string ReasonTx { get; set; }
        [Column("REVERSED_BY")]
        [StringLength(8)]
        public string ReversedBy { get; set; }
        [Column("FUND_TX")]
        [StringLength(1)]
        public string FundTx { get; set; }
        [Column("DR_IBF_TX")]
        [StringLength(1)]
        public string DrIbfTx { get; set; }
        [Column("CR1_TYPE_TX")]
        [StringLength(70)]
        public string Cr1TypeTx { get; set; }
        [Column("CR1_CCY_TX")]
        [StringLength(70)]
        public string Cr1CcyTx { get; set; }
        [Column("CR1_CCY_UPLOAD")]
        [StringLength(4)]
        public string Cr1CcyUpload { get; set; }
        [Column("CR1_AMOUNT_AMT")]
        [StringLength(30)]
        public string Cr1AmountAmt { get; set; }
        [Column("CR1_CUSTID_TX")]
        [StringLength(70)]
        public string Cr1CustidTx { get; set; }
        [Column("CR1_ACC_CD_TX")]
        [StringLength(70)]
        public string Cr1AccCdTx { get; set; }
        [Column("CR1_ACCNUM_TX")]
        [StringLength(70)]
        public string Cr1AccnumTx { get; set; }
        [Column("CR1_DETAILS_TX")]
        [StringLength(70)]
        public string Cr1DetailsTx { get; set; }
        [Column("CR1_CHECKNO_TX")]
        [StringLength(70)]
        public string Cr1ChecknoTx { get; set; }
        [Column("CR1_ADVISEPRINT_TX")]
        [StringLength(70)]
        public string Cr1AdviseprintTx { get; set; }
        [Column("CR1_FXCCY_TX")]
        [StringLength(70)]
        public string Cr1FxccyTx { get; set; }
        [Column("CR1_FXCCY_UPLOAD")]
        [StringLength(4)]
        public string Cr1FxccyUpload { get; set; }
        [Column("CR1_INTERRATE_INT")]
        [StringLength(70)]
        public string Cr1InterrateInt { get; set; }
        [Column("CR1_EXCHRATE_INT")]
        [StringLength(70)]
        public string Cr1ExchrateInt { get; set; }
        [Column("CR1_ENTITY_TX")]
        [StringLength(70)]
        public string Cr1EntityTx { get; set; }
        [Column("CR1_DIVISION_TX")]
        [StringLength(70)]
        public string Cr1DivisionTx { get; set; }
        [Column("CR1_FUND_TX")]
        [StringLength(70)]
        public string Cr1FundTx { get; set; }
        [Column("CR1_IBF_TX")]
        [StringLength(70)]
        public string Cr1IbfTx { get; set; }
        [Column("CR1_AVAILABLE_DATE")]
        [StringLength(70)]
        public string Cr1AvailableDate { get; set; }
        [Column("CR1_AVAILABLE_DATE_DD_DT")]
        [StringLength(70)]
        public string Cr1AvailableDateDdDt { get; set; }
        [Column("CR1_AVAILABLE_DATE_MM_DT")]
        [StringLength(70)]
        public string Cr1AvailableDateMmDt { get; set; }
        [Column("CR1_AVAILABLE_DATE_DD_YY")]
        [StringLength(70)]
        public string Cr1AvailableDateDdYy { get; set; }
        [Column("cr2_TYPE_TX")]
        [StringLength(70)]
        public string Cr2TypeTx { get; set; }
        [Column("cr2_CCY_TX")]
        [StringLength(70)]
        public string Cr2CcyTx { get; set; }
        [Column("cr2_CCY_UPLOAD")]
        [StringLength(4)]
        public string Cr2CcyUpload { get; set; }
        [Column("cr2_AMOUNT_AMT")]
        [StringLength(30)]
        public string Cr2AmountAmt { get; set; }
        [Column("cr2_CUSTID_TX")]
        [StringLength(70)]
        public string Cr2CustidTx { get; set; }
        [Column("cr2_ACC_CD_TX")]
        [StringLength(70)]
        public string Cr2AccCdTx { get; set; }
        [Column("cr2_ACCNUM_TX")]
        [StringLength(70)]
        public string Cr2AccnumTx { get; set; }
        [Column("cr2_DETAILS_TX")]
        [StringLength(70)]
        public string Cr2DetailsTx { get; set; }
        [Column("cr2_CHECKNO_TX")]
        [StringLength(70)]
        public string Cr2ChecknoTx { get; set; }
        [Column("cr2_ADVISEPRINT_TX")]
        [StringLength(70)]
        public string Cr2AdviseprintTx { get; set; }
        [Column("cr2_FXCCY_TX")]
        [StringLength(70)]
        public string Cr2FxccyTx { get; set; }
        [Column("cr2_FXCCY_UPLOAD")]
        [StringLength(4)]
        public string Cr2FxccyUpload { get; set; }
        [Column("cr2_INTERRATE_INT")]
        [StringLength(70)]
        public string Cr2InterrateInt { get; set; }
        [Column("cr2_EXCHRATE_INT")]
        [StringLength(70)]
        public string Cr2ExchrateInt { get; set; }
        [Column("cr2_ENTITY_TX")]
        [StringLength(70)]
        public string Cr2EntityTx { get; set; }
        [Column("cr2_DIVISION_TX")]
        [StringLength(70)]
        public string Cr2DivisionTx { get; set; }
        [Column("cr2_FUND_TX")]
        [StringLength(70)]
        public string Cr2FundTx { get; set; }
        [Column("cr2_IBF_TX")]
        [StringLength(70)]
        public string Cr2IbfTx { get; set; }
        [Column("cr2_AVAILABLE_DATE")]
        [StringLength(70)]
        public string Cr2AvailableDate { get; set; }
        [Column("cr2_AVAILABLE_DATE_DD_DT")]
        [StringLength(70)]
        public string Cr2AvailableDateDdDt { get; set; }
        [Column("cr2_AVAILABLE_DATE_MM_DT")]
        [StringLength(70)]
        public string Cr2AvailableDateMmDt { get; set; }
        [Column("cr2_AVAILABLE_DATE_DD_YY")]
        [StringLength(70)]
        public string Cr2AvailableDateDdYy { get; set; }
        [Column("cr3_TYPE_TX")]
        [StringLength(70)]
        public string Cr3TypeTx { get; set; }
        [Column("cr3_CCY_TX")]
        [StringLength(70)]
        public string Cr3CcyTx { get; set; }
        [Column("cr3_CCY_UPLOAD")]
        [StringLength(4)]
        public string Cr3CcyUpload { get; set; }
        [Column("cr3_AMOUNT_AMT")]
        [StringLength(30)]
        public string Cr3AmountAmt { get; set; }
        [Column("cr3_CUSTID_TX")]
        [StringLength(70)]
        public string Cr3CustidTx { get; set; }
        [Column("cr3_ACC_CD_TX")]
        [StringLength(70)]
        public string Cr3AccCdTx { get; set; }
        [Column("cr3_ACCNUM_TX")]
        [StringLength(70)]
        public string Cr3AccnumTx { get; set; }
        [Column("cr3_DETAILS_TX")]
        [StringLength(70)]
        public string Cr3DetailsTx { get; set; }
        [Column("cr3_CHECKNO_TX")]
        [StringLength(70)]
        public string Cr3ChecknoTx { get; set; }
        [Column("cr3_ADVISEPRINT_TX")]
        [StringLength(70)]
        public string Cr3AdviseprintTx { get; set; }
        [Column("cr3_FXCCY_TX")]
        [StringLength(70)]
        public string Cr3FxccyTx { get; set; }
        [Column("cr3_FXCCY_UPLOAD")]
        [StringLength(4)]
        public string Cr3FxccyUpload { get; set; }
        [Column("cr3_INTERRATE_INT")]
        [StringLength(70)]
        public string Cr3InterrateInt { get; set; }
        [Column("cr3_EXCHRATE_INT")]
        [StringLength(70)]
        public string Cr3ExchrateInt { get; set; }
        [Column("cr3_ENTITY_TX")]
        [StringLength(70)]
        public string Cr3EntityTx { get; set; }
        [Column("cr3_DIVISION_TX")]
        [StringLength(70)]
        public string Cr3DivisionTx { get; set; }
        [Column("cr3_FUND_TX")]
        [StringLength(70)]
        public string Cr3FundTx { get; set; }
        [Column("cr3_IBF_TX")]
        [StringLength(70)]
        public string Cr3IbfTx { get; set; }
        [Column("cr3_AVAILABLE_DATE")]
        [StringLength(70)]
        public string Cr3AvailableDate { get; set; }
        [Column("cr3_AVAILABLE_DATE_DD_DT")]
        [StringLength(70)]
        public string Cr3AvailableDateDdDt { get; set; }
        [Column("cr3_AVAILABLE_DATE_MM_DT")]
        [StringLength(70)]
        public string Cr3AvailableDateMmDt { get; set; }
        [Column("cr3_AVAILABLE_DATE_DD_YY")]
        [StringLength(70)]
        public string Cr3AvailableDateDdYy { get; set; }
        [Column("cr4_TYPE_TX")]
        [StringLength(70)]
        public string Cr4TypeTx { get; set; }
        [Column("cr4_CCY_TX")]
        [StringLength(70)]
        public string Cr4CcyTx { get; set; }
        [Column("cr4_CCY_UPLOAD")]
        [StringLength(4)]
        public string Cr4CcyUpload { get; set; }
        [Column("cr4_AMOUNT_AMT")]
        [StringLength(30)]
        public string Cr4AmountAmt { get; set; }
        [Column("cr4_CUSTID_TX")]
        [StringLength(70)]
        public string Cr4CustidTx { get; set; }
        [Column("cr4_ACC_CD_TX")]
        [StringLength(70)]
        public string Cr4AccCdTx { get; set; }
        [Column("cr4_ACCNUM_TX")]
        [StringLength(70)]
        public string Cr4AccnumTx { get; set; }
        [Column("cr4_DETAILS_TX")]
        [StringLength(70)]
        public string Cr4DetailsTx { get; set; }
        [Column("cr4_CHECKNO_TX")]
        [StringLength(70)]
        public string Cr4ChecknoTx { get; set; }
        [Column("cr4_ADVISEPRINT_TX")]
        [StringLength(70)]
        public string Cr4AdviseprintTx { get; set; }
        [Column("cr4_FXCCY_TX")]
        [StringLength(70)]
        public string Cr4FxccyTx { get; set; }
        [Column("cr4_FXCCY_UPLOAD")]
        [StringLength(4)]
        public string Cr4FxccyUpload { get; set; }
        [Column("cr4_INTERRATE_INT")]
        [StringLength(70)]
        public string Cr4InterrateInt { get; set; }
        [Column("cr4_EXCHRATE_INT")]
        [StringLength(70)]
        public string Cr4ExchrateInt { get; set; }
        [Column("cr4_ENTITY_TX")]
        [StringLength(70)]
        public string Cr4EntityTx { get; set; }
        [Column("cr4_DIVISION_TX")]
        [StringLength(70)]
        public string Cr4DivisionTx { get; set; }
        [Column("cr4_FUND_TX")]
        [StringLength(70)]
        public string Cr4FundTx { get; set; }
        [Column("cr4_IBF_TX")]
        [StringLength(70)]
        public string Cr4IbfTx { get; set; }
        [Column("cr4_AVAILABLE_DATE")]
        [StringLength(70)]
        public string Cr4AvailableDate { get; set; }
        [Column("cr4_AVAILABLE_DATE_DD_DT")]
        [StringLength(70)]
        public string Cr4AvailableDateDdDt { get; set; }
        [Column("cr4_AVAILABLE_DATE_MM_DT")]
        [StringLength(70)]
        public string Cr4AvailableDateMmDt { get; set; }
        [Column("cr4_AVAILABLE_DATE_DD_YY")]
        [StringLength(70)]
        public string Cr4AvailableDateDdYy { get; set; }
        [Column("cr5_TYPE_TX")]
        [StringLength(70)]
        public string Cr5TypeTx { get; set; }
        [Column("cr5_CCY_TX")]
        [StringLength(70)]
        public string Cr5CcyTx { get; set; }
        [Column("cr5_CCY_UPLOAD")]
        [StringLength(4)]
        public string Cr5CcyUpload { get; set; }
        [Column("cr5_AMOUNT_AMT")]
        [StringLength(30)]
        public string Cr5AmountAmt { get; set; }
        [Column("cr5_CUSTID_TX")]
        [StringLength(70)]
        public string Cr5CustidTx { get; set; }
        [Column("cr5_ACC_CD_TX")]
        [StringLength(70)]
        public string Cr5AccCdTx { get; set; }
        [Column("cr5_ACCNUM_TX")]
        [StringLength(70)]
        public string Cr5AccnumTx { get; set; }
        [Column("cr5_DETAILS_TX")]
        [StringLength(70)]
        public string Cr5DetailsTx { get; set; }
        [Column("cr5_CHECKNO_TX")]
        [StringLength(70)]
        public string Cr5ChecknoTx { get; set; }
        [Column("cr5_ADVISEPRINT_TX")]
        [StringLength(70)]
        public string Cr5AdviseprintTx { get; set; }
        [Column("cr5_FXCCY_TX")]
        [StringLength(70)]
        public string Cr5FxccyTx { get; set; }
        [Column("cr5_FXCCY_UPLOAD")]
        [StringLength(4)]
        public string Cr5FxccyUpload { get; set; }
        [Column("cr5_INTERRATE_INT")]
        [StringLength(70)]
        public string Cr5InterrateInt { get; set; }
        [Column("cr5_EXCHRATE_INT")]
        [StringLength(70)]
        public string Cr5ExchrateInt { get; set; }
        [Column("cr5_ENTITY_TX")]
        [StringLength(70)]
        public string Cr5EntityTx { get; set; }
        [Column("cr5_DIVISION_TX")]
        [StringLength(70)]
        public string Cr5DivisionTx { get; set; }
        [Column("cr5_FUND_TX")]
        [StringLength(70)]
        public string Cr5FundTx { get; set; }
        [Column("cr5_IBF_TX")]
        [StringLength(70)]
        public string Cr5IbfTx { get; set; }
        [Column("cr5_AVAILABLE_DATE")]
        [StringLength(70)]
        public string Cr5AvailableDate { get; set; }
        [Column("cr5_AVAILABLE_DATE_DD_DT")]
        [StringLength(70)]
        public string Cr5AvailableDateDdDt { get; set; }
        [Column("cr5_AVAILABLE_DATE_MM_DT")]
        [StringLength(70)]
        public string Cr5AvailableDateMmDt { get; set; }
        [Column("cr5_AVAILABLE_DATE_DD_YY")]
        [StringLength(70)]
        public string Cr5AvailableDateDdYy { get; set; }
        [Column("cr6_TYPE_TX")]
        [StringLength(70)]
        public string Cr6TypeTx { get; set; }
        [Column("cr6_CCY_TX")]
        [StringLength(70)]
        public string Cr6CcyTx { get; set; }
        [Column("cr6_CCY_UPLOAD")]
        [StringLength(4)]
        public string Cr6CcyUpload { get; set; }
        [Column("cr6_AMOUNT_AMT")]
        [StringLength(30)]
        public string Cr6AmountAmt { get; set; }
        [Column("cr6_CUSTID_TX")]
        [StringLength(70)]
        public string Cr6CustidTx { get; set; }
        [Column("cr6_ACC_CD_TX")]
        [StringLength(70)]
        public string Cr6AccCdTx { get; set; }
        [Column("cr6_ACCNUM_TX")]
        [StringLength(70)]
        public string Cr6AccnumTx { get; set; }
        [Column("cr6_DETAILS_TX")]
        [StringLength(70)]
        public string Cr6DetailsTx { get; set; }
        [Column("cr6_CHECKNO_TX")]
        [StringLength(70)]
        public string Cr6ChecknoTx { get; set; }
        [Column("cr6_ADVISEPRINT_TX")]
        [StringLength(70)]
        public string Cr6AdviseprintTx { get; set; }
        [Column("cr6_FXCCY_TX")]
        [StringLength(70)]
        public string Cr6FxccyTx { get; set; }
        [Column("cr6_FXCCY_UPLOAD")]
        [StringLength(4)]
        public string Cr6FxccyUpload { get; set; }
        [Column("cr6_INTERRATE_INT")]
        [StringLength(70)]
        public string Cr6InterrateInt { get; set; }
        [Column("cr6_EXCHRATE_INT")]
        [StringLength(70)]
        public string Cr6ExchrateInt { get; set; }
        [Column("cr6_ENTITY_TX")]
        [StringLength(70)]
        public string Cr6EntityTx { get; set; }
        [Column("cr6_DIVISION_TX")]
        [StringLength(70)]
        public string Cr6DivisionTx { get; set; }
        [Column("cr6_FUND_TX")]
        [StringLength(70)]
        public string Cr6FundTx { get; set; }
        [Column("cr6_IBF_TX")]
        [StringLength(70)]
        public string Cr6IbfTx { get; set; }
        [Column("cr6_AVAILABLE_DATE")]
        [StringLength(70)]
        public string Cr6AvailableDate { get; set; }
        [Column("cr6_AVAILABLE_DATE_DD_DT")]
        [StringLength(70)]
        public string Cr6AvailableDateDdDt { get; set; }
        [Column("cr6_AVAILABLE_DATE_MM_DT")]
        [StringLength(70)]
        public string Cr6AvailableDateMmDt { get; set; }
        [Column("cr6_AVAILABLE_DATE_DD_YY")]
        [StringLength(70)]
        public string Cr6AvailableDateDdYy { get; set; }
        [Column("cr7_TYPE_TX")]
        [StringLength(70)]
        public string Cr7TypeTx { get; set; }
        [Column("cr7_CCY_TX")]
        [StringLength(70)]
        public string Cr7CcyTx { get; set; }
        [Column("cr7_CCY_UPLOAD")]
        [StringLength(4)]
        public string Cr7CcyUpload { get; set; }
        [Column("cr7_AMOUNT_AMT")]
        [StringLength(30)]
        public string Cr7AmountAmt { get; set; }
        [Column("cr7_CUSTID_TX")]
        [StringLength(70)]
        public string Cr7CustidTx { get; set; }
        [Column("cr7_ACC_CD_TX")]
        [StringLength(70)]
        public string Cr7AccCdTx { get; set; }
        [Column("cr7_ACCNUM_TX")]
        [StringLength(70)]
        public string Cr7AccnumTx { get; set; }
        [Column("cr7_DETAILS_TX")]
        [StringLength(70)]
        public string Cr7DetailsTx { get; set; }
        [Column("cr7_CHECKNO_TX")]
        [StringLength(70)]
        public string Cr7ChecknoTx { get; set; }
        [Column("cr7_ADVISEPRINT_TX")]
        [StringLength(70)]
        public string Cr7AdviseprintTx { get; set; }
        [Column("cr7_FXCCY_TX")]
        [StringLength(70)]
        public string Cr7FxccyTx { get; set; }
        [Column("cr7_FXCCY_UPLOAD")]
        [StringLength(4)]
        public string Cr7FxccyUpload { get; set; }
        [Column("cr7_INTERRATE_INT")]
        [StringLength(70)]
        public string Cr7InterrateInt { get; set; }
        [Column("cr7_EXCHRATE_INT")]
        [StringLength(70)]
        public string Cr7ExchrateInt { get; set; }
        [Column("cr7_ENTITY_TX")]
        [StringLength(70)]
        public string Cr7EntityTx { get; set; }
        [Column("cr7_DIVISION_TX")]
        [StringLength(70)]
        public string Cr7DivisionTx { get; set; }
        [Column("cr7_FUND_TX")]
        [StringLength(70)]
        public string Cr7FundTx { get; set; }
        [Column("cr7_IBF_TX")]
        [StringLength(70)]
        public string Cr7IbfTx { get; set; }
        [Column("cr7_AVAILABLE_DATE")]
        [StringLength(70)]
        public string Cr7AvailableDate { get; set; }
        [Column("cr7_AVAILABLE_DATE_DD_DT")]
        [StringLength(70)]
        public string Cr7AvailableDateDdDt { get; set; }
        [Column("cr7_AVAILABLE_DATE_MM_DT")]
        [StringLength(70)]
        public string Cr7AvailableDateMmDt { get; set; }
        [Column("cr7_AVAILABLE_DATE_DD_YY")]
        [StringLength(70)]
        public string Cr7AvailableDateDdYy { get; set; }
        [Column("UPLOADED_PASSWORD")]
        [StringLength(68)]
        public string UploadedPassword { get; set; }
        [Column("REVERSED_PASSWORD")]
        [StringLength(68)]
        public string ReversedPassword { get; set; }
        [Column("DELETED_PASSWORD")]
        [StringLength(68)]
        public string DeletedPassword { get; set; }
        [Column("HOST_NAME")]
        [StringLength(120)]
        public string HostName { get; set; }
        [Column("ENCRYPT_IND")]
        [StringLength(1)]
        public string EncryptInd { get; set; }
        [Column("AVAILDATE_DT_DD")]
        [StringLength(2)]
        public string AvaildateDtDd { get; set; }
        [Column("AVAILDATE_DT_MM")]
        [StringLength(2)]
        public string AvaildateDtMm { get; set; }
        [Column("AVAILDATE_DT_YY")]
        [StringLength(2)]
        public string AvaildateDtYy { get; set; }
        [Column("APPROVED_PASSWORD")]
        [StringLength(68)]
        public string ApprovedPassword { get; set; }
        [Column("TRAN_TYPE")]
        [StringLength(1)]
        public string TranType { get; set; }
        [Column("BULK_UPLOAD_IND")]
        [StringLength(1)]
        public string BulkUploadInd { get; set; }
        [Column("EXPORTED_DT", TypeName = "datetime")]
        public DateTime? ExportedDt { get; set; }
    }
}
