using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MODELS
{
    public class VentasMod
    {
        public int IdVenta { get; set; }
        public int IdClienteVent { get; set; }
        public int IdVendedorVent { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal TotalVenta { get; set; }
        public bool DespachoVenta { get; set; }
    }
}
