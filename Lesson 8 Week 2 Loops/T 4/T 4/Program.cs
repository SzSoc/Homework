using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task 4");

            Console.WriteLine("Give me a number");
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= a; j++)
                {

                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(a);
                }
                Console.WriteLine("");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
