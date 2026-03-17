// fatorial com for

Console.Write("Digite um número para calcular seu fatorial: ");
int fator = int.Parse(Console.ReadLine());

int fatorial = 1;

Console.Write($"{fator}! = ");

for (int i = fator; i >= 1; i--)
{
    Console.Write(i);
    if (i > 1)
        Console.Write(" x ");
    fatorial *= i;
}
Console.WriteLine($" = {fatorial}");