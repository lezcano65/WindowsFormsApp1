using System;
using System.Collections.Generic;

namespace GestionStockWeb.Models;

public partial class Producto
{
    public int ProductoId { get; set; }

    public string? NombreP { get; set; }

    public bool? Habilitado { get; set; }

    public int? CategoriaFk { get; set; }

    public int? CantidadP { get; set; }

    public virtual Categoria? CategoriaFkNavigation { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
