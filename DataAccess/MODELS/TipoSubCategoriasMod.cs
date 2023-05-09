using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MODELS
{
    public class TipoSubCategoriasMod
    {
        public int IdTipoSubCategoria { get; set; }
        public int IdSubCategoriaTipSubCat { get; set; }
        public string? DescripcionTipoSubCategoria { get; set; }
        public List<ProductosMod>? Productos { get; set;}
    }
}
