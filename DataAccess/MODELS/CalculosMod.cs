using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MODELS
{
    public class CalculosMod
    {
        public int IdDetalleVentaCalculo { get; set; }
        public decimal SubtotalCalculo { get; set; }
        public decimal DescuentoCalculo { get; set; }
        public decimal IvaCalculo { get; set; }
        public decimal MontoTotalCalculo { get; set; }
        public decimal MontoNetoCalculo { get; set; }
    }
}
