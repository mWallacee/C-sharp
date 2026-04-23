//Vários valores

int number = 0;
int contador = 0;
int soma = 0;

while (number != 999)
{
    Console.Write("Digite um número [999 para parar]: ");
    number = int.Parse(Console.ReadLine());

    if (number != 999){
    contador++;
    soma += number;
    }
}

Console.WriteLine($"Foram digitados {contador} valores \nA soma deles é: {soma}");