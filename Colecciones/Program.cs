using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> alumnos = new List<Alumno>();

            alumnos.Add(new Alumno("Jesus", "189289"));
            alumnos.Add(new Alumno("Ana", "189100"));

            foreach(Alumno alumno in alumnos)
            {
                Console.WriteLine("Nombre: " + alumno.Nombre);
                Console.WriteLine("Matrícula: " + alumno.Matricula);
            }

            Console.ReadKey();
        }
    }
}
