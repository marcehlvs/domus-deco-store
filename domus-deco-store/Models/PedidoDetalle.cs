namespace domus_deco_store.Models
{
    public class PedidoDetalle
    {
        // FK al pedido
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        // FK al producto
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

        // Cantidad comprada de este producto
        public int Cantidad { get; set; }

        // Precio del producto en el momento de la compra
        public decimal PrecioUnitario { get; set; }
    }
}

