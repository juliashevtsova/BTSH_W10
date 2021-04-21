using System;
using System.Collections.Generic;

namespace HW8
{
    public class Manager
    {
        public static void SelectAnAction(Dictionary<string, string> _login, List<Products> _store)
        {
            Console.WriteLine("Оберіть дію: \n(1) Додати продукт , (2) Видалити продукт, (3) Переглянути всі товари,(4) Вийти");
            var userOperation = Console.ReadLine();

            switch (userOperation)
            {
                case "1": AddProducts.AddNewProducts(_store); break;
                case "2": DeleteProduct.RemoveTheProduct(_store); break;
                case "3": Store.ShowProducts(_store); break;
                case "4": Action.ChooseAction(_login, _store); break;
                default: Console.WriteLine("Ви ввели неправильну цифру"); break;
            }
        }
    }
}
