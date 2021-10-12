using System;

char[,] mapa = new char[20, 40]
{
	{'C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C'},
	{'C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C'},
	{'C','C','C','N','N','N','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','N','N','C','C','C','C','C','C','C','C','C','C','C','C'},
	{'C','C','N','N','N','N','N','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','N','N','N','N','C','C','C','C','C','C','C','C','C','C','C'},
	{'C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','N','N','N','N','N','N','C','C','N','N','C','C','C','C','C','C'},
	{'C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','N','N','N','N','C','C','C','C','C'},
	{'C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C'},
	{'C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C'},
	{'C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C'},
	{'C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C'},
	{'C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C'},
	{'C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','M','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C'},
	{'C','C','C','C','C','C','C','C','C','C','C','C','C','C','M','M','M','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C'},
	{'C','C','C','C','C','C','C','C','C','C','C','C','C','M','M','M','M','M','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C'},
	{'C','C','C','C','C','C','C','C','C','C','C','C','M','M','M','M','M','M','M','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C'},
	{'C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C','C'},
	{'G','G','G','G','G','G','G','G','G','G','G','G','G','G','G','G','G','G','G','G','G','G','G','G','G','G','G','G','G','G','G','G','G','G','G','G','G','G','G','G'},
	{'T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T'},
	{'T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T'},
	{'T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T'}
};

Console.WriteLine("#########################");
Console.WriteLine("# Desafio Mapa do Mário #");
Console.WriteLine("#########################");
Console.WriteLine();

desenharMapa(mapa);

Console.WriteLine();
Console.WriteLine("Legenda:");
Console.WriteLine($"C: 🟦");
Console.WriteLine($"T: 🟫");
Console.WriteLine($"G: 🟩");
Console.WriteLine($"N: ⚪");
Console.WriteLine($"M: 🟡");

Console.WriteLine();
Console.WriteLine("Pressione qualquer tecla para encerrar");
Console.ReadKey();

void desenharMapa(char[,] mapa)
{
	Console.OutputEncoding = System.Text.Encoding.Unicode;
	for (int i = 0; i < mapa.GetLength(0); i++)
	{
		for (int j = 0; j < mapa.GetLength(1); j++)
		{
			char bit = mapa[i, j];

			switch (bit)
			{
				case 'C':
					Console.Write("🟦");
					break;
				case 'T':
					Console.Write("🟫");
					break;
				case 'G':
					Console.Write("🟩");
					break;
				case 'N':
					Console.Write("⚪");
					break;
				case 'M':
					Console.Write("🟡");
					break;
				default:
					Console.Write("⬛");
					break;
			}
		}
		Console.WriteLine();
	}
}