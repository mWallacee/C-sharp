// Classificando Atletas

Console.Write("Ano de nascimento: ");
int AnoNasc = int.Parse(Console.ReadLine());

int Idade = DateTime.Now.Year - AnoNasc;
string Categoria = "";

if (Idade <= 9)
    Categoria = "Mirim";

else if (Idade <= 14)
    Categoria = "Infantil";

else if (Idade <= 19)
    Categoria = "Júnior";

else if (Idade <= 25)
    Categoria = "Sênior";

else
    Categoria = "Master";

Console.WriteLine($"o atleta tem {Idade} ano(s) e está na categoria {Categoria}");