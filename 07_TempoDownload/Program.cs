using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_TempoDownload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tamanhoMB = 0;
            double velocidadeMbps = 0;
            double tempoSegundos, tempoMinutos;

            // Loop infinito
            while (true)
            {
                // Operadores lógicos
                // && -> AND (e lógico)
                // || -> OR  (ou lógico)
                Console.Write("Informe o tamanho do arquivo (MB): ");
                if (double.TryParse(Console.ReadLine(), out tamanhoMB) && tamanhoMB > 0)
                    // sai do loop
                    break;
                else
                    Console.WriteLine("Valor inválido! Digite um número maior que zero.");
            }

            while (true)
            {
                Console.Write("Informe a velocidade da internet (Mbps): ");
                if (double.TryParse(Console.ReadLine(), out velocidadeMbps) && velocidadeMbps > 0)
                    break;
                else
                    Console.WriteLine("Valor inválido! Digite um número maior que zero.");
            }
            // Cálculo do tempo
            tempoSegundos = (tamanhoMB * 8) / velocidadeMbps;
            tempoMinutos = tempoSegundos / 60;
            // Saída formatada
            Console.WriteLine($"Tempo aproximado de download: {tempoMinutos:F2} minutos");

        }
    }
}
