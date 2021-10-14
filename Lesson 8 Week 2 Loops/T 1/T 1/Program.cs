using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1\n");
            int a = 0;
            bool div;
            for (int i = 2; i <= 100; i++)
            {

                div = false;
                for (int j = i / 2; j > 1; j--)
                {

                    if (i % j == 0)
                    {
                        div = true;
                        break;
                    }
                }
                if (!div)
                {
                    a++;

                }
            }
            Console.WriteLine($"Total result: {a} Prime numbers");
            Console.ReadKey();
        }
    }
}
