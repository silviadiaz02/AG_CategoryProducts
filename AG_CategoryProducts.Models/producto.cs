using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AG_CategoryProducts.Models
{
	public class producto
	{
		public int idproducto { get; set; }
		public int idcategoria { get; set; }
		public string codigo { get; set; }
		public string nombre { get; set; }
		public decimal precio_venta { get; set; }
		public int stock { get; set; }
		public string descripcion { get; set; }
		public string imagen { get; set; }
		public bool estado { get; set; }

	}
}
