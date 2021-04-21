using System;
using System.Collections.Generic;

namespace HW8
{
    public class Customer
    {
        public static void ChooseAction( List<Products> _store)
        {
            while (true)
            {
                Console.WriteLine("Виберіть дію:\n(1) Переглянути всі товари, (2) Купити товар");
                var userOperation = Console.ReadLine();

                switch (userOperation)
                {
                    case "1": Store.ShowProducts(_store); break;
                    case "2": Purchases.BuyProducts(_store); break;                    
                    default: Console.WriteLine("Ви ввели неправильну цифру"); break;
                }
            }
        }
    }
}
