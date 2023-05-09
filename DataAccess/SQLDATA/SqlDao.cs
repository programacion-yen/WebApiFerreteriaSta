using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SQLDATA
{
    public class SqlDao : ISqlDao
    {
        /// <summary>
        /// Esta calse se usa como servicio en el Program
        /// y con el patrón AddSingleton
        /// </summary>

        private readonly IConfiguration _config;

        #region Inyeccción de dependencias

        public SqlDao(IConfiguration config)
        {
            _config = config;
        }

       
        public async Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionId = "Default")
        {
            using (var connection = new SqlConnection(_config.GetConnectionString(connectionId)))
            {
                try
                {
                    await connection.OpenAsync();
                    return await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    await connection.CloseAsync();
                    string mensaje = ex.Message;
                    return Enumerable.Empty<T>();
                }
                finally { await connection.CloseAsync(); }
            };
        }

        public async Task SaveData<T>(string storedProcedure, T parameters, string connectionId = "Default")
        {
            using (var connection = new SqlConnection(_config.GetConnectionString(connectionId)))
            {
                try
                {
                    connection.OpenAsync();
                    await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    await connection.CloseAsync();
                    string mensaje = ex.Message;                  
                }
            };

        }
    }
}
#endregion