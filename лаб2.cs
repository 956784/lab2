Console.WriteLine("Введите 2 числа");
double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());
double z = (x + y) / 2;
double w = 2 * (x * y);
if (x > y)
{
    x = w;
    y = z;
    Console.WriteLine($"x = {x} y = {y}");
}
else if (y > x)
{
    y = w;
    x = z;
    Console.WriteLine($"x = {x} y = {y}");
}
else
{
    Console.WriteLine("Ошибка");
}