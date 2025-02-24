using mhcb.Syd.Models;
using System.Collections.Generic;

namespace mhcb.Syd.Interface
{
    public interface IGAS
    {
        IEnumerable<GASDebitView> GetGASTransByDate(string optDate);

        string UpdateDCSStatus(InputGAS gasAttribute);

        string UpdateGASStatus(InputGAS gasAttribute);
    }
}
