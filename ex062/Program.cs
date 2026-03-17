// Progressão Aritimética v3.0

int contador = 0;

Console.WriteLine("======== Progressão Aritimética ========");

Console.Write("Digite o primeiro termo: ");
int termo = int.Parse(Console.ReadLine());

Console.Write("Informe a razão: ");
int razao = int.Parse(Console.ReadLine());

Console.WriteLine();

while (contador < 10)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write($"{termo} ");
    termo = termo + razao;
    contador++;
    Console.ResetColor();
}
Console.WriteLine();
