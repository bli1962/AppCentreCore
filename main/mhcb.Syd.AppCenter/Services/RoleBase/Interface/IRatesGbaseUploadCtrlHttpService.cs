using mhcb.Syd.Models;
using System;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface IRatesGbaseUploadCtrlHttpService
    {
        Task< Boolean> Create_GbaseRates_Upload_Ctrl(RatesControlPostDTO ratesControlPostDto);
    }
}
