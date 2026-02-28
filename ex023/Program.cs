// Analisando números

Console.Write("Informe um número: ");
int Number = int.Parse(Console.ReadLine());


int Milhares = (Number / 1000) % 10;
int Centenas = Number / 100 % 10;
int Dezenas = Number / 10 % 10;
int Unidades = Number / 1 % 10;

Console.WriteLine($"\nMilhares: {Milhares}");
Console.WriteLine($"Centenas : {Centenas}");
Console.WriteLine($"Dezenas: {Dezenas}");
Console.WriteLine($"Unidades: {Unidades}");