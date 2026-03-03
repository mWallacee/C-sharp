// Maior e Menor valor

Console.Write("Primeiro valor: ");
int Number1 = int.Parse(Console.ReadLine());

Console.Write("Segundo valor: ");
int Number2 = int.Parse(Console.ReadLine());

Console.Write("Terceiro valor: ");
int Number3 = int.Parse(Console.ReadLine());

int MaiorValor = 0;
int MenorValor = 0;

if (Number1 != Number2 && Number3 != Number2 && Number1 != Number3)
{
    if (Number1 > Number2 && Number1 > Number3){
        MaiorValor = Number1;
    }
    else{
        MenorValor = Number1;
    }
    if (Number2 >  Number3 && Number2 > Number1){
        MaiorValor = Number2;
    }
    else{
        MenorValor = Number2;
    }
    if (Number3 > Number1 && Number3 > Number2){
        MaiorValor = Number3;
    }
    else{
        MenorValor = Number3;
    }
    Console.WriteLine($"Maior valor: {MaiorValor} \nMenor valor: {MenorValor}");
}
else
{
    Console.WriteLine("Todos os número são iguais");
}

