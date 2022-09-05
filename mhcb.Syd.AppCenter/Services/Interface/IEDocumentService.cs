using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;

namespace mhcb.Syd.AppCenter.Services.Interface
{
    public interface IEDocumentService
    {
        Task<IEnumerable<eDocumentView>> GetPendingEDoc(string eDocType, string optDate);
        Task<int>  UpdateStatus(EDocumentAttribute eDocAttribute);
    }
}
