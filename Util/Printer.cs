using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int tamaño = 10)
        {
            //var linea = "".PadLeft(tamaño, '=');
            WriteLine("".PadLeft(tamaño, '='));
        }

        public static void DibujarTitulo(string titulo)
        {
            var tamaño = titulo.Length + 4;
            DibujarLinea(tamaño);
            WriteLine($"| {titulo} |");
            DibujarLinea(tamaño);
        }

        public static void Beep(int hz = 2000, int tiempo = 500, int cantidad = 1)
        {
            while(cantidad-- > 0)
            {
                System.Console.Beep(hz,tiempo);
            }
        }
    }
}