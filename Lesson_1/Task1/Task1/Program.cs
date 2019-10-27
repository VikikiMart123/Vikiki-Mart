using System;
using System.Threading.Tasks;

namespace Task1
{
    internal class program
    {
        static void Main(string[] args)
        {
            double x, y, z, x1, x2, x3, x4, x5, x6, x7; //здесь объявляются переменные
        Console.WriteLine("Enter the firt num: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the seconds num: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the thirth num: ");
        z = Convert.ToInt32(Console.ReadLine());

        x1 = (x + y) * Math.Pow(z, z++); 
            x2 = x / z; 
            x3 = x2-- * Math.Sqrt(y);
            x4 = x + y; 
            x5 = y + z; 
            x6 = x4 * x5; 
            x7 = x6 / Math.Pow(z, 3); 
            Console.WriteLine($"First expression result: {x1}");
            Console.WriteLine($"Second expression result: {x3}");
            Console.WriteLine($"Third expression result: {x7}");
            Console.ReadKey();
        }
    }
}
