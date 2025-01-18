using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces.Entidades;

namespace Core.Entidades
{
    public class Enemigos 
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int NivelDeAmenaza { get; set; }
        public int ExperienciaRecompensa { get; set; } 

        /*public List<Objeto> ObjetosRecompensa { get; set; } = new List<Objeto>(); 
        public List<Habilidad> Habilidades { get; set; } = new List<Habilidad>();*/
        public int Salud { get; set; } // Vitalidad del enemigo (HP)
        public int Energia { get; set; } // Energía para habilidades especiales (MP)
        public int Fuerza { get; set; } // Influye en daño físico
        public int Inteligencia { get; set; } // Influye en daño mágico y habilidades
        public int Agilidad { get; set; } // Influye en velocidad y evasión
    }
}