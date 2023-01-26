using System;
using System.Collections.Generic;

namespace WebApiProducts.Data.Models;

public partial class Categorium
{
    public int Idcategoria { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<Producto> Productos { get; } = new List<Producto>();
}
