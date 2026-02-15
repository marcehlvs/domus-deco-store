using System.ComponentModel.DataAnnotations;

namespace domus_deco_store.Models
{
    public class Marca
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = null!;

        // Navegación
        public List<Producto> Productos { get; set; } = new();  
    }
}
