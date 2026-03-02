// Wallaces's Shop

Console.WriteLine("============ Wallace's Shop ============");

Console.Write("Preço das compras: R$");
double price = double.Parse(Console.ReadLine());

Console.WriteLine("\n-=FORMAS DE PAGAMENTO=-");
Console.WriteLine("[ 1 ] à vista (dinheiro/pix)");
Console.WriteLine("[ 2 ] à vista no cartão ");
Console.WriteLine("[ 3 ] 2x no cartão ");
Console.WriteLine("[ 4 ] 3x ou mais no cartão ");

Console.Write("Sua opção: ");
int pagamento = int.Parse(Console.ReadLine());

if (pagamento == 1){
    Console.WriteLine($"Sua compra de R${price:F2} terá um desconto e ficará por R${price - (price * 0.10):F2}");
}
else if (pagamento == 2){
    Console.WriteLine($"Sua compra de R${price:F2} terá um desconto e ficará por R${price - (price * 0.05)}");
}
else if (pagamento == 3){
    Console.WriteLine($"Sua compra terá duas parcelas de R${price / 2:F2} sem juros.");
}
else if (pagamento == 4){
    Console.Write("Quantas parcelas: ");
    int parcelas = int.Parse(Console.ReadLine());

    double juros = price * 0.20;

    Console.WriteLine($"Sua compra será parcela em {parcelas}x de R${(price + juros) / parcelas:f2} COM JUROS!");
}
else {
    Console.WriteLine("FORMA DE PAGAMENTO INVÁLIDA");
}