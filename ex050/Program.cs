// Soma dos pares

int soma = 0;
int cont = 0;

for (int i = 1; i < 7; i++)
{
    Console.Write($"Digite o {i}° número: ");
    int number = int.Parse(Console.ReadLine());

    if ( number % 2 == 0)
    {
        soma += number;
        cont++;
    }
}
Console.WriteLine($"A soma de todos os {cont} números pares é {soma}");    