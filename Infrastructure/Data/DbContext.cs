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
    //RELACION DE LAS ENTIDADES (esto es lo que te digo que falta, esto tambien lo pide el profesor)
    public DbSet<Personaje> Personajes {get;set;}
    public DbSet<Misiones> Misiones {get;set;}
    public DbSet<Enemigos> Enemigos {get;set;}
    public DbSet<Objetos> Objetos {get;set;}
    public DbSet<Ubicacion> Ubicacion {get;set;}
      public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
{
}
    protected override void OnModelCreating(ModelBuilder builder)
{

    //RELACION DE LA CONFIGURACION 
    
    builder.ApplyConfiguration(new PersonajeConfigurations());
    builder.ApplyConfiguration(new MisionConfigurations());
    builder.ApplyConfiguration(new ObjetoConfigurations());
    builder.ApplyConfiguration(new EnemigoConfigurations());
     builder.ApplyConfiguration(new UbicacionConfigurations());


}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    =>
    optionsBuilder.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw");
}
}