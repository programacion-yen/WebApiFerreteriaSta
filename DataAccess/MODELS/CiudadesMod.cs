using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MODELS
{
    public class CiudadesMod
    {
        public int IdCiudad { get; set; }
        public int IdRegionCiu { get; set; }
        public string? NombreCiudad { get; set; }
        public List<RegionesMod>? Regiones { get; set; }
        
    }
}
