using DataAccess.INTERFACES;
using DataAccess.MODELS;
using DataAccess.SQLDATA;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class AccessoClienteDireccion : IAccessoClienteDireccion
    {

        public readonly ISqlDao _db;
        public readonly IConfiguration _configuration;


        public AccessoClienteDireccion(ISqlDao db, IConfiguration configuration)
        {
            _db = db;
            _configuration = configuration;;
        }

        public async Task<IEnumerable<ClientesMod>> GetClienteDireccion(int _IdCliente)
        {
                try
                {
                    var results = await _db.LoadData<ClientesMod, dynamic>(storedProcedure: "sp_ConsultaClienteDireccion",
                    new
                    {
                        @RutCliente = _IdCliente,

                    });
                    return results;                   
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
        }
    }
}
