using System;
using System.Linq;

namespace _05_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criação de um vetor para armazenamento de 100 elementos
            // string [] nomes = {"Fulano","Beltrano", "Scrano"};
            string[] nomes = new string[100];
            string continuar = "S";

            //será meu indice para atribuição no vetor
            int contador = 0;

            //Loop while
            // Sintaxe: while( expressão booleana)
            // método toUpper(): converte o texto para maiúsculo
            while (continuar.ToUpper() == "S")
            {
                Console.WriteLine("Digite o {0}ª nome: ", contador+1);
                //Append: adiciona um item no vetor
                nomes[contador] = Console.ReadLine();

                //incrementar o contador
                contador++;
                Console.WriteLine("Deseja continua? (S/N)");
                continuar = Console.ReadLine();
            }

            Console.WriteLine("Nomes informados:");
            foreach (string str in nomes)
            {
                // != significa diferente
                if (str != null)
                {
                    Console.WriteLine(str);
                }
            }

        }
    }
}
