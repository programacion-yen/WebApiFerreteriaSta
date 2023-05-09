using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MODELS
{
    public class VendedoresMod
    {
        public int IdVendedor { get; set; }
        public int RutVendedor { get; set; }
        public string? DvVendedor { get; set; }
        public string? NombreVendedor { get; set; }
        public int TelefonoVendedor { get; set; }
        public string? EmailVendedor { get; set; }
    }
}
