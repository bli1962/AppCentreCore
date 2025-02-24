using mhcb.Syd.Models;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface IRatesMessageHttpService
    {
        Task<int> SendMessageToQueue(MessageDTO messageDto);
    }
}
