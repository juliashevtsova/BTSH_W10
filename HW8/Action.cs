using System;
using System.Collections.Generic;

namespace HW8
{
    public class Action
    {
        public static void ChooseAction(Dictionary<string, string> _login, List<Products> _store)
        {
            while (true)
            {
                Console.WriteLine("Ви менеджер чи покупець:\n(1) Менеджер, (2) Покупець");
                var userOperation = Console.ReadLine();

                switch (userOperation)
                {
                    case "1": Avtorized.AvtorizedManager(_login, _store); break;
                    case "2": Customer.ChooseAction(_store); break;
                    default: Console.WriteLine("Ви ввели неправильну цифру"); break;
                }
            }
        }
    }
}
