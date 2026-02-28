// Quantas letras "A"?

Console.Write("Digite uma frase: ");
string line = Console.ReadLine().Trim().ToLower();

string Line = line.Split(' ')[0];

int quantidade = Line.Count('a');
int First = Line.IndexOf('a')+1;
int Last = Line.LastIndexOf('a')+1;

Console.WriteLine(quantidade);
Console.WriteLine(First);
Console.WriteLine(Last);

