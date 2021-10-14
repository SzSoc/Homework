using System;

namespace T_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task 8");
            Console.WriteLine("Give");
            string In = Console.ReadLine(), Re = "";
            int L;
            L = In.Length - 1;

            while (L >= 0)
            {
                Re += In[L];
                L--;
            }

            Console.WriteLine(Re);
        }
    }
}
