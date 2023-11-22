using CaadTec.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaadTec.Infraestructure.Data.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedidos>
    {
        public void Configure(EntityTypeBuilder<Pedidos> builder)
        {
            builder.ToTable("Pedidos", schema: "dbo");

            builder.HasKey(e => e.Id_pedido).HasName("Id_pedido");
            builder.Property(e => e.Descripcion).HasMaxLength(200);
            builder.Property(e => e.Fecha_pedido).HasColumnType("datetime");
            builder.Property(e => e.Fecha_ingreso).HasColumnType("datetime");
            builder.Property(e => e.Cantidad).HasColumnType("float");
            builder.Property(e => e.Nombre_producto).HasMaxLength(70);
            builder.Property(e => e.Id_producto).HasColumnType("int");


        }
    }
}
