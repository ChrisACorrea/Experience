using System;

Console.Write("Escolha a altura da pirâmide: ");
int altura = int.Parse(Console.ReadLine());
Console.WriteLine();

imprimePiramides(altura);

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
