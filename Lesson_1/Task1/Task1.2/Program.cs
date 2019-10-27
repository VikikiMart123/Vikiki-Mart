using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d; //здесь объявляются переменные, а- ширина ПП, b- высота и с - длина
            Console.WriteLine("Enter the width of the paralelepid: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of the paralelepipid: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of the paralelepid: ");
            c = Convert.ToInt32(Console.ReadLine());
            d = Math.Sqrt(a * a + b * b + c * c); //здесь вычисляется формула длина диагонали ПП
            Console.WriteLine($"Parallelepiped diagonal length: {d}");
            Console.ReadKey();
        }
    }

}
