//Maior e menor Val

int number = 0;
int quantidade = 0;
int soma = 0;
int maior = 0;
int menor = 0;

bool parar = false;

while (parar == false)
{
    Console.Write("Digite um número: ");
    number = int.Parse(Console.ReadLine());

    if (quantidade == 0)
    {
        maior = number;
        menor = number;
    }
    else
    {
        if (number > maior)
            maior = number;
        if (number < menor)
            menor = number;
    }
    quantidade++;
    soma += number;

    Console.Write("Quer continuar? [S/N]: ");
    String resposta = Console.ReadLine().ToUpper().Trim();

    Console.WriteLine();

    if (resposta == "N")
        break;
}

double media = (double)soma / (double)quantidade;

Console.WriteLine($"Você digitou {quantidade} valores e a média deles é {media:F2}");
Console.WriteLine($"O Maior número foi {maior} e o Menor foi {menor}");