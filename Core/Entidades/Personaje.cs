using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces.Entidades;

namespace Core.Entidades
{
    public class Personaje : IPersonaje
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int vida { get; set; }
        public string salud {get;set;}
        public int nivel { get; set; }
        public int Fuerza { get; set; } 
        public int Inteligencia { get; set; } 
        public int Agilidad { get; set; } 
        public List<Equipo> Equipo { get; set; } 
        public List<Habilidad> Habilidades { get; set; }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Nivel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Salud { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Energia { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Personaje()
        {
            Equipo = new List<Equipo>();
            Habilidades = new List<Habilidad>();
        }

    }

    public class Habilidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int CostoEnergia { get; set; } 
        public int Potencia { get; set; } 
    }

    public class Equipo
    {
        public int Id { get; set; }
        public string Casco { get; set; } 
        public string Coraza { get; set; } 
        public string Arma1 { get; set; } 
        public string Arma2 { get; set; } 
        public string Guanteletes { get; set; } 
        public string Grebas { get; set; } 
    }
}