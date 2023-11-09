double x = 2;
double step = 0.2;
double end = 4.1;

Console.WriteLine("x\t| y");

while (x <= end)
{
    double y = Math.Abs(Math.Log10(x)) - Math.Pow((x - 2), 2);
    Console.WriteLine($"{x}\t| {y}");

    x += step;
}