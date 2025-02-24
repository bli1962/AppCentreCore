namespace mhcb.Syd.Models
{
    public class MxInboundEventLogView
    {
        public int MessageId{ get; set; }
        public string SendingSystem{ get; set; }
        public string Category{ get; set; }
        public string EventType{ get; set; }
        public string  StatusName{ get; set; }
        //public string  GBaseReferenceNo{ get; set; }
        //public string  CustomerAbbreviation{ get; set; }
        //public string  BatchNo{ get; set; }
        public int LogId { get; set; }
        public string GBaseReferenceNo { get; set; }
        public string CustomerAbbreviation { get; set; }
        public string Account { get; set; }
        public string Logger{ get; set; }
        public string Description{ get; set; }
        public string Status{ get; set; }
    }


    public class MxEucBalanceView
    {
        public int MessageId { get; set; }
        public string SendingSystem { get; set; }
        public string Category { get; set; }
        public string EventType { get; set; }
        public string EventStatus { get; set; }

        public string GBaseReferenceNo { get; set; }
        public string CustomerAbbreviation { get; set; }
        public string BranchNo { get; set; }
        public int Account { get; set; }

        public decimal? NominalAmount { get; set; }
        public string Currency { get; set; }
        public string TradeDate { get; set; }
        public string EffectiveDate { get; set; }
        public string BalanceStatus { get; set; }
        public int? BatchNo { get; set; }

        public int LogId { get; set; }
        public string Logger { get; set; }
    }
}
