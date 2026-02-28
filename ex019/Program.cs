// Escolher aluno para apagar o quadro

Console.Write("Primeiro Aluno: ");
string Name1 = Console.ReadLine();

Console.Write("Segundo Aluno: ");
string Name2 = Console.ReadLine();

Console.Write("Terceiro Aluno: ");
string Name3 = Console.ReadLine();

Console.Write("Quarto Aluno: ");
string Name4 = Console.ReadLine();

string[] Names = { Name1, Name2, Name3, Name4 };

Random random = new Random();
int RandomName = random.Next(Names.Length);

Console.WriteLine($"O aluno escolhido para limpar o quadro foi {Names[RandomName]}");
