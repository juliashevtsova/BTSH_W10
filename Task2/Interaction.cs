using System;
using System.Collections.Generic;

namespace Task2
{
    public class Interaction
        {
            public static void Exchange(List<Currency> _currency)
            {
                while (true)
                {
                    Console.WriteLine("Введіть першу валюту");
                    string from = Console.ReadLine();

                    Console.WriteLine("Введіть другу валюту");
                    string to = Console.ReadLine();

                    Console.WriteLine("Введіть суму");
                    double sum = Convert.ToDouble(Console.ReadLine());

                    bool flag = false;

                    if (sum < 0)
                    {
                        Console.WriteLine("Сума некоректна: "+sum);
                        continue;
                    }
                    foreach (var pair in _currency)
                    {
                        if (from == pair.From && to == pair.To)
                        {
                            Console.WriteLine($"Ви отримуєте:{sum * pair.ExchangeRate} " + to);
                            flag = true;
                        }
                    }

                    if(!flag)
                    Console.WriteLine("Такого обміну нема");
                    
                }
            }
        }
    
}

