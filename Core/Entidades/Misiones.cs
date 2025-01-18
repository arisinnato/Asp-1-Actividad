using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces.Entidades;

namespace Core.Entidades
{
    public class Misiones 
    {
        public int Id { get; set; }
      
        public string Nombre { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public List<string> Objetivos { get; set; } = new List<string>();

        public string Recompensas { get; set; }

        // Estado de la misión (Activa, Completada, Abandonada)
        public string Estado { get; set; } = "Activa";

        public void CompletarMision()
        {
            Estado = "Completada";
        }
        public void AbandonarMision()
        {
            Estado = "Abandonada";
        }

    }
}