using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }
        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            Escuela = new Escuela("Liceo", 2010, TiposEscuela.Primaria, pais: "Colombia", ciudad: "Sincelejo");

             Escuela.Cursos = new List<Curso>(){
                    new Curso() {Nombre = "101", Jornada= TiposJornada.Mañana},
                    new Curso() { Nombre = "201", Jornada= TiposJornada.Mañana },
                    new Curso { Nombre = "301", Jornada= TiposJornada.Mañana },
                    new Curso { Nombre = "501", Jornada = TiposJornada.Tarde },
                    new Curso { Nombre = "501", Jornada = TiposJornada.Tarde }
            };
        }
    }
}