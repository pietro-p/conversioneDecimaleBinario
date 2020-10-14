using System;

namespace conversioneDecimaleBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, resto,bas;
            Console.Write("inserisci un numero da convertitre: ");            
            num = int.Parse(Console.ReadLine());
            Console.Write("inserisci la base:  ");
            bas = int.Parse(Console.ReadLine());
            string binario = "";
            while (num > 0)
            {
                resto = num % bas;
                num /= bas;
                binario = Convert.ToString(resto) + binario;

            }
            Console.WriteLine($"il numero convertito è {binario}");
            Console.ReadLine();
        }
    }
}
