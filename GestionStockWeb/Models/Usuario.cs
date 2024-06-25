using System;
using System.Collections.Generic;

namespace GestionStockWeb.Models;

public partial class Usuario
{
    public int UsuarioId { get; set; }

    public string? NombreU { get; set; }

    public string? HashU { get; set; }

    public string? Salt { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
