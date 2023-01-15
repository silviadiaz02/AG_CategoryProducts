using AG_CategoryProducts.Data;
using AG_CategoryProducts.Models;
using System;
using System.Collections.Generic;

namespace AG_CategoryProducts.Bussines
{
    public class CategoryBL : ICategoryBL
    {
        CategoryBD dbCategory = new CategoryBD();
        public bool InsertarCategoria(categoria objCategoria)
        {            
            return dbCategory.InsertarCategoria(objCategoria); 
        }
        public bool ActualizarCategoria(categoria objCategoria)
        {
            return dbCategory.ActualizarCategoria(objCategoria);
        }
        public bool EliminarCategoria(categoria objCategoria)
        {
            return dbCategory.EliminarCategoria(objCategoria);
        }
        public categoria ConsultarCategoria(int intCategoria)
        {
            return dbCategory.ConsultarCategoria(intCategoria);
        } 
        public List<categoria> ConsultarCategorias()
        {
            return dbCategory.ConsultarCategorias();
        }
    }
}
