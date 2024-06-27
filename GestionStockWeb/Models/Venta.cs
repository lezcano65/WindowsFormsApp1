using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionStockWeb.Models;

public partial class Venta
{
    public int VentaId { get; set; }
    [Required(ErrorMessage ="El campo Fecha es obligatorio")]
    public DateOnly? FechaV { get; set; }
    [Required(ErrorMessage = "El campo Cantidad es obligatorio")]
    public int? CantidadV { get; set; }
    [Required(ErrorMessage = "El campo ProductoId es obligatorio")]
    public int? ProductoFk { get; set; }

    public int? UsuarioFk { get; set; }

    public virtual Producto? ProductoFkNavigation { get; set; }

    public virtual Usuario? UsuarioFkNavigation { get; set; }
}
