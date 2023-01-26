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
    public class ProductRepository : IProductRepository
    {
        public EntityResponse<Producto> Delete(int idProduct)
        {
            int idResultProduct = 0;
            using (var context = new DbproductosContext())
            {
                var categoryItem = context.Productos.Find(idProduct);
                context.Remove(categoryItem);
                idResultProduct = context.SaveChanges();
            }

            return ResponseManager.ResponseOk<Producto>(idResultProduct, null, idProduct);
        }

        public EntityResponse<Producto> GetById(int idProduct)
        {
            var resultProduct = new List<Producto>();
            using (var context = new DbproductosContext())
            {
                var categoryItem = context.Productos.Find(idProduct);
                resultProduct.Add(categoryItem);
            }

            return ResponseManager.ResponseOk(resultProduct.Count, resultProduct);
        }

        public EntityResponse<Producto> GetList()
        {
            var resultProduct = new List<Producto>();
            using (var context = new DbproductosContext())
            {
                resultProduct = context.Productos.ToList();
            }

            return ResponseManager.ResponseOk(resultProduct.Count, resultProduct);
        }

        public EntityResponse<Producto> Insert(Producto objectInsert)
        {
            long idResultProduct = 0;
            using (var context = new DbproductosContext())
            {
                context.Productos.Add(objectInsert);
                idResultProduct = context.SaveChanges();
            }

            return ResponseManager.ResponseOk<Producto>(idResultProduct > 0 ? 1 : 0, new List<Producto> { objectInsert }, idResultProduct);
        }

        public EntityResponse<Producto> Update(Producto objectUpdate)
        {
            long idResultProduct = 0;
            using (var context = new DbproductosContext())
            {
                var productItem = context.Productos.Find(objectUpdate.Idproducto);
                productItem.Idcategoria = objectUpdate.Idcategoria;
                productItem.Codigo = objectUpdate.Codigo;
                productItem.Nombre = objectUpdate.Nombre;
                productItem.PrecioVenta = objectUpdate.PrecioVenta;
                productItem.Stock = objectUpdate.Stock;
                productItem.Descripcion = objectUpdate.Descripcion;
                productItem.Imagen = objectUpdate.Imagen;
                productItem.Estado = objectUpdate.Estado;
                context.Entry(productItem).State = EntityState.Modified;
                idResultProduct = context.SaveChanges();
            }

            return ResponseManager.ResponseOk(idResultProduct > 0 ? 1 : 0, new List<Producto> { objectUpdate }, idResultProduct);
        }
    }
}
