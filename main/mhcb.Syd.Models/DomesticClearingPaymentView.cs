using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Models
{
    public class DomesticClearingPaymentView
    {
        public int PaymentId { get; set; }
        public DateTime ValueDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal? Fees { get; set; }
        public string CurrencyCode { get; set; }
        public string CustomerCurrentAccount { get; set; } 
        public DateTime UpdatedWhen { get; set; }
        public string UpdatedWho { get; set; }
        public DateTime CreatedWhen { get; set; }
        public int? StatusId { get; set; }
        public string StatusIdUpdatedWho { get; set; }
        public string GcmsreferenceNumber { get; set; }
        public int? DirectionId { get; set; }
        public int? MainPostId { get; set; }
        public int? FeePostId { get; set; }
        public string CustomerAbbreviation { get; set; }
        public int? PaymentMethodId { get; set; }
        public string BranchNo { get; set; }
        public bool? IsClearerExtracted { get; set; }
        public string ClearerExtractFileName { get; set; }
        public string UnitCode { get; set; }
        public string AccountName { get; set; }
        public int? Lines { get; set; }
        public bool? IsValid { get; set; }
        public bool? IsPaymentGoposted { get; set; }
        public bool? IsFeeGoposted { get; set; }
        public bool? IsClearerReceived { get; set; }
        public string Bsb { get; set; }
        public DateTime ProcessDate { get; set; }
        public DateTime AvailableDate { get; set; }
        public string OriginalAccountName { get; set; }
        public int? ChequesCount { get; set; }
        public decimal ChequesValue { get; set; }
        public decimal CashValue { get; set; }
        public string ChequeNo { get; set; }
        public string Remark { get; set; }
        public int PreviousStatusId { get; set; }
        public DateTime LowPriorityWhen { get; set; }
        public int? ProductId { get; set; }
        public bool? IsDepartmentHandling { get; set; }
        public string DereplyFilename { get; set; }
        public string ChequeFrontImageName { get; set; }
        public string ChequeReverseImageName { get; set; }
    }
}
