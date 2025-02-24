
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mhcb.Syd.Business.DbAccess{

    public interface ISqlDataAccess
    {
        IEnumerable<T> LoadData<T, U>(string storedProcedure, U parameters);
        int SaveData<T>(string storedProcedure, T parameters);

        //Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionId = "Default");
        //Task SaveData<T>(string storedProcedure, T parameters, string connectionId = "Default");
    }
}


