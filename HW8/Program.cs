using System.Collections.Generic;
using System.Text;

namespace HW8
{
    public class Program
    {
        public static Dictionary<string, string> _login = new Dictionary<string, string>() { { "manager", "manager" } };

        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var enc1251 = Encoding.GetEncoding(1251);
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.InputEncoding = enc1251;

            List<Products> _store = new List<Products>();
            _store.Add(new Products() { Name = "Оливкова олія", Price = 13, Number = 70 });
            _store.Add(new Products() { Name = "Червона ікра", Price = 22, Number = 10 });
            _store.Add(new Products() { Name = "Снікерс", Price = 1, Number = 20 });
            _store.Add(new Products() { Name = "Кава", Price = 11, Number = 20 });
            _store.Add(new Products() { Name = "Молоко", Price = 2, Number = 70 });
            _store.Add(new Products() { Name = "Чай", Price = 4, Number = 18 });
            _store.Add(new Products() { Name = "Сік", Price = 2, Number = 100 });
            _store.Add(new Products() { Name = "Вино", Price = 11, Number = 90 });
            _store.Add(new Products() { Name = "Вермішель", Price = 2, Number = 20 });
            _store.Add(new Products() { Name = "Мед", Price = 7, Number = 10 });

            Action.ChooseAction(_login, _store);
        }
    }
}
