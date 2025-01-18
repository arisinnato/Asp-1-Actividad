using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entidades;
using Core.Interfaces.Entidades;

namespace Core.Interfaces.Entidades
{
    public interface IPersonaje
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public int Salud { get; set; }
        public int Energia { get; set; }
        public int Fuerza { get; set; }
        public int Inteligencia { get; set; }
        public int Agilidad { get; set; }
        public List<Core.Entidades.Equipo> Equipo { get; set; } 
        public List<Core.Entidades.Habilidad> Habilidades { get; set; } 
    }
}