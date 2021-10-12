using System;

Console.WriteLine($"{uint.MaxValue:n0}");
Console.Write("Digite até que posição você deseja que seja impressa a sequência de fibonacci: ");
int posicaoDesejada = int.Parse(Console.ReadLine());
uint x = 0;
uint y = 1;

if (posicaoDesejada is >= 1)
{
	Console.Write("1) ");
	Console.Write("0");
}

if (posicaoDesejada is >= 2)
{
	Console.WriteLine(",");
	Console.Write("2) ");
	Console.Write("1");
}

for (int i = 3; i <= posicaoDesejada; i++)
{
	uint soma = x + y;
	x = y;
	y = soma;

	Console.WriteLine($",");
	Console.Write($"{i}) ");
	Console.Write($"{soma:n0}");
}
