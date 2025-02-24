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

    public class CustInfohModel
    {
        //[Required(ErrorMessage = "Customer Abbreviation required")]
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

    public class DistributionPreferenceSearchModel
    {
        [Required(ErrorMessage = "Application is required")]
        public string AppName { get; set; }
    }


    public class DistributionPasswordSearchModel
    {
        public string Abbreviation { get; set; }
        public string Branch { get; set; }
        public string Name { get; set; }
        public string CustomerCode { get; set; }
        public string Code { get; set; }
    }


    public class InputBIF
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

    public class InputSIF
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

    public class InputFXTrans
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


    public class InputFXFCustomer
    {
        [Required(ErrorMessage = "Customer Abbreviation Id is required")]
        public string Abbreviation { get; set; }
        public string DeptCode { get; set; }
        public string TaxCode { get; set; }
        public string Status { get; set; }
        public string AuthorizeBy { get; set; }
    }

    public class InputGuideUser
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

    public class InputFXGID
    {
        [Required(ErrorMessage = "GBASE Reference is required")]
        [StringLength(12, MinimumLength = 12, ErrorMessage = "GBASE Reference must be 12 characters")]
        public string RefNo { get; set; }
        //public string optDate { get; set; }
        public DateTime optDate { get; set; }
        public string AuthorizeBy { get; set; }
    }

    public class InputMMGID
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


    public class InputGAS
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

    public class InputEucBalance
    {
        [Required(ErrorMessage = "GBASE Reference is required")]
        [StringLength(14, MinimumLength = 12, ErrorMessage = "GBASE Reference must be 14 characters")]
        public string GBaseReferenceNo { get; set; }
        public string AuthorizeBy { get; set; }
        //public DateTime updateDate { get; set; }
    }

    public class InputEDocument
    {
        [Required(ErrorMessage = "eDocument Id required")]
        [Range(1, int.MaxValue, ErrorMessage = "eDocument ID should be greater than 1")]
        public int Id { get; set; }
        public string ReportType { get; set; }
        //public string AccountNo { get; set; }
        public string AuthorizeBy { get; set; }
    }


    // this is the confirmation send from eLCS
    public class InputEDistribution
    {
        [Required(ErrorMessage = "eDistribution Id required")]
        [Range(1, int.MaxValue, ErrorMessage = "eDistribution ID should be greater than 1")]
        public int Id { get; set; }
        public string AuthorizeBy { get; set; }
    }


    public class InputSwiftPayment
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

    public class InputFacilityType
    {
        [Required]
        [StringLength(25)]
        public string RefNo { get; set; }
        [Required]
        [StringLength(30)]
        public string FacilityType { get; set; }
        public string AuthorizeBy { get; set; }
    }

    public class InputRate
    {
        public string CcyCode { get; set; }
        public decimal Rate { get; set; }
        public string AuthorizeBy { get; set; }
    }

    public class InputOnDemandBatch
    {
        public int BatchId { get; set; }
        public int BatchNo { get; set; }
        public string AuthorizeBy { get; set; }
    }

	public class InputTrancheType
	{
		public string TrancheType { get; set; }
		public string TrancheTypeDesc { get; set; }
		public string AuthorizeBy { get; set; }
	}

	public class InputCovenantCondition
	{
		public string conditionDesc { get; set; }
		public string conditionGroupDesc { get; set; }
		public string AuthorizeBy { get; set; }
	}

	public class InputCovenantReceiptTiming
	{
		public int TimingType { get; set; }
		public string TimingDesc { get; set; }
		public int Interval { get; set; }
		public string DatePart { get; set; }
		public int Order { get; set; }
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
