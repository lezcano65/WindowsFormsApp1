using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionStockWeb.Models;

public partial class Producto
{
    public int ProductoId { get; set; }
    [Required(ErrorMessage = "El campo Nombre es obligatorio")]
    public string? NombreP { get; set; }
    [Required(ErrorMessage = "El campo Habilitado es obligatorio")]
    public bool? Habilitado { get; set; }
    [Required(ErrorMessage = "El campo Categoria es obligatorio")]
    public int? CategoriaFk { get; set; }
    [Required(ErrorMessage = "El campo Cantidad es obligatorio")]
    public int? CantidadP { get; set; }
    [Required(ErrorMessage = "El campo Categoria es obligatorio")]
    public virtual Categoria? CategoriaFkNavigation { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
