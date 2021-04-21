using System;
using System.Collections.Generic;

namespace HW8
{
    public class Purchases
    {
        public static void BuyProducts(List<Products> _store)
        {
            var money = 50;
            var name = "";
            Console.WriteLine($"Ваша сума коштів на покупку {money}$");
            while (true)
            {
                Console.WriteLine("Введіть назву товару, який ви хочете придбати: "); //з великої літери
                name = Console.ReadLine();

                bool flag = true;

                foreach (Products buy in _store)
                {
                    if (name == buy.Name)
                    {
                        Console.WriteLine("Введіть кількість товару, який ви хочете купити:");
                        int quantityOfGoods = Convert.ToInt32(Console.ReadLine());

                        if (buy.Number < quantityOfGoods || buy.Number == 0 || quantityOfGoods < 0)
                        {
                            Console.WriteLine("Такої кількості товарів немає в магазині");
                        }
                        else if (quantityOfGoods != 0 )
                        {
                            money = money - quantityOfGoods * buy.Price;
                            buy.Number -= quantityOfGoods;

                            if (buy.Number < 0)
                            {
                                buy.Number = 0;
                            }
                            if (money < 0 || buy.Price > money && money!=0 )
                            {
                                Console.WriteLine("У вас недостатньо коштів");
                                flag = false;
                                break;
                            }
                            Console.WriteLine($"Залишок на рахунку:{money} ");
                            flag = false;
                        }
                    }
                }
                if (flag)
                {
                    if (name == "вихід")
                    {
                        Customer.ChooseAction(_store);
                    }
                    Console.WriteLine("Такого товару немає в магазині");
                }
            }
        }
    }
}
