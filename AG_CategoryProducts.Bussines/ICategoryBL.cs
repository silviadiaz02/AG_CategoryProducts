using AG_CategoryProducts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AG_CategoryProducts.Bussines
{
    public interface ICategoryBL
    {
        public bool InsertarCategoria(categoria objCategoria);
        public bool ActualizarCategoria(categoria objCategoria);
        public bool EliminarCategoria(categoria objCategoria);
        public categoria ConsultarCategoria(int intCategoria);
        public List<categoria> ConsultarCategorias();
    }
}
