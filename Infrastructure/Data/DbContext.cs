using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entidades;
using Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Data
{
   public class AppDbContext : DbContext
{
    public DbSet<Personaje> Personajes {get;set;}
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
{
}
    protected override void OnModelCreating(ModelBuilder builder)
{
    builder.ApplyConfiguration(new PersonajeConfigurations());
    builder.ApplyConfiguration(new MisionConfigurations());
    builder.ApplyConfiguration(new ObjetoConfigurations());
    builder.ApplyConfiguration(new EnemigoConfigurations());

}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    =>
    optionsBuilder.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw");
}
}