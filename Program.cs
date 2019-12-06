using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Liceo", 2010, TiposEscuela.Primaria, pais: "Colombia", ciudad: "Sincelejo");

            escuela.Cursos = new List<Curso>(){
                    new Curso() {Nombre = "101", Jornada= TiposJornada.Mañana},
                    new Curso() { Nombre = "201", Jornada= TiposJornada.Mañana },
                    new Curso { Nombre = "301", Jornada= TiposJornada.Mañana }
            };

            escuela.Cursos.Add(new Curso() { Nombre = "501", Jornada = TiposJornada.Mañana });
            escuela.Cursos.Add(new Curso() { Nombre = "501", Jornada = TiposJornada.Tarde });
            ImprimirCursosEscuelas(escuela);

            escuela.Cursos.RemoveAll(delegate (Curso cur)
            {
                return cur.Nombre == "301";
            });

            escuela.Cursos.RemoveAll((Curso cur) => cur.Nombre == "501" && cur.Jornada == TiposJornada.Tarde);//Lamda para eliminar un objeto o varios objetos pasandole un atributo 


            WriteLine("===========");
            ImprimirCursosEscuelas(escuela);

        }

        // private static bool Predicado(Curso obj)
        // {
        //     return obj.Nombre == "301";
        // }

        private static void ImprimirCursosEscuelas(Escuela escuela)
        {
            WriteLine("====================");
            WriteLine("Cursos de la escuela");
            WriteLine("====================");

            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
                }
            }

        }

    }
}
