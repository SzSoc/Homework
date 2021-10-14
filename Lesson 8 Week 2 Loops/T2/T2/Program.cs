using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Task 2");
                int a = 0;
                do
                {
                    if (a % 2 == 0)
                    {
                        Console.WriteLine(a);
                    }
                    a++;
                } while (a <= 1000);
            }
            Console.ReadKey();
            
        }
    }
}
