// Aumento de Salário

Console.Write("Qual é o salário atual? R$");
double Salario = double.Parse(Console.ReadLine());

double Aumento = 0;

if (Salario >= 1250.00){
    Aumento = Salario + (Salario * 0.10);
}
else if (Salario < 1250.00){
    Aumento = Salario + (Salario * 0.15);
}

Console.WriteLine($"O aumento de salário foi R${Aumento:F2}");
