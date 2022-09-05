namespace mhcb.Syd.Models
{
    public class SettlementInfView
    {
        public int SIF_ID { get; set; }
        public string CUST_ABBR { get; set; }
        public string RECORD_KIND { get; set; }
        public string CCY { get; set; }


        public string REC_SETTL_CODE { get; set; }
        public string REC_ACT_CD { get; set; }
        public string REC_METHOD { get; set; }
        public string PAY_SETTL_CODE { get; set; }
        public string PAY_ACT_CD { get; set; }
        public string PAY_METHOD { get; set; }
        public string REC_BANK_ID { get; set; }
        public string REC_CUST_ABBR { get; set; }
        public string INTERMEDIARY_BANK_ID { get; set; }
        public string ACC_BANK_ID { get; set; }
        public string ACC_BANK_ACTNO { get; set; }
        public string BENE_BANK_ID { get; set; }
        public string BENE_BANK_ACTNO { get; set; }
        public string CONFIRMATION_SWIFT_ID { get; set; }
        public string CONFIRMATION_FLG { get; set; }
        public string REC_BANK_BR_ACTNO { get; set; }
        public string REC_BANK_HO_ACTNO { get; set; }
        public string BANK_INF { get; set; }

        
        public string STATUS { get; set; }
        public string DELETION_STATUS { get; set; }
        public string TRAN_NO { get; set; }
        public string GIP_STATUS { get; set; }
        public string GIP_DESCRIPTION { get; set; }
        public string AUTHORIZE_BY { get; set; }

        // instructions
        public string Addresse { get; set; }
        public string PartyIdentifier56 { get; set; }
        public string BIC56_1 { get; set; }
        public string PartyIdentifier57 { get; set; }
        public string FXALM_PartyIdentifier57 { get; set; }
        public string BIC57_1 { get; set; }
        public string BIC57_2 { get; set; }
        public string BIC57_3 { get; set; }
        public string BIC57_4 { get; set; }
        public string PartyIdentifier58 { get; set; }
        public string FXALM_PartyIdentifier58 { get; set; }
        public string BIC58_1 { get; set; }
        public string PartyIdentifier59 { get; set; }
        public string BIC59_1 { get; set; }
        public string BIC59_2 { get; set; }
        public string BIC59_3 { get; set; }
        public string BIC59_4 { get; set; }
        public string SpecialInstruction_1 { get; set; }
        public string SpecialInstruction_2 { get; set; }
        public string SpecialInstruction_3 { get; set; }
        public string SpecialInstruction_4 { get; set; }
    }
}
