using System;
using System.ComponentModel.DataAnnotations;

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

            Console.WriteLine("Inserisci un numero decimale intero");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci il divisore");
            divisore = Convert.ToInt32(Console.ReadLine());

            while (numero > 0)
            {
                resto = numero % divisore;
                numero = numero / 16;
                
                if (resto == 10)
                {
                    numeroConvertito = "A" + numeroConvertito;
                }
                else if (resto == 11)
                {
                    numeroConvertito = "B" + numeroConvertito;
                }
                else if (resto == 12)
                {
                    numeroConvertito = "C" + numeroConvertito;
                }
                else if (resto == 13)
                {
                    numeroConvertito = "D" + numeroConvertito;
                }
                else if (resto == 14)
                {
                    numeroConvertito = "E" + numeroConvertito;
                }
                else if (resto == 15)
                {
                    numeroConvertito = "F" + numeroConvertito;
                }
                else
                {
                    numeroConvertito = Convert.ToString(resto) + numeroConvertito;
                }
            }
            Console.WriteLine($"Il numero convertito in esadecimale è uguale a: {numeroConvertito}");
            Console.ReadKey();
        }
    }
}
