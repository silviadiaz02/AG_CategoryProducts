using AG_CategoryProducts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AG_CategoryProducts.Data
{
    public class CategoryBD
    {
        public bool InsertarCategoria(categoria objCategoria)
        {
            using (var context = new CategoryProducts())
            {
                categoria objNewCategoria = objCategoria;
                context.Categoria.Add(objNewCategoria);
                context.SaveChanges();
            }
            return true;

        }
        public bool ActualizarCategoria(categoria objCategoria)
        {
            using (var context = new CategoryProducts())
            {
                categoria objNewCategoria = objCategoria;
                context.Categoria.Update(objNewCategoria);
                context.SaveChanges();
            }
            return true;

        }
        public bool EliminarCategoria(categoria objCategoria)
        {
            using (var context = new CategoryProducts())
            {
                context.Categoria.Remove(objCategoria);
                context.SaveChanges();
            }
            return true;

        }
        public categoria ConsultarCategoria(int intCategoria)
        {
            CategoryProducts context = new CategoryProducts();

            List<categoria> lstcategoria = context.Categoria.Where(c => c.idcategoria == intCategoria).ToList();

            return lstcategoria.FirstOrDefault();

        }
        public List<categoria> ConsultarCategorias()
        {
            CategoryProducts context = new CategoryProducts();

            List<categoria> lstcategoria = context.Categoria.ToList();

            return lstcategoria;

        }
    }
}
