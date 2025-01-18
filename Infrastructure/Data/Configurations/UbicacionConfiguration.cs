using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Entidades;


namespace Infrastructure.Data.Configurations
{
    public class UbicacionConfigurations : IEntityTypeConfiguration<Ubicacion>
    {
        public void Configure(EntityTypeBuilder<Ubicacion> builder)
        {
            // Definir la clave primaria
            builder.HasKey(x => x.Id);

            // Definir cómo manejar el Id como columna autoincremental
            builder.Property(x => x.Id).UseIdentityColumn();

            // Definir las propiedades requeridas
            builder.Property(x => x.Nombre)
                .IsRequired()
                .HasMaxLength(255);  // Ajusta el tamaño según sea necesario

            builder.Property(x => x.Descripcion)
                .HasMaxLength(500);  // Ajusta el tamaño según sea necesario

            builder.Property(x => x.Coordenadas)
                .HasMaxLength(255);  // Ajusta el tamaño según sea necesario

            // Configura el nombre de la tabla en la base de datos
            builder.ToTable("Ubicacion");
        }
    }
}