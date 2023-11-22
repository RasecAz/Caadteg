using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaadTec.Core.DTO_s
{
    public class FacturaDTO
    {
        public int Cantidad_productos { get; set; }
        public decimal Total { get; set; }
        public int Num_fac { get; set; }
    }
}
