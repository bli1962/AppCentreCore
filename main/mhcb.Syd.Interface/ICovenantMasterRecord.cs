using mhcb.Syd.Models;
using System.Collections.Generic;

namespace mhcb.Syd.Interface
{
	public interface ICovenantMasterRecord
	{
		IEnumerable<CovenantMasterRecordView> GetCovenantMasterRecord();
		IEnumerable<CovenantRatioView> GetCovenantRatio(string covenantType, string dateType, string dateFrom, string dateTo);
	}
}