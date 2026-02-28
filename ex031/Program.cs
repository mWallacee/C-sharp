// Agência de viagens

Console.Write("Quantos Kms até o destino: ");
int kms = int.Parse(Console.ReadLine());

double Passagem = 0;

if (kms > 200){
    Passagem = kms * 0.45;
}
else if (kms < 200){
    Passagem = kms * 0.5;
}
Console.WriteLine($"O valor da passagem ficou no valor de R${Passagem:F2}");