using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3//Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość
//przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())

{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght, width,diagonal;
            Console.WriteLine("Give me a lenght of rectangle");
            lenght = Double.Parse(Console.ReadLine());
            Console.WriteLine("Give me a width of rectangle");
            width = Double.Parse(Console.ReadLine());
            diagonal = Math.Sqrt(Math.Pow(lenght, 2) + Math.Pow(width, 2));
            Console.WriteLine($"Diagonal = {diagonal}");
            Console.ReadKey();
        }
    }
}
