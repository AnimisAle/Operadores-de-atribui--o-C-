using System;

namespace Operadores
{

	class App1
	{
		static void Main(string[] args)
		{
			int a = 2;
			System.Console.WriteLine("Valor de a: " + a);

			System.Console.WriteLine("--------------------------");

			a += 1;
			System.Console.WriteLine("Valor de a após o incremento: " + a);

			System.Console.WriteLine();
			System.Console.WriteLine("######################################");
			System.Console.WriteLine();

			string b = "ABC";

			System.Console.WriteLine("String : " + b);

			System.Console.WriteLine("--------------------------");

			b += "DEF";

			System.Console.WriteLine("Valor de B pós o incremento da string: " + b);
			System.Console.WriteLine();

			// Operador aritmético ++ ou -- 
			int c = 10; 
			c++;
			System.Console.WriteLine(c);

			int d = 10;
			d--;
			System.Console.WriteLine(d);

System.Console.WriteLine("--------------------------");

int teste1 = 10;
int teste2 = ++teste1; 
System.Console.WriteLine(teste1);
System.Console.WriteLine(teste2);



		}

	}
}
