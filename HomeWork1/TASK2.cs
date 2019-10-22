using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d; //здесь объявляются переменные, а- ширина ПП, b- высота и с - длина
            a = 2; //здесь ширине а присваивается значение 2 
            b = 3; //здесь высоте b присваивается значение 3
            c = 4; // здесь длине c присваивается значение 4
            d = Math.Sqrt(a * a + b * b + c * c); //здесь вычисляется формула длина диагонали ПП
            Console.WriteLine($"a={a}");
            Console.WriteLine($"b={b}");
            Console.WriteLine($"c={c}");
            Console.WriteLine($"Parallelepiped diagonal length: {d}");
            Console.ReadKey();
        }
    }

}
