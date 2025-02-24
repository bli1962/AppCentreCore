using System.Threading.Tasks;
using mhcb.Syd.Models;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface IEUCOnDemandBatchHttpService
    {
        // ** Move to generic http service **
        //Task<IEnumerable<OnDemandBatchView>> GetOnDemandBatchNoByDate();
        //Task<IEnumerable<OnDemandBatchView>> GetOnDemandBatchLogByBatchNo(string batchId);

        Task<int> UpdateStatus(InputOnDemandBatch onDemandBatchAttribute);
    }
}
