namespace CaadTec.Core.Entities
{
    public class Cliente : BaseEntity
    {
        public int Id_cliente { get; set; }
        public string? Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string? Telefono { get; set; }
    }
}
