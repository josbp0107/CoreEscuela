using System;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Liceo", 2010, TiposEscuela.Primaria, pais:"Colombia", ciudad:"Sincelejo");
            Console.WriteLine(escuela);
        }
    }
}
