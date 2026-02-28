// Formar Triângulos 

Console.Write("Primeira reta: ");
double reta1 = double.Parse(Console.ReadLine());

Console.Write("Segunda reta: ");
double reta2 = double.Parse(Console.ReadLine());

Console.Write("Terceira reta: ");
double reta3 = double.Parse(Console.ReadLine());

if (reta3 < (reta1 + reta2) && reta1 < (reta2 + reta3) && reta2 < (reta1 + reta3))
{
    Console.WriteLine("Essas retas podem formar um triângulo!!!");
}
else
{
    Console.WriteLine("Essas retas não podem formar um triângulo!!!");
}
