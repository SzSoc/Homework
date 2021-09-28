using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szymon Socha");
            //Task 1.
            {
                Console.WriteLine("Task 1");
                int a, b;
                a = 5;
                b = 5;
                if (a == b)
                {
                    Console.WriteLine(a + " i " + b + " są równe");
                }
                else
                {
                    Console.WriteLine("nie są równe:");
                }
            }
            //Task 2.
            {
                Console.WriteLine("\nTask 2");
                Console.WriteLine("Podaj liczbę");
                int a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                    Console.WriteLine("Liczba jest parzysta");
                }
                else
                {
                    Console.WriteLine("Nie patrzysta");
                }
            }
                {
                    //Task 3
                    Console.WriteLine("\nTask 3");
                    Console.WriteLine("Podaj liczbę");
                    int a = int.Parse(Console.ReadLine());
                    if (a < 0)
                    {
                        Console.WriteLine("Jest ujemna");
                    }
                    else
                    {
                        Console.WriteLine("Jest dodatnia");
                    }
                }
            
            //Task 4
            {
                Console.WriteLine("\nTask 4");
                Console.WriteLine("Podaj rok który mamy");
                int year = int.Parse(Console.ReadLine());
                if (year % 4 == 0)
                {
                    Console.WriteLine("Mamy rok przestępny");
                }
                else
                {
                    Console.WriteLine("Nie, to nie jest rok przestępny");
                }
            }
            //Task 5
            {
                Console.WriteLine("\nTask 5");
                Console.WriteLine("How old are you");
                int age = int.Parse(Console.ReadLine());
                if (age < 21)
                {
                    Console.WriteLine("you cannot run for government");
                }
                if (age >= 21)
                {
                    Console.WriteLine("You can become a deputy");
                }
                if (age >= 30)
                {
                    Console.WriteLine("You can become a senator or prime minister");
                }
                if (age >= 35)
                {
                    Console.WriteLine("You can become a president");
                }
            }
            //Task 6
            {
                Console.WriteLine("\nTask 6");
                Console.WriteLine("How tall are you?");
                float tall = float.Parse(Console.ReadLine());
                if (tall <= 140)
                {
                    Console.WriteLine("You are a Dwarf");
                }
                if (tall > 140 && tall <= 160)
                {
                    Console.WriteLine("you are a small person");
                }
                if (tall > 160 && tall < 180)
                {
                    Console.WriteLine("you have standard growth");
                }
                else if (tall > 180)
                {
                    Console.WriteLine("Wow you are a Giagant baby");
                }
            }
            //task 7
            {
                Console.WriteLine("\nTask 7");
                Console.WriteLine("Please give three numbers");
                int a, b, c;
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
                if (a < c && b < c)
                {
                    Console.WriteLine(c);
                }
                if (a < b && c < b)
                {
                    Console.WriteLine(b);
                }
                if (b < a && c < a)
                {
                    Console.WriteLine(a);
                }
                //task 8
                {
                    Console.WriteLine("\nTask 8");
                    float physic, chemistry, math;
                    Console.WriteLine("\nPlease inster your exam scores");
                    Console.WriteLine("Physic:");
                    physic = float.Parse(Console.ReadLine());
                    Console.WriteLine("Chemistry:");
                    chemistry = float.Parse(Console.ReadLine());
                    Console.WriteLine("Math:");
                    math = float.Parse(Console.ReadLine());
                    if (math >= 70)
                    {
                        Console.WriteLine($"Physic score: {physic} \nChemistry score: {chemistry} \nMath score {math}\nCandidate to be modified for recruitment");
                    }
                    else if (physic + chemistry + math >= 180)
                    {
                        Console.WriteLine($"Physic score: {physic} \nChemistry score: {chemistry} \nMath score {math}\nCandidate to be modified for recruitment");

                    }
                    else if (math + physic >= 150 || math + chemistry >= 150)
                    {
                        Console.WriteLine($"Physic score: {physic} \nChemistry score: {chemistry} \nMath score {math}\nCandidate to be modified for recruitment");

                    }
                    else
                    {
                        Console.WriteLine("Sorry your score is to low :(");
                    }
                }
                //task 9
                {

                    Console.WriteLine("\nTask 9");
                    Console.WriteLine("Podaj temperature");
                    double temp = double.Parse(Console.ReadLine());

                    if (temp < 0)
                    {
                        Console.WriteLine("cholernie piździ");
                    }
                    else if (temp >= 10 && temp <= 20)
                    {
                        Console.WriteLine("Zimno");
                    }
                    else if (temp >= 10 && temp <= 20)
                    {
                        Console.WriteLine("Chłodno");
                    }
                    else if (temp >= 20 && temp <= 30)
                    {
                        Console.WriteLine("W sam raz");
                    }
                    else if (temp >= 30 && temp <= 40)
                    {
                        Console.WriteLine("Zaczyna być słabo, bo gorco");
                    }
                    else
                    {
                        Console.WriteLine("A weź wyprowadzam siena Alaskę");
                    }
                }
            }
            //task 10
            {
                double a, b, c;
                Console.WriteLine("\nTask 10");
                Console.WriteLine("Enter the dimensions of the triangle\n Side lengt: ( A,B,C )");
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                c = double.Parse(Console.ReadLine());

                if (a + b <= c || b + c <= a || c + a <= b)
                {
                    Console.WriteLine($"Side lenght A: {a}\nSide lenght B: {b}\nSide lenght: {c}\nYou can build a triangle");
                }
                else
                {
                    Console.WriteLine("You can't build a triangle becouse a+b<=c");
                }
            }
            //task 11
            {
                Console.WriteLine("\nTask 11");
                Console.WriteLine("Please insert student mark from 1 to 6");
                int choosen = int.Parse(Console.ReadLine());
                switch (choosen)
                {
                    case 1:
                        Console.WriteLine("Niedostateczny");
                        break;
                    case 2:
                        Console.WriteLine("Dopuszczający");
                        break;
                    case 3:
                        Console.WriteLine("Dostateczny");
                        break;
                    case 4:
                        Console.WriteLine("Dobry");
                        break;
                    case 5:
                        Console.WriteLine("Bardzo dobry");
                        break;
                    case 6:
                        Console.WriteLine("Celujący");

                        break;
                    default:
                        break;
                }
                if (choosen < 1 || choosen > 6)
                {
                    Console.WriteLine("Please insert a correct mark");
                }

            }
            //task 12
            {
                Console.WriteLine("\ntask 12");
                Console.WriteLine("Please insert number of the day from 1 to 7");
                int day = int.Parse(Console.ReadLine());
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Wennday");
                        break;
                    case 3:
                        Console.WriteLine("Thursday");
                        break;
                    case 4:
                        Console.WriteLine("Fourday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("Please insert a correct number");
                        break;

                }
           
                //task 13
                {
                    double a, b;
                    Console.WriteLine("\nTask 13");
                    Console.WriteLine("Hello User, please insert operation from menu (1-4)");
                    Console.WriteLine("1.Addition\n2.Substraction\n3.Multiplication\n4.Bravely");
                    int choosen = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please insert the first number");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Please insert the second number");
                    b = double.Parse(Console.ReadLine());
                    if (choosen<1|| choosen>4)
                    {
                        Console.WriteLine("Please insert the correct number");
                    }
                    switch(choosen)
                    {
                        case 1:
                            Console.WriteLine($"The result of the actions is={a+b}");
                            break;
                        case 2:
                            Console.WriteLine($"The result of the actions is={a - b}");
                            break;
                        case 3:
                            Console.WriteLine($"The result of the actions is={a * b}");
                            break;
                        case 4:
                            Console.WriteLine($"The result of the actions is={a / b}");
                            break;
                        default:
                          
                            break;
                    }
                }
                Console.ReadKey();
            }


        }
    }
}
