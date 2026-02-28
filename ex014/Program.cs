// Conversor de Temperatura

Console.Write("Informe a temperatura em °C: ");
double Celsius = double.Parse(Console.ReadLine());

double Fahrenheit = (Celsius * 1.8) + 32;

Console.WriteLine($"a temperatura de {Celsius:F1}°C corresponde a {Fahrenheit:F1}°F");
