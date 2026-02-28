// A soma dos quadrados dos catetos(cathetus)

Console.Write("Comprimento do primeiro cateto: ");
double LegOpposite = double.Parse(Console.ReadLine());

Console.Write("Comprimento do segundo cateto: ");
double LegAdjacent = double.Parse(Console.ReadLine());

double Hypotenuse = Math.Sqrt( (Math.Pow(LegOpposite, 2) + (Math.Pow(LegAdjacent, 2))) );

Console.WriteLine($"A hipotenusa vai medir {Hypotenuse:F2}");
