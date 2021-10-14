using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task 5");
            int a = 1;
            for (int i = 1; i <= 20; i++)
            {

                Console.WriteLine("the " + i + " to the power 3 = " + Math.Pow(a, 3));
                a++;
            }
            Console.ReadKey();
        }
    }
}
