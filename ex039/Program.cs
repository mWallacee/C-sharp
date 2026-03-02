// Alistamento Militar

Console.Write("Seu ano de nascimento: ");
int BornYear = int.Parse(Console.ReadLine());

int AnoAtual = DateTime.Now.Year;
int AnoAlistamento = BornYear + 18;
int Idade = AnoAtual - BornYear;

Console.WriteLine($"Quem nasceu em {BornYear} tem {Idade} anos em {AnoAtual}.");

if (Idade == 18 )
{
    Console.WriteLine($"Você deve se alistar IMEDIATAMENTE!");
}
else if (Idade < 18)
{
    Console.WriteLine($"Ainda faltam {18 - Idade} ano(s) para você se alistar. \nSeu alistamento será em {AnoAlistamento}");
}
else
{
    Console.WriteLine($"Já deveria ter se alistado a {AnoAtual - AnoAlistamento} ano(s) \nSeu alistamento foi em {AnoAlistamento}");
}
