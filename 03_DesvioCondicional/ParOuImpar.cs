using System;

class ParOuImpar
{
	static void Main()
	{
		int numero;
		
		Console.WriteLine("Digite um número");
		numero = int.Parse( Console.ReadLine() );
		
		if( numero%2 == 0)
			Console.WriteLine("O número é par");		
		else
			Console.WriteLine("O número é impar");				
	}
}