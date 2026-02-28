// Conversor de distância

Console.Write("Digite uma distãncia em metros: ");
double number = double.Parse(Console.ReadLine());

Console.WriteLine($"Essa medida corresponde a: \n{number / 1000}km \n{number / 100}hm \n{number / 10}dam \n{number * 10}dm \n{number * 100}cm \n{number * 1000}mm");
 