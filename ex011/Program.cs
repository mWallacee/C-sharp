// Contador de Litros de tinta

Console.Write("Largura da parede: ");
double Width = double.Parse(Console.ReadLine());

Console.Write("Altura da parede: ");
double Height = double.Parse(Console.ReadLine());

double length = Width * Height;
double ink = length / 2;

Console.WriteLine($"Você precisa de {ink:F2} litros de tinta para pintar a parede.");
