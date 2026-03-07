// Detector de palindromos

Console.Write("Digite um palindromo: ");
string frase = Console.ReadLine().Trim().ToLower().Replace(" ", "");

string fraseInvertida = "";

for (int i = frase.Length - 1; i >= 0; i--)
{
    fraseInvertida += frase[i];
}

if (frase == fraseInvertida)
    Console.WriteLine("É um palindromo");
else
    Console.WriteLine("Não é um palindromo");
