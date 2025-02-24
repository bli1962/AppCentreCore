
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;

namespace mhcb.Syd.Business.DbAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        public readonly string _sqlConnection;
        public SqlDataAccess()
        {
            _sqlConnection = ConfigurationManager.AppSettings["GUIDESP"];
        }
        public SqlDataAccess(string myConnection)
        {
            _sqlConnection = myConnection;
        }

        public IEnumerable<T> LoadData<T, U>(string storedProcedure, U parameters)
        {
            IDbConnection connection = new SqlConnection(_sqlConnection);

            return connection.Query<T>(storedProcedure,
                                       parameters,
                                       commandType: CommandType.StoredProcedure);
        }

        public int SaveData<U>(string storedProcedure, U parameters)
        {
            IDbConnection connection = new SqlConnection(_sqlConnection);

            // Dapper command .ExecuteAsync
            int intRowCount = connection.Execute(storedProcedure,
                                                parameters,
                                                commandType: CommandType.StoredProcedure);
            return intRowCount;
        }


        //public async Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters)
        //{
        //    IDbConnection connection = new SqlConnection(_sqlConnection);

        //    // Dapper command: .ExecuteAsync
        //    return await connection.QueryAsync<T>(storedProcedure,
        //                               parameters,
        //                               commandType: CommandType.StoredProcedure);
        //}

        //public async Task SaveData<U>(string storedProcedure,
        //                              U parameters)
        //{
        //    IDbConnection connection = new SqlConnection(_sqlConnection);

        //    // Dapper command .ExecuteAsync
        //    await connection.ExecuteAsync(storedProcedure,
        //                                  parameters,
        //                                  commandType: CommandType.StoredProcedure);
        //}

    }
}


