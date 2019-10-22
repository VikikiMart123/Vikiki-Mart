using System;


namespace Task4
{
    class Program
    {
        static void Main()
        {

            string s1 = "hello";
            string s2 = "world";
            string s3 = s1 + " " + s2; // результат: строка "hello world"
            string s4 = String.Concat(s3, "!!!"); // результат: строка "hello world!!!"

            Console.WriteLine(s4);

            // Delay.
            Console.ReadKey();
        }
    }
}
