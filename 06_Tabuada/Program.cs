using System;

namespace _06_Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplicando, produto;

            Console.WriteLine("Digite um número inteiro");
            multiplicando = int.Parse( Console.ReadLine() );

            Console.WriteLine("TABUADA DO {0}", multiplicando);
            for ( int multiplicador = 1; multiplicador <= 10 ; multiplicador++)
            {
                produto = multiplicando * multiplicador;
                Console.WriteLine("{0} x {1} = {2} ", multiplicando, multiplicador, produto);
            }

        }
    }
}
