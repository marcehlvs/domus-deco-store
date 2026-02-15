namespace domus_deco_store.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        // Usuario que realizó el pedido
        public string UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public DateTime Fecha { get; set; }

        // Total del pedido (suma de los detalles)
        public decimal Total { get; set; }

        // Un pedido tiene muchos detalles
        public List<PedidoDetalle> Detalles { get; set; }
    }
}

