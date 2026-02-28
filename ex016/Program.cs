// 
Console.Write("Digite um número em decimal: ");
double number = double.Parse(Console.ReadLine());

Console.WriteLine($"{Math.Truncate(number)}");