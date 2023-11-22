using CaadTec.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaadTec.Infraestructure.Data.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuarios>
    {
        public void Configure(EntityTypeBuilder<Usuarios> builder)
        {
            builder.ToTable("Usuarios", schema: "dbo");

            builder.HasKey(e => e.Id_usuario).HasName("Id_usuario");
            builder.Property(e => e.Nombre).HasMaxLength(70);
            builder.Property(e => e.Apellido1).HasMaxLength(70);
            builder.Property(e => e.Apellido2).HasMaxLength(70);
            builder.Property(e => e.Telefono).HasMaxLength(70);
            builder.Property(e => e.Correo).HasMaxLength(70);
            builder.Property(e => e.Fecha_creacion).HasColumnType("Datetime");
        }
    }
}
