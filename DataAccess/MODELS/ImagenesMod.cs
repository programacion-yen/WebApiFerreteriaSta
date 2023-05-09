using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MODELS
{
    public class ImagenesMod
    {
        public int IdImagen { get; set; }
        public int IdProductoImagen { get; set; }
        public string? NombreImagen { get; set; }
        public string? UrlImagen { get; set; }
    }
}
