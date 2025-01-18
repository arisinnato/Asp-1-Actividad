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

    }
}