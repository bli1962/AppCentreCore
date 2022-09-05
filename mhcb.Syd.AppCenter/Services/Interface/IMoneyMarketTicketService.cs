using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;

namespace mhcb.Syd.AppCenter.Services.Interface
{
    public interface IMoneyMarketTicketService
    {
        Task<IEnumerable<MoneyMarketTicketView>> GetMMGID();
        Task<IEnumerable<MoneyMarketReportView>> GetMMTransByDates(string strDateFrom, string strDateTo);
        Task<int> UpdateStatus(MMGIDStatus status);
    }
}
