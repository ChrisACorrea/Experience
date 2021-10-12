using System;

imprimirCabeçalho();

decimal[] valoresDisponiveis = { 100m, 50m, 20m, 10m, 5m, 2m, 1m, 0.5m, 0.25m, 0.10m, 0.05m, 0.01m };

decimal valorTotal = 0;
decimal valorPago = 0;

bool entradaValida = false;

do
{
	try
	{
		Console.Write("Digite o valor total da compra: ");
		valorTotal = decimal.Parse(Console.ReadLine().Replace('.', ','));
		Console.Write("Digite o valor pago: ");
		valorPago = decimal.Parse(Console.ReadLine().Replace('.', ','));

		if(valorTotal < 0 || valorPago < 0)
		{
			throw new ArgumentException();
		}

		entradaValida = true;
	}
	catch (FormatException)
	{
		Console.WriteLine("O valor inserido não pode ser vazio.");
	}
	catch (OverflowException)
	{
		Console.WriteLine("Ops!!! Esse é um valor muito alto. Tente com um menor.");
	}
	catch (ArgumentException)
	{
		Console.WriteLine("Os valores não podem ser negativos.");
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

} while (!entradaValida);

Console.Clear();
imprimirCabeçalho();

decimal troco = valorPago - valorTotal;
bool trocoCalculado = false;

int i = 0;
int quantidadeNotas = 0;
decimal trocoTemp = troco;

Console.WriteLine($"Valor total: {valorTotal:c}");
Console.WriteLine($"Valor pago: {valorPago:c}");
Console.WriteLine($"Troco: {troco:c}");
Console.WriteLine("--------------------");

while (!trocoCalculado)
{
	if (valoresDisponiveis[i] <= trocoTemp)
	{
		quantidadeNotas++;
		trocoTemp -= valoresDisponiveis[i];
	}
	else
	{
		if (quantidadeNotas is > 0)
		{
			Console.WriteLine($"- {quantidadeNotas} de {valoresDisponiveis[i]:c}");
		}

		quantidadeNotas = 0;
		i++;

		if (trocoTemp is 0)
		{
			trocoCalculado = true;
		}
	}


}


void imprimirCabeçalho()
{
	Console.WriteLine("###################");
	Console.WriteLine("# Desafio - Troco #");
	Console.WriteLine("###################");
	Console.WriteLine();
}