using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_types_T5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, surname, city, street, zip_code;
            byte age;
            short number;
            long telephone;
            char s;


            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Your surname?");
            surname = Console.ReadLine();
            Console.WriteLine("How old are you?");
            age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Your sex M or F");
            s = char.Parse(Console.ReadLine());
            Console.WriteLine("Your Adress:");
            Console.WriteLine("City");
            city = (Console.ReadLine());
            Console.WriteLine("Street");
            street = (Console.ReadLine());
            Console.WriteLine("Building number");
            number = short.Parse(Console.ReadLine());
            Console.WriteLine("Telephone number");
            telephone = long.Parse(Console.ReadLine());

            Console.WriteLine($"your name : {name}\nSurname : {surname}\n Your age is: {age}\n Your sex is: {s}");
            Console.WriteLine($"Your adress is: {city}\n{street}\n{number}\n{telephone}");
            Console.ReadKey();
        }
    }
}
