// Par ou Ímpar

Console.Write("Digite um número: ");
int Number = int.Parse(Console.ReadLine());

if (Number % 2 == 0){
    Console.WriteLine("Seu número é PAR!!!");
}
else{
    Console.WriteLine("Seu número é ÍMPAR!!!");
}