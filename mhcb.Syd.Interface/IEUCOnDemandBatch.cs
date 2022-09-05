using mhcb.Syd.Models;
using System.Collections.Generic;

namespace mhcb.Syd.Interface
{
	public interface IEUCOnDemandBatch
	{
		IEnumerable<OnDemandBatchLogView> GetOnDemandBatchLogByBatchNo(string batchId);
		IEnumerable<OnDemandBatchView> GetOnDemandBatchNoByDate(string createdDate);
		string UpdateStatus(OnDemandBatchAttribute onDemandBatchAttribute);
	}
}