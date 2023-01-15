using AG_CategoryProducts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AG_CategoryProducts.Bussines
{
    public interface IProductsBL
    {
        public bool Insertarproducto(producto objproducto);
        public bool Actualizarproducto(producto objproducto);
        public bool Eliminarproducto(producto objproducto);
        public producto Consultarproducto(int intproducto);
        public List<producto> Consultarproductos();
    }
}
