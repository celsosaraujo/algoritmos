using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _08_ValidaCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite o CPF: ");
            string cpf = Console.ReadLine();

            // 1 - Eliminar caractres não numéricos
            cpf = Regex.Replace(cpf, "[^0-9]", "");

            // 2 - Validar se tem 11 digitos
            if (cpf.Length != 11)
            {
                Console.WriteLine("CPF deve conter 11 digitos");
                return;
            }

            // 3- Validas CPFs com todos os números iguais
           if( cpf.Distinct().Count() == 1)    
            {
                Console.WriteLine("CPF inválido! Números repetidos não são permitidos");
                return;
            }

            //4 - Cálculo do 1º Digito verificador            
            int digX = CalculaDV(cpf, 9, 10);

            //5 - Cálculo do 2º Digito Verificador            
            int digY = CalculaDV(cpf, 10, 11);

            //6 - Comparar os dígitos
            if (
                int.Parse(cpf[9].ToString()) == digX   &&
                int.Parse(cpf[10].ToString()) == digY 
               ) 
            {
                Console.WriteLine("CPF VÁLIDO!");
            }
            else
            {
                Console.WriteLine("CPF INVÁLIDO!");
            }
        }

        public static int CalculaDV( string cpf, int qtdeNumeros, int peso )
        {
            int soma = 0;
            char[] cpfVetor = cpf.ToCharArray();

            for (int i = 0; i < qtdeNumeros; i++)
            {
                soma += int.Parse(cpfVetor[i].ToString()) * (peso - i);
            }
            int resto = soma % 11;

            int digito = 0;
            if (resto >= 2)
            {
                digito = 11 - resto;
            }
            return digito;
        }

    }
}
