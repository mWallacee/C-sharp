// tabuada v2.0

Console.Write("digite um número para ver sua tabuada: ");
int Tab = int.Parse(Console.ReadLine());

for (int i = 1; i < 11; i++)
{
    Console.WriteLine($"{Tab} x {i} = {Tab*i}");
}
