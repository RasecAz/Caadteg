using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaadTec.Core.Entities
{
    public class UnidadMedida: BaseEntity
    {
        public int Id_UnidadMedida { get; set; }
        public int Unidad { get; set; }
        public int Caja { get; set; }
        public int Paquete { get; set; }
        public int Bulto { get; set; }
    }
}
