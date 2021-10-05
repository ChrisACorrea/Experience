using System;

Console.Write("Digite um número: ");
int numeroDeEntrada = int.Parse(Console.ReadLine());
bool ehPrimo = ehNumeroPrimo(numeroDeEntrada);

Console.WriteLine($"O número {numeroDeEntrada}{(!ehPrimo ? " não": "")} é primo");
Console.ReadKey();

bool ehNumeroPrimo(int numero)
{
	int totalDeDivisoesExatas = 0;

	for (int i = 1; i <= numero; i++)
	{
		double restoDaDivisao = numero % i;

		if (restoDaDivisao is 0)
		{
			totalDeDivisoesExatas++;
		}

		if (totalDeDivisoesExatas is > 2)
		{
			return false;
		}
	}

	return true;
}
