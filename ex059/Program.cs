// Menu de Opções

int number1;
int number2;
int opcao = 0;

Console.Write("Primeiro valor: ");
number1 = int.Parse(Console.ReadLine());

Console.Write("Segundo valor: ");
number2 = int.Parse(Console.ReadLine());

do
{
    Console.Write("""
    ======== Menu ========

    [ 1 ] Somar
    [ 2 ] Multiplicar
    [ 3 ] Maior
    [ 4 ] Novos números
    [ 5 ] Sair do programa

    Sua opção: 
    """);

    opcao = int.Parse(Console.ReadLine());

    switch (opcao){
        case 1:
            int soma = number1 + number2;
            Console.WriteLine($"\nA soma de {number1} e {number2} é {soma}\n");

            break;
        case 2:
            int multiplicacao = number1 * number2;
            Console.WriteLine($"\nMultiplicando {number1} por {number2} da {multiplicacao}\n");

            break;
        case 3:
            int maior = number1;
            if (number2 > number1)
                maior = number2;
            Console.WriteLine($"\nO maior número é {maior}\n");

            break;
        case 4:
            Console.Write("\nPrimeiro valor: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            number2 = int.Parse(Console.ReadLine());

            break;
        default:
            if (opcao != 5)
                Console.WriteLine("\nDigite uma opção válida\n");
            break;
    }
}
while (opcao != 5);


