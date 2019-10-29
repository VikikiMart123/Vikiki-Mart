using System;

// Сцепление строк. (Конкатенация)

namespace Concatenation
{
    class Program
    {
        static void Main()
        {

            string ph1 = "po";
            string ph2 = "be";
            string ph3 = "da";

            Console.WriteLine($"String {ph1.ToUpper()} starts from {ph2.ToUpper()}: {ph1.StartsWith("be")}");
            Console.WriteLine($"String {ph1.ToUpper()} ends to {ph3.ToUpper()}: {ph1.StartsWith("da")}");

            // Delay.
            Console.ReadKey();
        }
    }
}
