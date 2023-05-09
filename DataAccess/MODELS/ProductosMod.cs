using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MODELS
{
    public class ProductosMod
    {
        public int IdProducto { get; set; }
        public int IdTipoSubCategoriaProd { get; set; }
        public int IdUnidadMedidaProd { get; set; }
        public string? NombreProducto { get; set; }
        public string? DescripcionProducto { get; set; }
        public decimal PrecioProducto { get; set; }
        public int StockProducto { get; set; }
        public bool ActivoProducto { get; set; }
    }
}
