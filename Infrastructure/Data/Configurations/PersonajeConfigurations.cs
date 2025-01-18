using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Entidades;


namespace Infrastructure.Data.Configurations
{
    public class PersonajeConfigurations : IEntityTypeConfiguration<Personaje>
    {
        public void Configure(EntityTypeBuilder<Personaje> builder){
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).UseIdentityColumn();
            builder.Property(x => x.nombre).IsRequired().HasMaxLength(255);
            builder.Property(p => p.vida).IsRequired();
            builder.Property(p => p.nivel).IsRequired();
            builder.Property(p => p.salud).IsRequired();
            builder.Property(p => p.Fuerza).IsRequired();
            builder.Property(p => p.Inteligencia).IsRequired();
            builder.Property(p => p.Agilidad).IsRequired();

            builder.ToTable("Personaje");
    }

    }
}