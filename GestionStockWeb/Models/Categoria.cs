using System;
using System.Collections.Generic;

namespace GestionStockWeb.Models;

public partial class Categoria
{
    public int CategoriaId { get; set; }

    public string? NombreCat { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
