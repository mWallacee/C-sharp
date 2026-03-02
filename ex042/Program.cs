// Analisando triângulos v2.0

Console.Write("Primeiro segmento: ");
double Reta1 = double.Parse(Console.ReadLine());

Console.Write("Segundo Segmento: ");
double Reta2 = double.Parse(Console.ReadLine());

Console.Write("Terceiro segmento: ");
double Reta3 = double.Parse(Console.ReadLine());

string TypeTriangulo = "";

if (Reta3 < Reta1 + Reta2 &&
    Reta2 < Reta3 + Reta1 &&
    Reta1 < Reta2 + Reta3)
{   // Sempre usar {} no if se só tiver uma linha pode não usar

    if (Reta1 == Reta2 && Reta2 == Reta3 )
        TypeTriangulo = "Equilátero";
    else if (Reta1 == Reta2 || Reta2 == Reta3 || Reta1 == Reta3)
        TypeTriangulo = "Isóceles";
    else
        TypeTriangulo = "Escaleno";

    Console.WriteLine($"Os Segmentos PODEM formar um triângulo {TypeTriangulo}");
}
else
{
    Console.WriteLine($"Os Segmentos NÃO PODEM formar um triângulo.");
}