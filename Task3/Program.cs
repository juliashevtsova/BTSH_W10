using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeSugnificant();
            ChangeRef();
        }

        public static void ChangeSugnificant()
        {
            int digit = 10;
            Console.WriteLine(digit);
            Console.WriteLine(digit + 3);
        }

        public static void ChangeRef()
        {
            string name = Console.ReadLine();
            Console.WriteLine(name);

            name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine("   ");
        }
        

    }
}
