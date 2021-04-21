using System;
using System.Collections.Generic;

namespace HW8
{
    public class DeleteProduct
    {
        public static void RemoveTheProduct(List<Products> _store)
        {
            bool flag = true;

            Console.WriteLine("Введіть назву продукту: ");
            var nameBook = Console.ReadLine();

            foreach (Products data in _store)
            {
                if (data.Name == nameBook)
                {
                    _store.Remove(data);
                    Console.WriteLine("Продукт успішно видалено");
                    flag = false;
                    break;
                }
            }

            if (flag)
                Console.WriteLine("Такого продукту немає на складі.");
        }
    }
}
