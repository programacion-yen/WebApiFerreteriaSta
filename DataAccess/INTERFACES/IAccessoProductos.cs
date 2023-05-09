using DataAccess.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.INTERFACES
{
    public interface IAccessoProductos
    {
        Task<IEnumerable<CategoriasMod>> GetCategoriasProductos(int _IdCategoria, string _DescripcionCategoria);

        Task<IEnumerable<ProductosMod>> GetProductos(int _IdProducto, int _ActivoProducto);
    }
}
