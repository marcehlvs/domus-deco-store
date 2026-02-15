namespace domus_deco_store.Models
{
    public class FavoritoProducto
    {
        public int Id { get; set; }
        public string UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

        public DateTime Fecha { get; set; }
    }
}
