﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Models.Dashboard
{
	[Serializable]
	public class StatusCounterSameDayDTO
	{
		public string Status { get; set; }
		public string Description { get; set; }
		public int Count { get; set; }
		public int SameDayCount { get; set; }
	}
}
