using mhcb.Syd.Models.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Interface.Dashboard
{
	public interface IDocumentCount
	{
		List<StatusCounterDTO> GetDocumentStatusCount(string strDate);
	}
}
