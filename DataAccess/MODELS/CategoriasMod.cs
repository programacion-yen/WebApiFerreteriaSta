using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MODELS
{
    public class CategoriasMod
    {
        public int IdCategoria { get; set; }
        public string? DescripcionCategoria { get; set; }
        public List<SubCategoriasMod>? SubCategorias { get;set; }
    }
}
