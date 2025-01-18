using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Entidades;

namespace Infrastructure.Data.Configurations
{
    public class EnemigoConfigurations : IEntityTypeConfiguration<Enemigos>
    {
        public void Configure(EntityTypeBuilder<Enemigos> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Nombre).IsRequired().HasMaxLength(255);
            builder.Property(x => x.NivelDeAmenaza).IsRequired();
            builder.Property(x => x.Salud).IsRequired();
            builder.Property(x => x.Energia).IsRequired();
            builder.Property(x => x.Fuerza).IsRequired();
            builder.Property(x => x.Inteligencia).IsRequired();
            builder.Property(x => x.Agilidad).IsRequired();

            // Configuración para Recompensas de Experiencia
            /*builder.Property(x => x.ExperienciaRecompensa).IsRequired();

            // Configuración para ObjetosRecompensa
            builder.HasMany(x => x.ObjetosRecompensa)
                   .WithOne()
                   .OnDelete(DeleteBehavior.Cascade);

            // Configuración para Habilidades
            builder.HasMany(x => x.Habilidades)
                   .WithOne()
                   .OnDelete(DeleteBehavior.Cascade);*/

            builder.ToTable("Enemigo");
        }
    }
}