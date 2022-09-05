using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;

namespace mhcb.Syd.Interface
{
    public interface IEUCOnDemandBatchService
    {

        Task<IEnumerable<OnDemandBatchView>> GetOnDemandBatchNoByDate();

        Task<IEnumerable<OnDemandBatchView>> GetOnDemandBatchLogByBatchNo(string batchId);

        Task<int> UpdateStatus(OnDemandBatchAttribute onDemandBatchAttribute);
    }
}
