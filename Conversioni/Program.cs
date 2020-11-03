using System;

namespace Conversioni
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int divisore;
            int resto;
            string numeroConvertito = "";

            Console.WriteLine("Inserisci un numero");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci un divisore");
            divisore = Convert.ToInt32(Console.ReadLine());

            while (numero > 0)
            {
                resto = numero % divisore;
                numero = numero / 2;
                numeroConvertito = Convert.ToString(resto) + numeroConvertito;
            }

            Console.WriteLine($"{numeroConvertito}");
            Console.ReadKey();
        }
    }
}
