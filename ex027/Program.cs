// Primeiro e Último nome

Console.Write("Digite seu nome: ");
string Name = Console.ReadLine();

String FirstName = Name.Split(' ')[0];
String LastName = Name.Split(' ')[^1];

Console.WriteLine($"É um prazer te conhecer! \nSeu primeiro nome é: {FirstName} \nSeu último nome: {LastName}");
