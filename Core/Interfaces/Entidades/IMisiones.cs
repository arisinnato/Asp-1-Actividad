using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces.Entidades
{
    public interface IMisiones
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<string> Objetivos { get; set; }
        public int Experiencia { get; set; }
        public List<Core.Entidades.Objetos> ObjetosRecompensa { get; set; }
        public string Estado { get; set; }
    }
}