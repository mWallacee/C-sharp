Console.Write("Digite um número: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"O dobro do seu número é {number * 2}, seu triplo é {number * 3} e sua raíz é {Math.Sqrt(number):F2}");
