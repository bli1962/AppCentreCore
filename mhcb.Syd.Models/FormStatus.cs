using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Models
{
    public class CustSearchModel
    {
        [Required(ErrorMessage = "Customer Abbreviation required")]
        public string CustAbbr { get; set; }

        [Required(ErrorMessage = "Branch No is required")]
        [StringLength(3, ErrorMessage = "Branch No is 3 characters long.")]
        public string BranchNo { get; set; }

        [Required(ErrorMessage = "Customer Name required")]
        public string CustName { get; set; }
    }
    public class SwiftSearchModel
    {
        [Required(ErrorMessage = "Swift Id required")]
        public string SwiftId { get; set; }
    }

    public class SIFSearchModel
    {
        [Required(ErrorMessage = "SIF Id required")]
        public string SifID { get; set; }
    }
    public class UserSearchModel
    {
        [Required(ErrorMessage = "User Id required")]
        public string UserID { get; set; }
    }

    public class GBASESearchModel
    {
        [Required(ErrorMessage = "GBASE Ref required")]
        [MinLength(12, ErrorMessage = "GBASE Ref is at least 12 characters long.")]
        public string RefNo { get; set; }
    }


    public class SearchModel
    {
        [Required(ErrorMessage = "Document Id is required")]
        [MinLength(6, ErrorMessage = "Document Id is long then 6 number.")]
        //[StringLength(6, ErrorMessage = "xxx is too long.")]
        public string DocumentID { get; set; }

        [Required(ErrorMessage = "Customer Abbreviation required")]
        public string CustAbbr { get; set; }

        //public string AuthorizeBy { get; set; }
        //public string Status { get; set; }
        //public string DeletionStatus { get; set; }
        //public string GipStatus { get; set; }
        //public string GipDescription { get; set; }

        //[Required(ErrorMessage = "Tran No. is required")]
        //public string TranNo { get; set; }
    }

    public class BankInfStatus
    {
        [Required(ErrorMessage = "Swift Id is required")]
        [MinLength(2)]
        public string SwiftId { get; set; }

        public string AuthorizeBy { get; set; }
        public string Status { get; set; }
        public string DeletionStatus { get; set; }
        public string GipStatus { get; set; }
        public string GipDescription { get; set; }

        [Required(ErrorMessage = "Tran No. is required")]
        public string TranNo { get; set; }
    }

    public class SIFStatus
    {
        [Required(ErrorMessage = "SIF Id is required")]
        public int SifId { get; set; }
        public string AuthorizeBy { get; set; }
        public string Status { get; set; }
        public string DeletionStatus { get; set; }
        public string GipStatus { get; set; }
        public string GipDescription { get; set; }

        [Required(ErrorMessage = "Tran No. Id is required")]
        public string TranNo { get; set; }
    }


    public class FXTranStatus
    {
        [Required(ErrorMessage="GBASE Reference is required")]
        [StringLength(12, MinimumLength = 12, ErrorMessage = "GBASE Reference must be 12 characters")]
        public string RefNo { get; set; }
        public string AuthorizeBy { get; set; }
        public string Status { get; set; }
        public string DeletionStatus { get; set; }
        public string GipStatus { get; set; }
        public string GipDescription { get; set; }

        [Required(ErrorMessage = "Tran No. is required")]
        public string TranNo { get; set; }
    }


    public class FXFCustAttribute
    {
        [Required(ErrorMessage = "Customer Abbreviation Id is required")]
        public string Abbreviation { get; set; }
        public string DeptCode { get; set; }
        public string TaxCode { get; set; }
        public string Status { get; set; }
        public string AuthorizeBy { get; set; }
    }

    public class UserAttribute
    {
        public string UserId { get; set; }
        //public string PWD_CHANGE_IND { get; set; }
        //public string RACF_STATUS_CODE { get; set; }
        //public string BU_STATUS_CODE { get; set; }
        //public string ACU_STATUS_CODE { get; set; }
        //public string NO_OF_LOGIN_ATTEMPTS { get; set; }
        //public string ENABLED_IND { get; set; }
        //public string PWD_CREATE_DATE { get; set; }
        public string Password { get; set; }
        //public string RACF_PREVIOUS_PWD { get; set; }
        //public string GBASE_PREVIOUS_PWD { get; set; }
    }

    public class FXGIDStatus
    {
        [Required(ErrorMessage = "GBASE Reference is required")]
        [StringLength(12, MinimumLength = 12, ErrorMessage = "GBASE Reference must be 12 characters")]
        public string RefNo { get; set; }
        //public string optDate { get; set; }
        public DateTime optDate { get; set; }
        public string AuthorizeBy { get; set; }
    }

    public class MMGIDStatus
    {
        [Required(ErrorMessage = "MoneyMarket Ticket ID is required")]
        [Range(1, int.MaxValue, ErrorMessage = "MMTicket ID should be greater than 1")]
        public int TicketId { get; set; }
        //public string optDate { get; set; }
        public DateTime optDate { get; set; }
        public string AuthorizeBy { get; set; }
    }

    public class DomesticClearingAttribute
    {
        [Required(ErrorMessage = "Payment ID is required")]
        public int PaymentId { get; set; }
        //public string optDate { get; set; }
        public DateTime optDate { get; set; }
        public int StatusId { get; set; }
        public string Comment { get; set; }
        public string AuthorizeBy { get; set; }
    }


    public class GASAttribute
    {
        [Required(ErrorMessage = "Min No required")]
        public string MinNo { get; set; }
        public int StatusId { get; set; }
        public string AuthorizeBy { get; set; }
        //public string valueDate { get; set; }
        public DateTime valueDate { get; set; }
        public string HasDCSPayment { get; set; }
    }

    public class FXDeliveryCorp
    {
        public string Date { get; set; }
        public int Summary { get; set; }
    }

    public class EucBalanceAttribute
    {
        [Required(ErrorMessage = "GBASE Reference is required")]
        [StringLength(14, MinimumLength = 12, ErrorMessage = "GBASE Reference must be 14 characters")]
        public string GBaseReferenceNo { get; set; }
        public string AuthorizeBy { get; set; }
        //public DateTime updateDate { get; set; }
    }

    public class EDocumentAttribute
    {
        [Required(ErrorMessage = "eDocument Id required")]
        [Range(1, int.MaxValue, ErrorMessage = "eDocument ID should be greater than 1")]
        public int Id { get; set; }
        public string ReportType { get; set; }
        //public string AccountNo { get; set; }
        public string AuthorizeBy { get; set; }
    }


    public class SwiftPaymentStatus
    {
        [Required(ErrorMessage = "Payment Id required")]
        [Range(1, int.MaxValue, ErrorMessage = "Payment ID should be greater than 1")]
        public int PaymentId { get; set; }

        [Required(ErrorMessage = "SwiftPayment Id required")]
        [Range(1, int.MaxValue, ErrorMessage = "SwiftPayment ID should be greater than 1")]
        public int SwiftPaymentId { get; set; }
        public int StatusId { get; set; }
        public string AuthorizeBy { get; set; }
    }

    public class RateAttribute
    {
        public string CcyCode { get; set; }
        public decimal Rate { get; set; }
        public string AuthorizeBy { get; set; }
    }

    public class OnDemandBatchAttribute
    {
        public int BatchId { get; set; }
        public int BatchNo { get; set; }
        public string AuthorizeBy { get; set; }
    }
    public class FacilityTypeAttribute
    {
        [Required]
        [StringLength(25)]
        public string RefNo { get; set; }
        [Required]
        [StringLength(30)]
        public string FacilityType { get; set; }
        public string AuthorizeBy { get; set; }
    }


    //public class ExampleModel
    //{
    //    [HiddenInput(DisplayValue = false)]
    //    public int OrderID { get; set; }

    //    [Required]
    //    [Display(Name = "Customer")]
    //    public string CustomerID { get; set; }

    //    [Required]
    //    [StringLength(15)]
    //    [Display(Name = "Ship Country")]
    //    public string ShipCountry { get; set; }

    //    [Required]
    //    [Range(1, int.MaxValue, ErrorMessage = "Freight should be greater than 1")]
    //    [DataType(DataType.Currency)]
    //    public decimal? Freight { get; set; }

    //    [Required]
    //    [Display(Name = "Order Date")]
    //    public DateTime? OrderDate { get; set; }
    //}

}
