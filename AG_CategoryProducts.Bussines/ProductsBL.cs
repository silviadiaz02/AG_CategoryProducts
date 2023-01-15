using AG_CategoryProducts.Data;
using AG_CategoryProducts.Models;
using System.Collections.Generic;

namespace AG_CategoryProducts.Bussines
{
    public class ProductsBL :IProductsBL
    {
        ProductsBD dbProduct = new ProductsBD();  

        public bool Insertarproducto(producto objproducto)
        {
            return dbProduct.Insertarproducto(objproducto);
        }
        public bool Actualizarproducto(producto objproducto)
        {
            return dbProduct.Actualizarproducto(objproducto);
        }
        public bool Eliminarproducto(producto objproducto)
        {
            return dbProduct.Eliminarproducto(objproducto);
        }
        public producto Consultarproducto(int intproducto)
        {
            return dbProduct.Consultarproducto(intproducto);
        }
        public List<producto> Consultarproductos()
        {
            return dbProduct.Consultarproductos();
        }
    }
}
