using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MODELS
{
    public class CotizacionesMod
    {
        public int IdCotizacion { get; set; }
        public int IdClienteCotiza { get; set; }
        public int IdVendedorCotiza { get; set; }
        public DateTime FechaCotizacion { get; set; }
        public decimal TotalCotizacion { get; set; }
    }
}
