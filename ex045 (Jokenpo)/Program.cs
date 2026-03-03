// Jokenpo v1.0

//await Task.Delay(1000);

//Thread.Sleep(5000);

Console.WriteLine("~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Jokenpo");
Console.ResetColor();
Console.WriteLine("~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=");

string[] itens = { "Pedra", "Papel", "Tesoura" };

Random random = new Random();
int PcJogada = random.Next(0, 3);

Console.WriteLine("\n-=Opções=-");
Console.WriteLine("[ 1 ] Pedra");
Console.WriteLine("[ 2 ] Papel");
Console.WriteLine("[ 3 ] Tesoura");

Console.Write("Qual será sua jogada? ");
int PlayerJogada = int.Parse(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.DarkBlue;
await Task.Delay(1000);
Console.WriteLine("\nJO");
await Task.Delay(1000);
Console.WriteLine("KEN");
await Task.Delay(1500);
Console.WriteLine("PO!!!");
Console.ResetColor();

Console.WriteLine("\n~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine($"Computador jogou: {itens[PcJogada]}");
Console.WriteLine($"Você jogou: {itens[PlayerJogada - 1]}");
Console.ResetColor();
Console.WriteLine("~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=\n");

switch (PcJogada)
{
    case 0: //pedra
        if (PlayerJogada == 1) //pedra
        {
            Console.WriteLine("EMPATE!!!");
        }
        else if (PlayerJogada == 2) //papel
        {
            Console.WriteLine("PARABÉNS VOCÊ VENCEU!!!");
        }
        else if (PlayerJogada == 3) //tesoura
        {
            Console.WriteLine("COMPUTADOR VENCEU!!!");
        }
        break;

    case 1: //papel
        if (PlayerJogada == 1) //pedra
        {
            Console.WriteLine("COMPUTADOR VENCEU!!!");
        }
        else if (PlayerJogada == 2) //papel
        {
            Console.WriteLine("EMPATE!!!");
        }
        else if (PlayerJogada == 3) //tesoura
        {
            Console.WriteLine("PARABÉNS VOCÊ VENCEU!!!");
        }
        break;

    case 2: //tesoura
        if (PlayerJogada == 1) //pedra
        {
            Console.WriteLine("PARABÉNS VOCÊ VENCEU!!!");
        }
        else if (PlayerJogada == 2) //papel
        {
            Console.WriteLine("COMPUTADOR VENCEU!!!");
        }
        else if (PlayerJogada == 3) //tesoura
        {
            Console.WriteLine("EMPATE!!!");
        }
        break;
}

