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
    public class AccessoProductos : IAccessoProductos
    {
        public readonly ISqlDao _db;
        public readonly IConfiguration _configuration;


        public AccessoProductos(ISqlDao db, IConfiguration configuration)
        {
            _db = db;
            _configuration = configuration;
        }

        public async Task<IEnumerable<CategoriasMod>> GetCategoriasProductos(int _IdCategoria, string _DescripcionCategoria)
        {
            try
            {
                var results = await _db.LoadData<CategoriasMod, dynamic>(storedProcedure: "sp_ConsultaCategoriasProductos",
                new
                {
                    @IdCategoria = _IdCategoria,
                    @DescripcionCategoria = _DescripcionCategoria

                });
                return results;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<ProductosMod>> GetProductos(int _IdProducto, int _ActivoProducto)
        {
            try
            {
                var results = await _db.LoadData<ProductosMod, dynamic>(storedProcedure: "sp_ConsultaProductos",
                new
                {
                    @IdProducto = _IdProducto,
                    @ActivoProducto = _ActivoProducto

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
