using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces.Entidades
{
    public interface IEnemigos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int NivelDeAmenaza { get; set; }
        public int Salud { get; set; }
        public int Energia { get; set; }
        public int Fuerza { get; set; }
        public int Inteligencia { get; set; }
        public int Agilidad { get; set; }
        public int ExperienciaRecompensa { get; set; }
        public List<Core.Entidades.Objetos> ObjetosRecompensa { get; set; }
        
        //public List<Core.Entidades.Habilidad> Habilidades { get; set; }
    }
}