// Aprovando emprestimo

Console.Write("Informe seu salário R$");
double salary = double.Parse(Console.ReadLine());

Console.Write("Qual o valor da casa? R$");
double house = double.Parse(Console.ReadLine());

Console.Write("Em quantos anos irá pagar? ");
int years = int.Parse(Console.ReadLine());

string Validação = "";
double Prestação = house / (years * 12);

if (Prestação <= salary  * 0.30){
     Validação = "Aprovado!!!";
}
else if (Prestação >=  salary * 0.30){
     Validação = "Recusado!!! As parcelas não podem exceder 30% de seu salário.";
}

Console.WriteLine($"As parcelas ficaram no valor de R${Prestação:F2}");
Console.WriteLine($"Seu emprestimo foi {Validação}");