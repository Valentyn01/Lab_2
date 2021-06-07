using System;

namespace Lab_2._1
{
    public class Program
    {
        public static void Main()
        {
            int a;
            Console.WriteLine("Введiть  номер місяця :");
            a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Січень");
                    break;
                case 2:
                    Console.WriteLine("Лютий");
                    break;
                case 3:
                    Console.WriteLine("Березень");
                    break;
                case 4:
                    Console.WriteLine("Квітень");
                    break;
                case 5:
                    Console.WriteLine("Травень");
                    break;
                case 6:
                    Console.WriteLine("Червень");
                    break;
                case 7:
                    Console.WriteLine("Липень");
                    break;
                case 8:
                    Console.WriteLine("Серпень");
                    break;
                case 9:
                    Console.WriteLine("Вересень");
                    break;
                case 10:
                    Console.WriteLine("Жовтень");
                    break;
                case 11:
                    Console.WriteLine("Листопад");
                    break;
                case 12:
                    Console.WriteLine("Грудень");
                    break;
                default: Console.WriteLine("Такого місяця  немає\n"); break;

            }
        }

    }
}