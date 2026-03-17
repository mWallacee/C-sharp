//  fatorial com while

Console.Write("Digite um número para calcular seu fatorial: ");
int fator = int.Parse(Console.ReadLine());

int fatorial = 1;
int contador = fator;

Console.Write($"{fator}! = ");

while (contador > 0)
{
    Console.Write(contador);
    if (contador > 1)
        Console.Write(" x ");

    fatorial *= contador;
    contador--;
}

Console.Write($" = {fatorial}");