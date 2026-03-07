// impares multiplos de 3

int totalNumbers = 0;
int soma = 0;

for (int i = 1; i < 501; i += 2)
{
    if (i % 3 == 0)
    {
        totalNumbers++;
        soma = soma + i;
    }  
}
Console.WriteLine($"O total de multiplos de 3 foi {totalNumbers} valores e o resultado da soma foi {soma}");
