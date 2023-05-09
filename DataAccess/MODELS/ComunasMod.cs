using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MODELS
{
    public class ComunasMod
    {
        public int IdComuna { get; set; }
        public int IdCiudadCom { get; set; }
        public string? NombreComuna { get; set; }
        
        public List<CiudadesMod>? Ciudades { get; set; }
      
    }
}
