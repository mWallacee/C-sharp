//

Console.Write("por quantos dias foi alugado: ");
int days = int.Parse(Console.ReadLine());  

Console.Write("Quantos Kms percorridos: ");
double Kms = double.Parse(Console.ReadLine());

double Aluguel = (60 * days) + (Kms * 0.15);

Console.WriteLine($"O total a pagar é R${Aluguel:F2}");
