using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_T2//Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w
//odwrotnej kolejności niż zostały zadeklarowane.
{
    class Program
    {
        static void Main(string[] args)
        {
            char a, b, c;
            Console.WriteLine("Enter the first letter");
            a = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second letter");
            b = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third letter");
            c = char.Parse(Console.ReadLine());
            Console.WriteLine($"{c} \n{b}\n{a}");
            Console.ReadKey();
        }
    }
}
