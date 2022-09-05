using mhcb.Syd.Models;
using System.Collections.Generic;

namespace mhcb.Syd.Interface
{
	public interface IEDocument
	{
		IEnumerable<eDocumentView> GetPendingTrans(string eDocType, string optDate);
		string UpdateStatus(EDocumentAttribute eDocAttribute);
	}
}