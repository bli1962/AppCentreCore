using mhcb.Syd.DataAccess.Models.LOAN;
using mhcb.Syd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Interface
{
	public interface ITrancheCovenantType
	{
		IEnumerable<TrancheType> LoadTrancheType();
		IEnumerable<CovenantConditionGroup> LoadCovenantConditionGroup();
		IEnumerable<CovenantConditionViewModel> LoadCovenantConditionByGroup(string conditionGroupDesc);
		IEnumerable<CovenantReceiptTiming> LoadCovenantReceiptTiming();
		string AddTrancheType(InputTrancheType inputTrancheType);
		string AddCovenantCondition(InputCovenantCondition inputCovenantCondition);
		string AddCovenantReceiptTiming(InputCovenantReceiptTiming inputCovenantReceiptTiming);

	}
}
