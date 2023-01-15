using AG_CategoryProducts.Models;
using System.Collections.Generic;
using System.Linq;

namespace AG_CategoryProducts.Data
{
    public class ProductsBD
    {
        public bool Insertarproducto(producto objproducto)
        {
            using (var context = new CategoryProducts())
            {
                producto objNewproducto = objproducto;
                context.Productos.Add(objNewproducto);
                context.SaveChanges();
            }
            return true;

        }
        public bool Actualizarproducto(producto objproducto)
        {
            using (var context = new CategoryProducts())
            {
                producto objNewproducto = objproducto;
                context.Productos.Update(objNewproducto);
                context.SaveChanges();
            }
            return true;

        }
        public bool Eliminarproducto(producto objproducto)
        {
            using (var context = new CategoryProducts())
            {
                context.Productos.Remove(objproducto);
                context.SaveChanges();
            }
            return true;

        }
        public producto Consultarproducto(int intproducto)
        {
            CategoryProducts context = new CategoryProducts();

            List<producto> lstproducto = context.Productos.Where(c => c.idproducto == intproducto).ToList();

            return lstproducto.FirstOrDefault();

        }
        public List<producto> Consultarproductos()
        {
            CategoryProducts context = new CategoryProducts();

            List<producto> lstproducto = context.Productos.ToList();

            return lstproducto;

        }
    }
}
