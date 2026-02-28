// Vereficador de strings

Console.Write("Digite seu nome completo: ");
string FullName = Console.ReadLine();

String[] Names = FullName.Split(' '); //Retorna um Array 
string FirstName = Names[0];
string LastName = Names[^1];

int LetrasName = FullName.Length;
int LetrasFirstName = FirstName.Length; ;

Console.WriteLine($"Seu primeiro nome é: {FirstName} e tem {LetrasFirstName} letras");
Console.WriteLine($"Seu último nome é: {LastName}");
Console.WriteLine($"Seu nome tem {LetrasName} letras");

Console.WriteLine($"Seu nome em maiúsculo: {FullName.ToUpper()}");
Console.WriteLine($"Seu nome em minúsculo: {FullName.ToLower()}");
