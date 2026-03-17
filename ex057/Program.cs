// Validação de dados

string genero;

do
{
    Console.WriteLine("----Informe seu gênero---");
    Console.WriteLine("[ M ] Masculino \n[ F ] Feminino");
    Console.Write("Gênero: ");
    genero = Console.ReadLine().Trim().ToUpper();

    if (genero != "F" && genero != "M")
        Console.WriteLine("Gênero inválido! Tente novamente...\n");
} 
while (genero != "F" && genero != "M");