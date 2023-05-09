using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MODELS
{
    public class SubCategoriasMod
    {
        public int IdSubCategoria { get; set; }
        public int IdCategoriaCat { get; set; }
        public string? DescripcionSubCategoria { get; set; }
        public List<TipoSubCategoriasMod>? TipoSubCategorias { get; set; }
    }
}
