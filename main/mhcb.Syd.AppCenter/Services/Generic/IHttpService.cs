using System.Collections.Generic;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Services.Generic
{
    public interface IHttpService<T>
    {
        Task<List<T>> GetAllAsync(string requestUri, string accessToken);
        Task<int> AddAsync(string requestUri, string accessToken,T obj);

        Task<T> GetAsync(string requestUri, string accessToken);
        Task<T> GetByIdAsync(string requestUri, int Id, string accessToken);

        Task<int> UpdateAsync(string requestUri, string accessToken, T obj);
        Task<int> UpdateByIdAsync(string requestUri, int Id, string accessToken, T obj);

        Task<bool> DeleteAsync(string requestUri, string accessToken);
        Task<bool> DeleteByIdAsync(string requestUri, int Id, string accessToken);
    }
}
