// Seno, Cosseno e tangente 

Console.Write("Digite o ângulo: ");
double Angle = double.Parse(Console.ReadLine());

double radius = Math.PI * Angle / 180;

Console.WriteLine($"O seno desse ângulo é {Math.Sin(radius):F2} \no cosseno é {Math.Cos(radius):F2}  \nE a tangente é {Math.Tan(radius):F2}") ;
