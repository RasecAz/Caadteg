using System.ComponentModel.DataAnnotations.Schema;

namespace CaadTec.Core.Entities
{
    public abstract class BaseEntity
    {
        [Column("Fecha_creacion")]
        public virtual DateTime Fecha_creacion { get; set; }
    }
}
