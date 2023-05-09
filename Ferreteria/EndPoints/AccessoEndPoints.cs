using Dapper;
using DataAccess.MODELS;
using DataAccess.INTERFACES;
using Ferreteria.Utilities;
using System.Collections.Generic;


namespace Ferreteria.EndPoints
{
    public static class AccessoEndPoints
    {
        /// <summary>
        ///Esta clase usa y configura los Endpoints que viene 
        ///desde el portal, tambien recibe los paràmetros que vienen desde
        ///el appsettings.json
        /// </summary>
        /// <param name="app"></param>
        /// <param name="versionApi"></param>
        public static void ConfigurarEndpoints(this WebApplication app, string versionApi)
        {
            app.MapGet($"{versionApi}/GetClienteDireccion/ObtenerClienteDireccion/" + "{IdCliente}",
                async (IAccessoClienteDireccion data, int IdCliente) =>
                await ObtenerClienteDireccion(data, IdCliente));

            app.MapGet($"{versionApi}/GetRegionCiudadComuna/ObtenerRegionCiudadComuna/" + "{IdComuna}",
                async (IAccessoRegionCiudadComunaDao data, int IdComuna) =>
                await ObtenerRegionCiudadComuna(data, IdComuna));

            app.MapGet($"{versionApi}/GetCategoriasProductos/ObtenerCategoriasProductos/" + "{IdCategoria}/{DescripcionCategoria}",
                async (IAccessoProductos data, int IdCategoria, string DescripcionCategoria) =>
                await ObtenerCategoriasProductos(data, IdCategoria, DescripcionCategoria));

            app.MapGet($"{versionApi}/GetProductos/ObtenerProductos/" + "{IdProducto}/{ActivoProducto}",
                async (IAccessoProductos data, int IdProducto, int ActivoProducto) =>
                await ObtenerProductos(data, IdProducto, ActivoProducto));

            #region JsonTypeHandler

            SqlMapper.AddTypeHandler(new JsonTypeHandler<ClientesMod[]>());
            SqlMapper.AddTypeHandler(new JsonTypeHandler<List<DireccionesClientesMod>>());
            SqlMapper.AddTypeHandler(new JsonTypeHandler<ComunasMod[]>());
            SqlMapper.AddTypeHandler(new JsonTypeHandler<CategoriasMod[]>());

            SqlMapper.AddTypeHandler(new JsonTypeHandler<List<SubCategoriasMod>>());
            SqlMapper.AddTypeHandler(new JsonTypeHandler<List<TipoSubCategoriasMod>>());
            SqlMapper.AddTypeHandler(new JsonTypeHandler<List<ProductosMod>>());
            SqlMapper.AddTypeHandler(new JsonTypeHandler<List<CiudadesMod>>());
            SqlMapper.AddTypeHandler(new JsonTypeHandler<List<RegionesMod>>());

            #endregion

        }

        #region ObtenerClienteDireccion

        private static async Task<IResult> ObtenerClienteDireccion(IAccessoClienteDireccion data, int _IdCliente)
        {
            try
            {
                if (_IdCliente > 0)
                {
                    IEnumerable<ClientesMod> OBJ = await data.GetClienteDireccion(_IdCliente);
                    if (OBJ.Count() > 0)
                    {
                        return Results.Ok(OBJ);
                    }
                    return Results.BadRequest("No se encontraron datos!");
                }
                return Results.BadRequest("Id cliente no existe!");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        #endregion

        #region  ObtenerRegionCiudadComuna

        private static async Task<IResult> ObtenerRegionCiudadComuna(IAccessoRegionCiudadComunaDao data, int IdComuna)
        {
            try
            {
                if (IdComuna > 0)
                {
                    IEnumerable<ComunasMod> OBJ = await data.GetRegionCiudadComuna(IdComuna);
                    if (OBJ.Count() > 0)
                    {
                        return Results.Ok(OBJ);
                    }
                    return Results.BadRequest("No se encontraron datos!");
                }
                return Results.BadRequest("Id región no existe!");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        #endregion

        #region ObtenerCategoriasProductos

        private static async Task<IResult> ObtenerCategoriasProductos(IAccessoProductos data, int _IdCategoria, string _DescripcionCategoria)
        {
            try
            {
                if (_IdCategoria > 0 || !_DescripcionCategoria.Equals(""))
                {
                    IEnumerable<CategoriasMod> OBJ = await data.GetCategoriasProductos(_IdCategoria, _DescripcionCategoria);
                    if (OBJ.Count() > 0)
                    {
                        return Results.Ok(OBJ);
                    }
                    return Results.BadRequest("No se encontraron datos!");
                }
                return Results.BadRequest("Categoria no existe!");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }


        #endregion

        #region ObtenerProductos

        private static async Task<IResult> ObtenerProductos(IAccessoProductos data, int _IdProducto, int _ActivoProducto)
        {
            try
            {
                if (_IdProducto >= 0 || (_ActivoProducto >= 0 || _ActivoProducto <= 1))
                {
                    IEnumerable<ProductosMod> OBJ = await data.GetProductos(_IdProducto, _ActivoProducto);
                    if (OBJ.Count() > 0)
                    {
                        return Results.Ok(OBJ);
                    }
                    return Results.BadRequest("No se encontraron datos!");
                }
                return Results.BadRequest("Producto no existe!");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        #endregion
    }
}
