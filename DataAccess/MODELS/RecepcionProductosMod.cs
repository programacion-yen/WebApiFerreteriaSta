using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MODELS
{
    public class RecepcionProductosMod
    {
        public int IdRecepcionProducto { get; set; }
        public int IdProductoRecProd { get; set; }
        public int IdProveedorRecProd { get; set; }
        public int IdTipoDocumentoRecProd { get; set; }
        public DateTime FechaRecProd { get; set; }
        public int NumeroDocumentoRecProd { get; set; }
    }
}
