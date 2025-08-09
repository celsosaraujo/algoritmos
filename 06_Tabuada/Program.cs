﻿using System;

namespace _06_Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplicando = 0, produto;
            bool digitacaoInvalida = false;

            // ! negação: inverte o valor booleano
            // !false = true
            // !true = false
            while ( !digitacaoInvalida )
            { 
                Console.WriteLine("Digite um número inteiro");
                digitacaoInvalida = int.TryParse(Console.ReadLine(), out  multiplicando);
            }

            Console.WriteLine("TABUADA DO {0}", multiplicando);
            for ( int multiplicador = 1; multiplicador <= 10 ; multiplicador++)
            {
                produto = multiplicando * multiplicador;
                Console.WriteLine("{0} x {1} = {2} ", multiplicando, multiplicador, produto);
            }

        }
    }
}
