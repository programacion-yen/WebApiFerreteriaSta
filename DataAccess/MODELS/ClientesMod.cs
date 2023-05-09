using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.MODELS
{
    public class ClientesMod
    {
        public int IdCliente { get; set; }
        public int RutCliente { get; set; }
        public string? DvCliente { get; set; }
        public string? NombreCliente { get; set; }
        public int TelefonoCliente { get; set; }
        public string? EmailCliente { get; set; }

        public List<DireccionesClientesMod>? Direcciones { get;}

    }
}
