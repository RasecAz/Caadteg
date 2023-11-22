namespace CaadTec.Core.Entities
{
    public class Pedidos: BaseEntity
    {
        public int Id_pedido {  get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha_pedido { get; set; }
        public DateTime Fecha_ingreso { get; set; }
        public float Cantidad {  get; set; }
        public string? Nombre_producto { get; set; }
        public int Id_producto { get; set; }

    }
}
