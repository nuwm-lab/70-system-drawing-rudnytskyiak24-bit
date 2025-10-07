using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Графік функції: y = (2t + 8) / (|cos(3t)| + 1)");
        Console.WriteLine("t від 2 до 6.5 з кроком 0.8\n");

        double tStart = 2.0;
        double tEnd = 6.5;
        double deltaT = 0.8;

        Console.WriteLine("{0,10} | {1,15}", "t", "y");
        Console.WriteLine(new string('-', 30));

        for (double t = tStart; t <= tEnd + 0.001; t += deltaT)
        {
            double denominator = Math.Abs(Math.Cos(3 * t)) + 1;
            double y = (2 * t + 8) / denominator;

            Console.WriteLine("{0,10:F2} | {1,15:F6}", t, y);
        }

        Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
        Console.ReadKey();
    }
}

