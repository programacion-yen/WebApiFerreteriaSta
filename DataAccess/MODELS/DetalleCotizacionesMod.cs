using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MODELS
{
    public class DetalleCotizacionesMod
    {
        public int IdDetalleCotizacion { get; set; }
        public int IdCotizacionDetCo { get; set; }
        public int IdProductoDetCo { get; set; }
        public int CantVenDetalleCotizacion { get; set; }
        public decimal PrecioUniDetalleCotizacion { get; set; }
    }
}
