namespace CaadTec.Core.Entities
{
    public class Facturas : BaseEntity
    {
        public int Id_factura  { get; set; }
        public int Cantidad_productos { get; set; }
        public decimal Total { get; set; }
        public int Num_fac { get; set;}
        public int Id_cliente { get; set; }

    }
}
