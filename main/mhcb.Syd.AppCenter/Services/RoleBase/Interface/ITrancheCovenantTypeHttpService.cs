using mhcb.Syd.Models;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface ITrancheCovenantTypeHttpService
    {
        // ** Move to generic http service **
        //Task<IEnumerable<TrancheType>> LoadTrancheType();
        //Task<IEnumerable<CovenantCondition>> LoadCovenantConditionByGroup(string conditionGroupDesc);
        //Task<IEnumerable<CovenantReceiptTiming>> LoadCovenantReceiptTiming();

        Task<int> AddTrancheType(InputTrancheType inputTrancheType);
        Task<int> AddCovenantCondition(InputCovenantCondition inputCovenantCondition);
        Task<int> AddCovenantReceiptTiming(InputCovenantReceiptTiming inputCovenantReceiptTiming);
    }
}
