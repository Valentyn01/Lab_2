using System;

namespace lab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double y, x = 0, b = Math.PI, dx = Math.PI / 20;
            Console.WriteLine("  X\t\t Y");
            while (x <= b)
            {
                if (x < Math.PI / 20)
                {
                    Console.WriteLine("|" + Math.Round(x, 2));
                }
                else
                {
                    y = (Math.Pow(x, 1 / 4) * Math.Tan(x) + 13);
                    Console.WriteLine("|" + Math.Round(x, 2) + "\t\t" + Math.Round(y, 2));

                }
                x += dx;
            }
        }
    }
}