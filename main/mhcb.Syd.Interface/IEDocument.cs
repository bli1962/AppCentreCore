using mhcb.Syd.Models;
using System.Collections.Generic;

namespace mhcb.Syd.Interface
{
	public interface IEDocument
	{
        IEnumerable<MMStatementView> GetMMStatement(string eDocType, string optDate);
        IEnumerable<MMConfirmationView> GetMMConfirmation(string eDocType, string optDate);
        IEnumerable<FXConfirmationView> GetFXConfirmation(string eDocType, string optDate);
        string UpdateStatus(InputEDocument eDocAttribute);
	}
}