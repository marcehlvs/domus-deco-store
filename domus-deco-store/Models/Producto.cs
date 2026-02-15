using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace domus_deco_store.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = null!;
        [Required]
        [StringLength(100)]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; } = null!;
        [Required]
        [Range(0,100000)]
        [Display(Name = "Precio ($)")]
        public decimal Precio { get; set; }
        [Required]
        [Range (0, 10000)]
        [Display(Name = "Stock")]
        public int Cantidad { get; set; }
        [Required]
        [Url]
        [Display(Name = "URL de la imagen")]
        public string ImagenUrl { get; set; } = null!;
        [Display(Name = "Producto Activo")]
        public bool Activo  { get; set; }
        [Required]
        [Display(Name = "Medida (cm)")]
        public string Medida { get; set; } = null!;

        //Relaciones
        [Required]
        [Display(Name = "Categoría")]
        public int? CategoriaId { get; set; }
        [ValidateNever]
        [Display(Name = "Categoría")]
        public Categoria Categoria { get; set; } = null!;

        [Required]
        [Display(Name = "Marca")]
        public int? MarcaId { get; set; }
        [ValidateNever]
        public Marca Marca { get; set; } = null!;

        public List<PedidoDetalle> PedidoDetalles { get; set; } = new();
        public List<FavoritoProducto> UsuariosFavorito { get; set;  } = new();

    }
}
