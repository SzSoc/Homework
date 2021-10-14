using System;

namespace T_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10");
            int f, s, multi;
            Console.WriteLine("Give 2 numbers");
            Console.WriteLine("First number");
            f = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number");
            s = Convert.ToInt32(Console.ReadLine());

            while (f != s)
            {
                if (f > s)
                {
                    f -= s;
                }

                else
                {
                    s -= f;
                }
            }

            multi = f * s / f;
            Console.WriteLine($"Wielokrotność ={multi}");
        Console.ReadKey();
        }
    }
}
