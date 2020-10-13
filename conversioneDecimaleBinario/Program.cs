using System;

namespace conversioneDecimaleBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, resto;
            Console.Write("inserisci un numero da convertitre: ");
            num = int.Parse(Console.ReadLine());
            string binario = "";
            while (num > 0)
            {
                resto = num % 2;
                num /= 2;
                binario = Convert.ToString(resto) + binario;

            }
            Console.WriteLine($"il numero in binario è {binario}");
            Console.ReadLine();
        }
    }
}
