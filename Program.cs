using System;

namespace CoreEscuela
{
    class Escuela
    {
        public string nombre;
        public string direccion;
        public int añoFundacion;
        public string ceo;
        public void Timbrar()
        {
            //Todo
            Console.Beep(10000, 3000);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var miEscuela = new Escuela();
            miEscuela.nombre = "Liceo Panamericano";
            miEscuela.direccion = "Cra 23 #23-123";
            miEscuela.añoFundacion = 1998;
            Console.WriteLine("TIMBRA");
            miEscuela.Timbrar();
            //Console.WriteLine("Hello World!");
        }
    }
}
