// Contagem Regressiva

for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
    await Task.Delay(1000);
}
Console.WriteLine("🎉");
