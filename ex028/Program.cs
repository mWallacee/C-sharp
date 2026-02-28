// Adivinhação 

Random random = new Random();
int Adivinhação = random.Next(0, 6);

Console.Write("O computador pensou em um número, \nTente adivinhar: ");
int Number = int.Parse(Console.ReadLine());

if (Adivinhação != Number){
    Console.WriteLine($"Você errou!!! \nO número era {Adivinhação}");
}
else{
    Console.WriteLine("Parabéns você acertou!!!");
}
