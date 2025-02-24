using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Models
{
    public class MMStatementView
    {
        public int Id { get; set; }
        public string ReportType { get; set; }
        public string ReportFileName { get; set; }
        //public bool Processed { get; set; }
        public string Processed { get; set; }

        [DisplayFormat(DataFormatString = ("{dd/MM/yyyy}"))]
        public DateTime DateProcessed { get; set; }
        //public bool Errored { get; set; }
        public string Errored { get; set; }
        public string ErrorMessage { get; set; }

        public string CompanyName { get; set; }
        public string AccountNo { get; set; }
        public string ReferenceNumber { get; set; }
        public string AccountType { get; set; }

    }

    public class FXConfirmationView
    {
        public int Id { get; set; }
        public string ReportType { get; set; }
        public string ReportFileName { get; set; }
        //public bool Processed { get; set; }
        public string Processed { get; set; }

        [DisplayFormat(DataFormatString = ("{dd/MM/yyyy}"))]
        public DateTime DateProcessed { get; set; }
        //public bool Errored { get; set; }
        public string Errored { get; set; }
        public string ErrorMessage { get; set; }

        public string CompanyName { get; set; }
        public string ReferenceNumber { get; set; }
        public string ContractDate { get; set; }
        public string BuyAmount { get; set; }
        public string SellAmount { get; set; }
        public string OurPurchaseRate { get; set; }
    }


    public class MMConfirmationView
    {
        public int Id { get; set; }
        public string ReportType { get; set; }
        public string ReportFileName { get; set; }
        //public bool Processed { get; set; }
        public string Processed { get; set; }

        [DisplayFormat(DataFormatString = ("{dd/MM/yyyy}"))]
        public DateTime DateProcessed { get; set; }
        //public bool Errored { get; set; }
        public string Errored { get; set; }
        public string ErrorMessage { get; set; }

        public string CompanyName { get; set; }
        public string ReferenceNumber { get; set; }
        public string ContractDate { get; set; }
        public string ValueDate { get; set; }
        public string DueDate { get; set; }
        public string IncreaseDecrease { get; set; }
        public string ClosingBalance { get; set; }
        public string Rate { get; set; }

    }
}
