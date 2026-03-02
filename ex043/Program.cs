// Índice de Massa Corporal (IMC)

Console.Write("Qual seu peso (Kg): ");
double peso = double.Parse(Console.ReadLine());

Console.Write("Qual sua altura: ");
double altura = double.Parse(Console.ReadLine());

double imc = peso / Math.Pow(altura, 2);
string classificação = "";

Console.WriteLine($"O IMC dessa pessoa é {imc:F1}");

if (imc < 18.5)
    classificação = "Abaixo do peso";
else if (imc <= 25)
    classificação = "Peso ideal";
else if (imc <= 30)
    classificação = "Sobrepeso";
else if (imc <= 40)
    classificação = "Obesidade";
else
    classificação = "Obesidade mórbida";

Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
Console.WriteLine($"Quadro do paciente: {classificação} ");
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
