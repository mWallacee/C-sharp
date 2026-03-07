// Maior e Menor peso

double maiorPeso = 0;
double menorPeso = 0;

for (int i = 1; i <= 5; i++)
{
    Console.Write($"Peso da {i}ª pessoa: ");
    double peso = double.Parse(Console.ReadLine());
    if (i == 1)
    {
        maiorPeso = peso;
        menorPeso = peso;
    }
    else
    {
        if (peso > maiorPeso)
            maiorPeso = peso;
        if (peso < menorPeso)
            menorPeso = peso;
    }
}

Console.WriteLine($"Menor Peso: {menorPeso:F1}");
Console.WriteLine($"Maior Peso: {maiorPeso:F1}");