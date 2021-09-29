using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types//Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy. Dane
//które chcesz przetrzymywać to:
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, id, surname;
            byte age;
            
            long e;
            char s;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Your surname?");
            surname = Console.ReadLine();
            Console.WriteLine("How old are you?");
            age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Your sex M or F");
            s = char.Parse(Console.ReadLine());
            Console.WriteLine("What is your ID number");
            id = (Console.ReadLine());
            Console.WriteLine("your employee number");
            e = long.Parse(Console.ReadLine());

            Console.WriteLine($"your name : {name}\nSurname : {surname}\n Your age is: {age}\n Your sex is: {s}");
            Console.WriteLine($"Your Id numer is: {id}\n Your employee number is: {e}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
