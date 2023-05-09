using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SQLDATA
{
    public interface ISqlDao
    {
        Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionId = "Default");

        Task SaveData<T>(string storedProcedure, T parameters, string connectionId = "Default");
    }
}
