namespace CaadTec.Core.Entities
{
    public class Usuarios: BaseEntity
    {
        public int Id_usuario { get; set; }
        public string? Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Telefono { get; set; } 
        public string? Correo { get; set; }
    }
}
