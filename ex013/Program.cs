// New Salary

Console.Write("Digite o salário antigo do funcionário: R$");
double OldSalary = double.Parse(Console.ReadLine());

double NewSalary = OldSalary + (OldSalary * 0.15);

Console.WriteLine($"O novo salário desse funcionário é R${NewSalary:F2}");
