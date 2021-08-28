using System;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com um Número Inteiro");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
