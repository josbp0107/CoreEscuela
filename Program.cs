using System;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Liceo", 2010, TiposEscuela.Primaria, pais:"Colombia", ciudad:"Sincelejo");
            var curso = new Curso()
            {
                Nombre = "101"
            };
            var curso2 = new Curso()
            {
                Nombre = "201"
            };
            var curso3 = new Curso()
            {
                Nombre = "301"
            };

            Console.WriteLine(escuela);
            System.Console.WriteLine("##############");
            Console.WriteLine(curso.Nombre+","+ curso.UniqueId);
            Console.WriteLine(curso2.Nombre+","+ curso2.UniqueId);
            Console.WriteLine(curso3.Nombre+","+ curso3.UniqueId);
        }
    }
}
