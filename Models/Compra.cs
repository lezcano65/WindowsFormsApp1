using System;
using System.Collections.Generic;

namespace GestionStockWeb.Models;

public partial class Compra
{
    public int CompraId { get; set; }

    public DateOnly? FechaC { get; set; }

    public int? CantidadC { get; set; }

    public int? ProductoFk { get; set; }

    public int? UsuarioFk { get; set; }

    public virtual Producto? ProductoFkNavigation { get; set; }

    public virtual Usuario? UsuarioFkNavigation { get; set; }
}
