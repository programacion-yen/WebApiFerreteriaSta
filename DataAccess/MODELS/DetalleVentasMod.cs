using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MODELS
{
    public class DetalleVentasMod
    {
        public int IdDetalleVenta { get; set; }
        public int IdVentaDetV { get; set; }
        public int IdProductoDetV { get; set; }
        public int CantVenDetalleVenta { get; set; }
        public decimal PrecioUniDetalleVenta { get; set; }
    }
}
