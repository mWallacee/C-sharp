// Lista aleatória de alunos

Console.Write("Primeiro Aluno: ");
string Name1 = Console.ReadLine();

Console.Write("Segundo Aluno: ");
string Name2 = Console.ReadLine();

Console.Write("terceiro Aluno: ");
string Name3 = Console.ReadLine();

Console.Write("Quarto Aluno: ");
string Name4 = Console.ReadLine();

string[] Names = { Name1, Name2, Name3, Name4 };

Random.Shared.Shuffle(Names);

Console.WriteLine(Names);
