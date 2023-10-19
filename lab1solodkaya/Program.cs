Console.WriteLine("Введите x:");
int x=int.Parse(Console.ReadLine());
int y = (x - (x % 10)) / 10;
x = (x % 10) * 100;
Console.WriteLine($"{x+y}");

