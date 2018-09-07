using System;

namespace listaFichero2
{
    class Program 
    {
        public static void EscribirNumeroReal(float n)
        {
            Console.WriteLine(n.ToString("#.###"));
        }
        public static void Main()
        {
            float x;
            x = 5.1f;
            Console.WriteLine("El primer numero real es: ");
            EscribirNumeroReal(x);
            Console.WriteLine("Y otro distinto es: ");
            EscribirNumeroReal (2.3f);
            Console.ReadKey();

        }

         


    }
}
