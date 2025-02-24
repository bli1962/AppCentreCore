using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Models
{
	[Serializable]
	public class RatesUploadCtrl
	{
		public string BranchNo { get; set; }
		public RateTypes RateType { get; set; }
		public string CcyId { get; set; }
		public DateTime OperatedDate { get; set; }

		public string AcuStatus { get; set; }
		public string BuStatus { get; set; }
		public string AcuTransStatus { get; set; }
		public string BuTransStatus { get; set; }
		public string InputStatus { get; set; }
		public string GbaseMsg { get; set; }
		public string UserId { get; set; }
	}
}
