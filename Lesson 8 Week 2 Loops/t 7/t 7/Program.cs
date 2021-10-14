using System;

namespace t_7
{
    class Program
    {
        static void Main(string[] args)
        {
        
            int a = 0, b = 0, c = 0;
            Console.WriteLine("number of sides");
            int d = int.Parse(Console.ReadLine());

            while (a < d)
            {
                for (b = 0; b < d - c; b++)
                {
                    Console.Write(' ');
                }
                for (b = 0; b <= a + c; b++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
                a++;
                c++;
            }
            a--;
            c--;
            while (a >= 0)
            {
                for (b = 0; b <= d - c; b++)
                {
                    Console.Write(' ');
                }
                for (b = 0; b < (a + c) - 1; b++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
                a--;
                c--;
            }
        }
    }
}
