using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces.Entidades
{
    public interface IUbicacion
    {
        int Id { get; set; }
        string Nombre { get; set; }
        string Descripcion { get; set; }
        string Coordenadas { get; set; }
    }
}