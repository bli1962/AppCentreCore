using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Models
{
    public class SwiftPaymentView
    {
        public int PaymentId { get; set; }
        public string CustomerAbbreviation { get; set; }
        public DateTime ValueDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string PaymentCurrencyCode { get; set; }

        public int SwiftPaymentId { get; set; }
        public bool Processed { get; set; }
        public Nullable<int> StatusId { get; set; }
        public string StatusDescription { get; set; }
        public string GBaseRefNo { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
        public string SenderBank { get; set; }
        public string ReceiverBank { get; set; }
        public DateTime CreatedWhen { get; set; }

        public string Product { get; set; }

    }
}
