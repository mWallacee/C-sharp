// min and max

Console.Write("Primeiro número: ");
int Number1 = int.Parse(Console.ReadLine());

Console.Write("Segundo número: ");
int Number2 = int.Parse(Console.ReadLine());

if (Number1 > Number2) {
    Console.WriteLine("O PRIMEIRO número é maior!");
}
else if (Number2 > Number1){
    Console.WriteLine("O SEGUNDO número é maior!");
}
else {
    Console.WriteLine("Os dois valores são iguais!");
}
