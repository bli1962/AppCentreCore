using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Models.Dashboard
{
	public class SelectedMMDTO
    {
        public string Status { get; set; }
        public string GipDescription { get; set; }
        public int MmticketId { get; set; }


		//public DateTime? ValueDate { get; set; }
		//public DateTime OperationDate { get; set; }
		//public string DeletionStatus { get; set; }
		//public string GipStatus { get; set; }
		//public string TranNo { get; set; }
	}
}
