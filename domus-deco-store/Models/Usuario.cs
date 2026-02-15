using Microsoft.AspNetCore.Identity;

namespace domus_deco_store.Models
{
    public class Usuario:IdentityUser

    {
     public string Id { get; set; } // Identity
     public string Nombre { get; set; }
        public string Apellido { get; set; }

     // Navegación
     public List<Pedido> Pedidos { get; set; }
     public List<FavoritoProducto> Favoritos { get; set; }
    }

}

