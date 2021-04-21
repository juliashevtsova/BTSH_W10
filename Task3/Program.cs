using System;
using System.Threading;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate();
        }
        public static void Calculate()
        {
            int x = 1000;
            while (x > 0)
            {
                Console.Write($"{Convert.ToString(x)} - 7 = ");
                x = x - 7;
                Console.WriteLine((x));
                Thread.Sleep(50);
            }
            Console.WriteLine("I`m Ghoul");
        }
    }
}
