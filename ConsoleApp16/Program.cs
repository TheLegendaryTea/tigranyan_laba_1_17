using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите x:");
                double x = double.Parse(Console.ReadLine());
                double y = 0;
                if (x != 0) y = 1 / (x * x);
                Console.WriteLine($"x={x} y={y:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}