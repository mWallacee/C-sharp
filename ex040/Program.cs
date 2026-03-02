// Média  
Console.Write("Primeira nota: ");
double Nota1 = double.Parse(Console.ReadLine());

Console.Write("Segunda nota: ");
double nota2 = double.Parse(Console.ReadLine());

double media = (Nota1 + nota2) / 2;

if (media >= 7.0)
{
    Console.WriteLine($"Aluno ficou com {media:F1} de média e está APROVADO!!!");
}
else if (media >= 5.0)
{
    Console.WriteLine($"Aluno ficou com {media:F1} de média e está de RECUPERAÇÃO.");
}
else
{
    Console.WriteLine($"Aluno ficou com {media:F1} de média e está REPROVADO!!!");
}
