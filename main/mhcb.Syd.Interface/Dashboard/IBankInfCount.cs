using mhcb.Syd.Models.Dashboard;
using System.Collections.Generic;

namespace mhcb.Syd.Interface.Dashboard
{
    public interface IBankInfCount
    {
        List<StatusCounterDTO> GetBIFStatusCount();
    }
}
