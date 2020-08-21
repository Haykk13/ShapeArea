using System;

namespace ShapeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer to know its shape area number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"The shape area number of {n} is {shapeArea(n)}!");
            Console.ReadLine();
        }
        static int shapeArea(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return shapeArea(n - 1) + (2 * n) + 2 * (n - 2);
            }
        }

    }
}
