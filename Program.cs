using System;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var arregloCursos = new Curso[3];
            
            var escuela = new Escuela("Liceo", 2010, TiposEscuela.Primaria, pais:"Colombia", ciudad:"Sincelejo");

            arregloCursos[0]  = new Curso()
            {
                Nombre = "101"
            };
            var curso2 = new Curso()
            {
                Nombre = "201"
            };
            arregloCursos[1] = curso2;
            
            arregloCursos[2] = new Curso
            {
                Nombre = "301"
            };

            Console.WriteLine(escuela);
            System.Console.WriteLine("##############");
           
           ImprimirCursosForEach(arregloCursos);
        }

        private static void ImprimirCursos(Curso[] arregloCursos)
        {
        
            int contador=0;
            while(contador < arregloCursos.Length)
            {
                Console.WriteLine($"Nombre {arregloCursos[contador].Nombre}, Id {arregloCursos[contador].UniqueId}");
                contador++;
            }
        }

        private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
        {
            int contador=0;
            do
            {
                Console.WriteLine($"Nombre {arregloCursos[contador].Nombre}, Id {arregloCursos[contador].UniqueId}");
                contador++;
            } while (contador < arregloCursos.Length);
        }

        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                Console.WriteLine($"Nombre {arregloCursos[i].Nombre}, Id {arregloCursos[i].UniqueId}");
            }    
        }

        private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                Console.WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
            } 
        }
    }
}
