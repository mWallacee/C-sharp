// Velocimetro

Console.Write("Velocidade do carro: Km/h ");
double SpeedCar = double.Parse(Console.ReadLine());

double Multa = 0;

if (SpeedCar > 80){
    Multa = (SpeedCar - 80) * 7;
    Console.WriteLine($"Você ultrapassou o limite de velocidade!!! \nUma multa de R${Multa:F2} será aplicada a você!!!");
}
else{
    Console.WriteLine("Está dentro do limite de velocidade! ");
}