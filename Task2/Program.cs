using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var enc1251 = Encoding.GetEncoding(1251);
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.InputEncoding = enc1251;

            List<Currency> _currency = new List<Currency>();
            _currency.Add(new Currency() { From = "USD", To = "UAH", ExchangeRate = 27.96 });
            _currency.Add(new Currency() { From = "UAH", To = "USD", ExchangeRate = 0.04 });
            _currency.Add(new Currency() { From = "UAH", To = "EUR", ExchangeRate = 0.03 });
            _currency.Add(new Currency() { From = "EUR", To = "UAH", ExchangeRate = 32.84 });
            _currency.Add(new Currency() { From = "EUR", To = "USD", ExchangeRate = 1.17 });
            _currency.Add(new Currency() { From = "USD", To = "EUR", ExchangeRate = 0.85 });
            _currency.Add(new Currency() { From = "UAH", To = "RUB", ExchangeRate = 2.72 });
            _currency.Add(new Currency() { From = "RUB", To = "UAH", ExchangeRate = 0.37 });
            _currency.Add(new Currency() { From = "RUB", To = "USD", ExchangeRate = 0.01 });
            _currency.Add(new Currency() { From = "USD", To = "RUB", ExchangeRate = 76.07 });
            _currency.Add(new Currency() { From = "RUB", To = "EUR", ExchangeRate = 0.01 });
            _currency.Add(new Currency() { From = "EUR", To = "RUB", ExchangeRate = 89.35 });
            _currency.Add(new Currency() { From = "CNY", To = "UAH", ExchangeRate = 4.26 });
            _currency.Add(new Currency() { From = "CNY", To = "USD", ExchangeRate = 0.15 });
            _currency.Add(new Currency() { From = "UAH", To = "CNY", ExchangeRate = 0.23 });
            _currency.Add(new Currency() { From = "USD", To = "CNY", ExchangeRate = 6.56 });
            _currency.Add(new Currency() { From = "CNY", To = "EUR", ExchangeRate = 0.13 });
            _currency.Add(new Currency() { From = "EUR", To = "CNY", ExchangeRate = 7.71 });
            _currency.Add(new Currency() { From = "CNY", To = "RUB", ExchangeRate = 11.59 });
            _currency.Add(new Currency() { From = "RUB", To = "CNY", ExchangeRate = 0.09 });

            Interaction.Exchange(_currency);
        }

    }    
}

