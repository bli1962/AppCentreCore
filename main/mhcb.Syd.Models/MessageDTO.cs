using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Models
{
	[Serializable]
	public class MessageDTO
	{
		//public string IDs { get; set; }
		//public string ID { get; set; }
		//public string UserId { get; set; }

		public string QueueServerName { get; set; }  // read from config
		public string QueuePath { get; set; }       // calculate field
		public string QueueName { get; set; }       // read from config


		// type of GIP - SIF = 1, BIF = 2, SAP = 3,	FXTransaction = 4,FXDelivery = 5,
		// RatesSpot = 6, RatesRevaluation = 7,	RatesSwap = 8, RatesFunding = 9, RatessBIS = 10
		// Input fields

		//public int SentTo { get; set; }
		public QueueTypes SentTo { get; set; }

		[DefaultValue("751")]
		public string BranchNo { get; set; }    // used to for AcuStatus or BuStatus after update concotrol table
		[DefaultValue("Q")]
		public string Status { get; set; }		// hold the status value when send message, such as 'Q'

		public int? appSpecificValue { get; set; } // used for message object of AppSpecific
		public DateTime SysToday { get; set; }

		//public string Mode { get; set; }
		//public string MsgLabel { get; set; }
		//public string MsgBody { get; set; }
	}
}
