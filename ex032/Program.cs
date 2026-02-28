// Analise de Ano

Console.Write("Digite um ano para analisar (0 = Ano atual): ");
int AnoEscolhido = int.Parse(Console.ReadLine());

String Ano = "";

if (AnoEscolhido == 0) {
    AnoEscolhido = DateTime.Now.Year;
}
if ((AnoEscolhido  % 4 == 0 && AnoEscolhido % 100 != 0) || AnoEscolhido % 400 == 0){
    Ano = "É bissexto!!!";
}
else{
    Ano = "Não é bissexto!!! ";
}
Console.Write($"O ano {AnoEscolhido} {Ano}");
