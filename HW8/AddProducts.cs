using System;
using System.Collections.Generic;

namespace HW8
{
    public class AddProducts
    {
        public static void AddNewProducts(List<Products> _store)
        {
            Products products = new Products();

            Console.WriteLine("Введіть назву продукту:");
            products.Name = Console.ReadLine();

            Console.WriteLine("Введіть ціну продукту:");
            products.Price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть кількість товару:");
            products.Number = Convert.ToInt32(Console.ReadLine());

            _store.Add(products);
            Console.WriteLine($"{products.Name} доданий в магазин.");
        }
    }
}
