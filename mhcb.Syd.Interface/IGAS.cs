using mhcb.Syd.Models;
using System.Collections.Generic;

namespace mhcb.Syd.Interface
{
    public interface IGAS
    {
        IEnumerable<GASDebitView> GetGASTransByDate(string optDate);

        string UpdateDCSStatus(GASAttribute gasAttribute);

        string UpdateGASStatus(GASAttribute gasAttribute);
    }
}
