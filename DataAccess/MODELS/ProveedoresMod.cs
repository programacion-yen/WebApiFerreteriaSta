using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MODELS
{
    public class ProveedoresMod
    {
        public int IdProveedor { get; set; }
        public int RutProveedor { get; set; }
        public string? DvProveedor { get; set; }
        public string? NombreProveedor { get; set; }
        public int TelefonoProveedor { get; set; }
        public string? EmailProveedor { get; set; }
    }
}
