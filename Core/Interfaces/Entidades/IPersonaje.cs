using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces.Entidades
{
    public interface IPersonaje
    {
        public int Id { get; set; } // Identificador único del personaje
        public string nombre { get; set; } = string.Empty; // Nombre del personaje
        public int Nivel { get; set; } // Representa el progreso y experiencia
        public int Salud { get; set; } // Vitalidad del personaje (HP)
        public int Energia { get; set; } // Usada para habilidades especiales y mágicas (MP)

        // Atributos de rendimiento
        public int Fuerza { get; set; } // Influye en el daño físico
        public int Inteligencia { get; set; } // Influye en el daño mágico y habilidades
        public int Agilidad { get; set; } // Influye en velocidad y evasión

        // Relaciones
        public  Equipo { get; set; } = new Equipo(); // Recursos llevados por el personaje
        public List<Habilidad> Habilidades { get; set; } = new List<Habilidad>(); // Habilidades aprendidas por el personaje
    }
}