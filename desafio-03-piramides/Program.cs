using System;

const int alturaMinima = 3;
const int alturaMaxima = 8;
bool valorValido = false;
int altura = 0;

while (!valorValido)
{
	Console.Write($"Escolha uma altura para a pirâmide entre {alturaMinima} e {alturaMaxima}: ");

	try
	{ 
		altura = int.Parse(Console.ReadLine());

		if (altura is < alturaMinima or > alturaMaxima)
		{
			Console.WriteLine("Valor não permitido.");
			Console.WriteLine();
			continue;
		}

		valorValido = true;
		Console.Clear();
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
	finally
	{
		Console.WriteLine();
	}
}

Console.WriteLine($"Altura escolhida: {altura}.");
Console.WriteLine();

imprimePiramides(altura);

Console.WriteLine();
Console.WriteLine("Pressione qualquer tecla para encerrar.");
Console.ReadKey();

void imprimePiramides(int altura)
{
	imprimePiramideEsquerda(altura);
	Console.WriteLine();
	imprimePiramideDireita(altura);
	Console.WriteLine();
	imprimePiramideCentralizada(altura);
}

void imprimePiramideEsquerda(int alturaDesejada)
{
	for (int i = 1; i <= alturaDesejada; i++)
	{
		for (int j = 1; j <= i; j++)
		{
			Console.Write("#");
		}
		Console.WriteLine();
	}
}

void imprimePiramideDireita(int alturaDesejada)
{
	for (int i = 1; i <= alturaDesejada; i++)
	{
		Console.Write(montarPreenchimento(alturaDesejada - i));
		for (int j = 1; j <= i; j++)
		{
			Console.Write("#");
		}
		Console.WriteLine();
	}
}

void imprimePiramideCentralizada(int alturaDesejada)
{
	alturaDesejada *= 2;
	for (int i = 1; i <= alturaDesejada; i += 2)
	{
		Console.Write(montarPreenchimento((alturaDesejada - i) / 2));
		for (int j = 1; j <= i * 2; j += 2)
		{
			Console.Write("#");
		}
		Console.WriteLine();
	}
}

string montarPreenchimento(int quantidade, char charDePreenchimento = ' ')
{
	string espacos = "";

	for (int i = 0; i < quantidade; i++)
	{
		espacos += charDePreenchimento;
	}

	return espacos;
}
