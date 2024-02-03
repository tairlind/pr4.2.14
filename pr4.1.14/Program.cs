using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите начальное значение a:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите конечное значение b:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите шаг h:");
        double h = double.Parse(Console.ReadLine());

        Console.WriteLine("\nx\tF(x)");
        Console.WriteLine("-------------------");

        for (double x = a; x <= b; x += h)
        {
            double f = CalculateF(x);
            Console.WriteLine($"{x}\t{f}");
        }

        Console.ReadLine();
    }

    static double CalculateF(double x)
    {
        double cosSquared = Math.Pow(Math.Cos(x), 2);
        if (cosSquared == 0)
        {
            throw new DivideByZeroException("Ошибка: деление на ноль");
        }
        double result = x / cosSquared;
        return result;
    }
}
