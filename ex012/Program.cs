// Preço novo/New price

Console.Write("Preço do antigo do produto: R$");
double OldPrice = double.Parse(Console.ReadLine());

Double NewPrice = OldPrice - (OldPrice * 0.05);

Console.WriteLine($"O novo preço do produto é R${NewPrice:F2}");
