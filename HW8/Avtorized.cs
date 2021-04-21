using System;
using System.Collections.Generic;

namespace HW8
{
    public class Avtorized
    {
        public static void AvtorizedManager(Dictionary<string, string> _login, List<Products> _store)
        {
            Console.WriteLine("Введіть логін");
            var login = Console.ReadLine();

            Console.WriteLine("Введіть пароль");
            var password = Console.ReadLine();

            bool manager = true;

            if (login == "manager" && password == "manager")
            {
                while (true)
                {
                    Manager.SelectAnAction(_login,_store);

                    if (!manager)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("Введений пароль і логін неправильний");
        }
    }
}
