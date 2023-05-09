using DataAccess.INTERFACES;
using DataAccess.MODELS;
using DataAccess.SQLDATA;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class AccessoRegionCiudadComunaDao : IAccessoRegionCiudadComunaDao
    {
        public readonly ISqlDao _db;
        public readonly IConfiguration _configuration;

        public AccessoRegionCiudadComunaDao(ISqlDao db, IConfiguration configuration)
        {
            _db = db;
            _configuration = configuration;
        }

        public async Task<IEnumerable<ComunasMod>> GetRegionCiudadComuna(int _IdComuna)
        {
            try
            {
                var results = await _db.LoadData<ComunasMod, dynamic>(storedProcedure: "sp_ConsultaRegionesCiudadesComunas",
                new
                {
                    @IdComuna = _IdComuna,
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
