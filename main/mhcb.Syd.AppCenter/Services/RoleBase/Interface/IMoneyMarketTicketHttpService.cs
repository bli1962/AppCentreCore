using System.Threading.Tasks;
using mhcb.Syd.Models;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface IMoneyMarketTicketHttpService
    {
        // ** Move to generic http service **
        //Task<IEnumerable<MoneyMarketTicketView>> GetMMGID();
        //Task<IEnumerable<MoneyMarketReportView>> GetMMTransByDates(string strDateFrom, string strDateTo);

        Task<int> UpdateStatus(InputMMGID status);
    }
}
