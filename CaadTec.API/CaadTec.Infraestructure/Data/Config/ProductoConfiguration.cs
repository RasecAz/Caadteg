using CaadTec.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaadTec.Infraestructure.Data.Config
{
    public class ProductoConfiguration : IEntityTypeConfiguration<Productos>
    {
        public void Configure(EntityTypeBuilder<Productos> builder)        
        {
            builder.ToTable("productos", schema: "dbo");

            builder.HasKey(e => e.Id_producto).HasName("Id_producto");
            builder.Property(e => e.Nombre).HasMaxLength(70);
            builder.Property(e => e.Descripcion).HasMaxLength(70);
            builder.Property(e => e.Fecha_creacion).HasColumnType("datetime");
            builder.Property(e => e.Id_UnidadMedida).HasColumnType("int");
            builder.Property(e => e.Fecha_ingreso).HasColumnType("datetime");
            builder.Property(e => e.Fecha_caducidad).HasColumnType("datetime");
            builder.Property(e => e.Cantidad).HasColumnType("Float");
        }
    }
}
