using System;

namespace T_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task 9");
            int In, Div, DivR, BinLenght;
            string Bin = null, Bin2, Out = null;

            Console.WriteLine("Give me a number");
            In = int.Parse(Console.ReadLine());
            Div = In;

            while (Div > 0)
            {
                DivR = Div % 2;
                Bin2 = Convert.ToString(DivR);
                Bin += Bin2;
                Div = Div / 2;
            }

            BinLenght = Bin.Length - 1;
            while (BinLenght >= 0)
            {
                Out = Out + Bin[BinLenght];
                BinLenght--;
            }
            Console.WriteLine($"{In} in binary is {Out}");
            Console.ReadKey();
        }
    }
}
