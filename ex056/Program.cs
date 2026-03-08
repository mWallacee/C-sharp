// Analisador completo

int somaidades = 0;
string nomeDoMaisVelho = "";
int idadeDoMaisVelho = 0;
int mulheresMenosDe20 = 0;

for (int i = 1; i <= 4; i++)
{
    Console.WriteLine($"----{i}ª Pessoa----");

    Console.Write("Nome: ");
    string name = Console.ReadLine().Trim();

    Console.Write("Idade: ");
    int years = int.Parse(Console.ReadLine());

    Console.Write("Gênero [M/F]: ");
    string genero = Console.ReadLine().Trim().ToUpper();

    if (genero == "M" || genero == "F")
    {
        somaidades += years;

        if (years > idadeDoMaisVelho && genero == "M")
        {
            idadeDoMaisVelho = years;
            nomeDoMaisVelho = name;
        }

        if (genero == "F" && years < 20)
        {
            mulheresMenosDe20++;
        }
    }
    else
    {
        Console.WriteLine("Gênero Inválido");
        break;
    }
}

double mediaIdades = (double)somaidades / 4;

Console.WriteLine($"A média das idades foi {mediaIdades:F1}");
Console.WriteLine($"O homem mais velho é {nomeDoMaisVelho} ele tem {idadeDoMaisVelho} anos");
if (mulheresMenosDe20 != 0)
    Console.WriteLine($"{mulheresMenosDe20} Mulheres tem menos que 20 anos");
else
    Console.WriteLine("Não tem mulheres com menos de 20 anos.");