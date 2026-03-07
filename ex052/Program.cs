// Números primos

Console.Write("Digite um número: ");
int num = int.Parse(Console.ReadLine());

int numDivisores = 0; 

for (int i = 1; i <= num; i++)
{
    if (num % i == 0)
    {
        numDivisores++;
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
    }

    Console.Write($"{i} ");
    Console.ResetColor();
}

Console.Write($"\nEsse número tem {numDivisores} divisores ");

if (numDivisores > 2)
    Console.WriteLine("Por isso ele não é primo!");
else
    Console.WriteLine("Por isso ele é primo!");

