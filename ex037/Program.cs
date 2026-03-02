// Conversor de bases

Console.Write("Digite um inteiro: ");
int Number = int.Parse(Console.ReadLine());

Console.WriteLine("Escolha uma das bases para a conversão:");
Console.WriteLine("[ 1 ] binario \n[ 2 ] Octal \n[ 3 ] Hexadecimal");
Console.Write("Sua opção: ");
int Base = int.Parse(Console.ReadLine());

string NumberBi = Convert.ToString(Number, 2);
string NumberOc = Convert.ToString(Number, 8);
string NumberHex = Convert.ToString(Number, 16);

if (Base == 1){
    Console.WriteLine($"{Number} Convertido para Binário é {NumberBi}");
}
else if (Base == 2) {
    Console.WriteLine($"{Number} Convertido para Octal é {NumberOc}");
}
else if (Base == 3) {
    Console.WriteLine($"{Number} Convertido para Hexadecimal é {NumberHex}");
}

