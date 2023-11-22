namespace CaadTec.Core.DTO_s
{
    public class ProductoDTO
    {
        public string? Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha_ingreso { get; set; }
        public DateTime Fecha_caducidad { get; set; }
        public float? Cantidad { get; set; }
    }
}
