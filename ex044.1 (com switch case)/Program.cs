// Wallace's shop (com switch case)

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

double total = 0;
switch (pagamento){
    case 1:
        total = price * 0.90;
        Console.WriteLine($"Sua compra de R${price:F2} terá um desconto e ficará por R${total:F2}");
        break;
    case 2:
        total = price * 0.95;
        Console.WriteLine($"Sua compra de R${price:F2} terá um desconto e ficará por R${total:F2}");
        break;
    case 3:
        Console.WriteLine($"Sua compra terá duas parcelas de R${price / 2:F2} sem juros.");
        break;
    case 4:
        Console.Write("Quantas parcelas? ");
        int parcelas = int.Parse(Console.ReadLine());

        total = price * 1.20;

        Console.WriteLine($"Sua compra será parcela em {parcelas}x de R${total / parcelas:F2} COM JUROS!");
        break;
    default:
        Console.WriteLine("FORMA DE PAGAMENTO INVÁLIDA");  
        break;
}