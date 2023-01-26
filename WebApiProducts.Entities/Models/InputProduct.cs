using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiProducts.Entities.Models
{
    public class InputProduct
    {
        public int Idproducto { get; set; }

        public int Idcategoria { get; set; }

        public string? Codigo { get; set; }

        public string Nombre { get; set; } = null!;

        public int PrecioVenta { get; set; }

        public int Stock { get; set; }

        public string Descripcion { get; set; }

        public string Imagen { get; set; }

        public bool Estado { get; set; }
    }
}
