using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;

namespace mhcb.Syd.AppCenter.Services.Interface
{
    public interface ICovenantMasterService
    {
        Task<IEnumerable<CovenantMasterRecordView>> GetCovenantMasterRecord();
        Task<IEnumerable<CovenantRatioView>> GetCovenantRatio(string covenantType, string dateType, string dateFrom, string dateTo);
    }
}
