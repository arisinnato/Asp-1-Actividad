using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces.Entidades;

namespace Core.Entidades
{
    public class Ubicacion : IUbicacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Coordenadas { get; set; }
    }
}