// Conversor Dollar
Console.Write("Quanto quer converter: R$");
double Real = double.Parse(Console.ReadLine());

double Dollar = Real / 3.27;

Console.WriteLine($"Você pode converter R${Real} reais para ${Dollar:F2} dolares");
