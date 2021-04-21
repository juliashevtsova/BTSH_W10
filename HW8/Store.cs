using System;
using System.Collections.Generic;

namespace HW8
{
    public class Store
    {
        public static void ShowProducts(List<Products> _store)
        {
            foreach (Products store in _store)
            {
                Console.WriteLine(store.Name + " | " + store.Price + " | " + store.Number);
            }
        }
    }
}
