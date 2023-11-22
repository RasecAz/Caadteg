using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaadTec.Core.Entities
{
    public class Productos: BaseEntity
    {
        public int Id_producto { get; set; }
        public string? Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Id_UnidadMedida { get; set; }
        public DateTime Fecha_ingreso { get; set; }
        public DateTime Fecha_caducidad { get; set; }
        public float? Cantidad { get; set; }
    }
}
