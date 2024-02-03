using System;

class Program
{
    static void Main(string[] args)
    {
        double xMin = -1.0; 
        double xMax = 1.0; 
        double dx = 0.1; 
        double epsilon = 0.0001; 

        Console.WriteLine("x\tln((x+1)/(x-1))\tNumber of terms");
        Console.WriteLine("-------------------------------------");

        for (double x = xMin; x <= xMax; x += dx)
        {
            double sum = 0.0; 
            double term = 1.0; 
            int n = 0; 

            while (Math.Abs(term) >= epsilon)
            {
                sum += term;
                n++;

                term = 1.0 / ((2 * n + 1) * Math.Pow(x, 2 * n + 1));
            }

            double result = 2 * sum; // результат

            Console.WriteLine($"{x}\t{result}\t\t{n}");
        }
    }
}
