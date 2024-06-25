using System;
using System.Collections.Generic;

namespace GestionStockWeb.Models;

public partial class Venta
{
    public int VentaId { get; set; }

    public DateOnly? FechaV { get; set; }

    public int? CantidadV { get; set; }

    public int? ProductoFk { get; set; }

    public int? UsuarioFk { get; set; }

    public virtual Producto? ProductoFkNavigation { get; set; }

    public virtual Usuario? UsuarioFkNavigation { get; set; }
}
