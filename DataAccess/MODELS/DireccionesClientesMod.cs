using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MODELS
{
    public class DireccionesClientesMod
    {
        public int IdDireccion { get; set; }
        public int IdComunaDire { get; set; }
        public int IdClienteDire { get; set; }
        public string? Calle { get; set; }
        public int Numeracion { get; set; }
        public string? Departamento { get; set; }

        public List<ComunasMod>? Comunas { get; set; }
    }
}
