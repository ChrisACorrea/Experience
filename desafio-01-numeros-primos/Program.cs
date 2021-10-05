using System;

const string TITULO = "Verificador de Números Primos"; 
Console.Title = TITULO;
bool estaRodando = true;

while (estaRodando)
{
	bool entradaValida = false;
	int numeroDeEntrada = 0;
	escreverTitulo();

	do
	{
		Console.Write("Digite um número: ");

		try
		{
			numeroDeEntrada = int.Parse(Console.ReadLine());
			entradaValida = true;
		}
		catch (FormatException)
		{
			Console.WriteLine("O valor inserido deve ser um número e um número inteiro. Também não pode ser vazio.");
		}
		catch (OverflowException)
		{
			Console.WriteLine("Ops!!! Esse é um valor muito alto. Tente com um menor.");
		}
		catch (Exception)
		{
			Console.WriteLine("Deu ruim!!!");
			throw;
		}

	} while (!entradaValida);

	bool ehPrimo = ehNumeroPrimo(numeroDeEntrada);

	Console.WriteLine($"O número {numeroDeEntrada}{(!ehPrimo ? " não": "")} é primo");
	Console.WriteLine();
	questionarSaida();
	
}

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

void escreverTitulo()
{
	Console.WriteLine("#################################");
	Console.WriteLine($"# {TITULO} #");
	Console.WriteLine("#################################");
	Console.WriteLine();
}

void questionarSaida()
{
	Console.WriteLine("Pressione 'ESC' para sair do programa ou qualquer outra tecla para realizar outra verificação.");
	var teclaPressionada = Console.ReadKey();

	if (teclaPressionada.Key.Equals(ConsoleKey.Escape))
	{
		estaRodando = false;
	}

	Console.Clear();
}
