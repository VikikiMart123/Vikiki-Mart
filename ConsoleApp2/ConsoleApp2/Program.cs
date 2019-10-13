using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, x1, x2, x3, x4 , x5, x6, x7; //здесь объявляются переменные
            x = 8; // здесь переменной х присваивается значение 8
            y = 16; // здесь переменной y присваивается значение 16
            z = 1; // здесь переменной х присваивается значение 1
            x1 = (x + y) * Math.Pow(z, z++); //x=8 , y=16, z=2, x1=24
            x2 = x / z; // x2=3
            x3 = x2-- * Math.Sqrt(y);//x3=16
            x4 = x + y; //x4 = 24
            x5 = y + z; //x5 = 18
            x6 = x4 * x5; //x6 = 432
            x7 = x6 / Math.Pow(z, 3); //x7 = 54

            Console.WriteLine($"x={x}"); 
            Console.WriteLine($"y={y}");
            Console.WriteLine($"z={z}");
            Console.WriteLine($"First expression result: {x1}");
            Console.WriteLine($"Second expression result: {x3}");
            Console.WriteLine($"Third expression result: {x7}");
            Console.ReadKey();
        }
    }
}
