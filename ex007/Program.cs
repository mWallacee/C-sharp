//Média escolar

Console.Write("Digite a primeira nota do aluno: ");
double nota1 = double.Parse(Console.ReadLine());

Console.Write("Digite a segunda nota do aluno: ");
double nota2 = double.Parse(Console.ReadLine());

//Usar , porque é o padrão brasileiro
Console.WriteLine($"A média do aluno foi: {(nota1 + nota2) / 2:F1}");
