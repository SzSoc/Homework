using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_Z4
/*Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, a następnie
przypiszesz im następujące wartości:
a. 10
b. Szkoła Dotneta
c. 12,5

 */
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a= 10;
            double b = 12.5;
            string c = "Szkoła Dotneta";

            Console.WriteLine($"{a}\n{c}\n{b}");
            Console.ReadKey();
            

            
        }
    }
}
