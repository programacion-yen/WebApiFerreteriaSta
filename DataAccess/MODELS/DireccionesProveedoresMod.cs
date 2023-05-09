using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MODELS
{
    public class DireccionesProveedoresMod
    {
        public int IdDireccion { get; set; }
        public int IdComunaDire { get; set; }
        public int IdProveedorDire { get; set; }
        public string? Calle { get; set; }
        public int Numeracion { get; set; }
        public string? Departamento { get; set; }
    }
}

