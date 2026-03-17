// Jogo da adivinhação V2.0

int tentativa;
int tentativas = 0;

Console.WriteLine("O computador vai pensar em um número de 0 a 10");

Random random = new Random();
int pcNumber = random.Next(0, 11);

do
{ 
    Console.Write("Tentativa: ");
    tentativa = int.Parse(Console.ReadLine());
    tentativas++;

    if (pcNumber > tentativa)
        Console.WriteLine("Mais... Tente novamente");
    if (pcNumber < tentativa)
        Console.WriteLine("Menos... Tente novamente");
}
while (tentativa != pcNumber);

if (tentativas > 1)
    Console.WriteLine($"Parabéns você acertou!!! Precisou de {tentativas} tentativas");
else
    Console.WriteLine("Parabéns você acertou de primeira!!!");