// progressão aritimética

Console.Write("Primeiro termo: ");
int termo = int.Parse(Console.ReadLine());

Console.Write("Razão: ");
int razao = int.Parse(Console.ReadLine());

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(termo + i * razao);
}
