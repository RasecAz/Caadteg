namespace CaadTec.Core.DTO_s
{
    public class PedidoDTO
    {
        public string Descripcion { get; set; }
        public DateTime Fecha_pedido { get; set; }
        public float Cantidad { get; set; }
        public string? Nombre_producto { get; set; }
    }
}
