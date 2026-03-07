// Grupo de maior idade

int maiorDeIdade = 0;
int menorDeIdade = 0;

for (int i = 1; i <= 7; i++)
{
    Console.Write($"Em que ano a {i}° pessoa nasceu: ");
    int anoNascimento = int.Parse(Console.ReadLine());

    if (DateTime.Now.Year - anoNascimento >= 18)
        maiorDeIdade++;
    else
        menorDeIdade++;
}

Console.WriteLine($"maiores de idade: {maiorDeIdade}");
Console.WriteLine($"menores de idade: {menorDeIdade}");