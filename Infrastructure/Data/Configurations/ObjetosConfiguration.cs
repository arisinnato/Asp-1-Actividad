using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Entidades;

namespace Infrastructure.Data.Configurations
{
   public class ObjetoConfigurations : IEntityTypeConfiguration<Objetos>
    {
        public void Configure(EntityTypeBuilder<Objetos> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Nombre).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Descripcion).HasMaxLength(500);
            builder.Property(x => x.Tipo).IsRequired().HasMaxLength(50);

            builder.ToTable("Objeto");
        }
    }
}