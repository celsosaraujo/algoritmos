using System;
 
class DeclaracaoVariaveisDecimalFormatado

{

		static void Main(string[] args)

		{

			decimal x = 0.999m;

			decimal y = 9999999999999999999999999999m;
			
			/*Placeholder para demonstrar o conteúdo de uma variável no texto 
			onde {0:C}
			0 = posição de marcação
			C = formatação de moeda(Currency) 
			*/

			Console.WriteLine("Minha quantia = {0:C}", x); 

			Console.WriteLine("Sua quantia = {0:C}", y);
			
			Console.WriteLine("Valor de x = {0:F3} e Valor de y = {1:C}", x,y);
			
			/*interpolação de string
			
			decimal x = 0.999m;
			decimal y = 9999999999999999999999999999m;

			Console.WriteLine($"Minha quantia = {x:C}");
			Console.WriteLine($"Sua quantia = {y:C}");
			Console.WriteLine($"Valor de x = {x:F3} e Valor de y = {y:C}");*/


}
 