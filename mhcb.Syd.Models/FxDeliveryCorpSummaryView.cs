using System;

namespace mhcb.Syd.Models
{
	public class FxDeliveryCorpSummaryView
	{
		public string CCY { get; set; }
		public string Acct_Type { get; set; }
		public Nullable<decimal> totalNet { get; set; }
	}
}
