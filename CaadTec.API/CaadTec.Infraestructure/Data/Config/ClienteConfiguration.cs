using CaadTec.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaadTec.Infraestructure.Data.Config
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes", schema: "dbo");

            builder.HasKey(e => e.Id_cliente).HasName("Id_cliente");
            builder.Property(e => e.Nombre).HasMaxLength(70);
            builder.Property(e => e.Apellido1).HasMaxLength(70);
            builder.Property(e => e.Apellido2).HasMaxLength(70);
            builder.Property(e => e.Telefono).HasMaxLength(70);
            builder.Property(e => e.Fecha_creacion).HasColumnType("datetime");
        }
    }
}
