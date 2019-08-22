using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Peso { get; set; }
        public string Actor { get; set; }

        public Alumno (string nombre, string matricula, string peso, string actor)
        {
            Nombre = nombre;
            Matricula = matricula;
            Peso = peso;
            Actor = actor;
        }
        public Alumno(string nombre, string matricula)
        {
            Nombre = nombre;
            Matricula = matricula;
        }

    }
}
