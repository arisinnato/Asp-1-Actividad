using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Entidades;

namespace Infrastructure.Data.Configurations
{
    public class MisionConfigurations : IEntityTypeConfiguration<Misiones>
    {
        public void Configure(EntityTypeBuilder<Misiones> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Nombre).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Descripcion).HasMaxLength(500);
            //builder.Property(x => x.Experiencia).IsRequired();
            builder.Property(x => x.Estado).IsRequired().HasMaxLength(50);

            // Configuración de relaciones
            /*builder.HasMany(x => x.ObjetosRecompensa)
                   .WithOne()
                   .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Mision");*/
        }
    }
}