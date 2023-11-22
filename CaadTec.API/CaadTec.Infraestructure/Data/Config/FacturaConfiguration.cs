using CaadTec.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaadTec.Infraestructure.Data.Config
{
    internal class FacturaConfiguration : IEntityTypeConfiguration<Facturas>
    {
        public void Configure(EntityTypeBuilder<Facturas> builder)
        {
            builder.ToTable("Facturas", schema: "dbo");

            builder.HasKey(e => e.Id_factura).HasName("Id_factura");
            builder.Property(e => e.Cantidad_productos).HasColumnType("int");
            builder.Property(e => e.Total).HasColumnType("int");
            builder.Property(e => e.Num_fac).HasColumnType("int");
            builder.Property(e => e.Id_cliente).HasColumnType("int");
            builder.Property(e => e.Fecha_creacion).HasColumnType("dateTime");
        }
    }
}
