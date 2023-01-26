using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiProducts.Data.Models;
using WebApiProducts.Entities.Response;
using WebApiProducts.Repository.Interfaces;

namespace WebApiProducts.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public EntityResponse<Categorium> Delete(int idCategory)
        {
            int idResultCategory = 0;
            using (var context = new DbproductosContext())
            {
                var categoryItem = context.Categoria.Find(idCategory);
                context.Remove(categoryItem);
                idResultCategory = context.SaveChanges();
            }

            return ResponseManager.ResponseOk<Categorium>(idResultCategory, null, idCategory);
        }

        public EntityResponse<Categorium> GetById(int idCategory)
        {
            var resultCategory = new List<Categorium>();
            using (var context = new DbproductosContext())
            {
                var categoryItem = context.Categoria.Find(idCategory);
                resultCategory.Add(categoryItem);
            }

            return ResponseManager.ResponseOk(resultCategory.Count, resultCategory);
        }

        public EntityResponse<Categorium> GetList()
        {
            var resultCategory = new List<Categorium>();
            using (var context = new DbproductosContext())
            {
                resultCategory = context.Categoria.ToList();
            }

            return ResponseManager.ResponseOk(resultCategory.Count, resultCategory);
        }

        public EntityResponse<Categorium> Insert(Categorium objectInsert)
        {
            long idResultCategory = 0;
            using (var context = new DbproductosContext())
            {
                context.Categoria.Add(objectInsert);
                idResultCategory = context.SaveChanges();
            }
     
            return ResponseManager.ResponseOk<Categorium>(idResultCategory > 0? 1: 0, new List<Categorium> { objectInsert }, idResultCategory);
        }

        public EntityResponse<Categorium> Update(Categorium objectUpdate)
        {
            long idResultCategory = 0;
            using (var context = new DbproductosContext())
            {
                var categoryItem = context.Categoria.Find(objectUpdate.Idcategoria);
                categoryItem.Nombre = objectUpdate.Nombre;
                categoryItem.Descripcion = objectUpdate.Descripcion;
                categoryItem.Estado = objectUpdate.Estado;
                context.Entry(categoryItem).State = EntityState.Modified;
                idResultCategory = context.SaveChanges();
            }

            return ResponseManager.ResponseOk(idResultCategory > 0 ? 1 : 0, new List<Categorium> { objectUpdate }, idResultCategory);
        }
    }
}
