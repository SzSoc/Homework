using System;

namespace T_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 6");
            double a = 0, b;
            for (double i = 1; i <= 20; i++)
            {
                a = (1 / i) + a;

                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
