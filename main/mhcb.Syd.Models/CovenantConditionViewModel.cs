using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Models
{
	[Serializable]
	public class CovenantConditionViewModel
	{
		public byte ConditionType { get; set; }
		public string ConditionDesc { get; set; }
		public string ConditionGroupDesc { get; set; }
	}
}
