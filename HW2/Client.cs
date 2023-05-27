using System;
namespace Module2HW2
{
    public class Client
    {
        public Client()
        {
            Bas = new Basket();
        }

        public Basket Bas { get; set; }

        public void TakeBasket()
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            var res = new Basket();
            var list = Product.GetListProd();
            res.AddToBasket(new Product(list[rand.Next(0, list.Count)], rand.Next(1, 10)));
            res.AddToBasket(new Product(list[rand.Next(0, list.Count)], rand.Next(1, 10)));
            res.AddToBasket(new Product(list[rand.Next(0, list.Count)], rand.Next(1, 10)));
            res.AddToBasket(new Product(list[rand.Next(0, list.Count)], rand.Next(1, 10)));
            Bas = res;
        }

        public Order GetOrder(Basket list)
        {
            var prod = new List<Product>(Bas.GetBasket());
            Order res = new Order(list);
            list.CleanBasket();
            Console.WriteLine("===================================================");
            Console.WriteLine($"Order with ID {res.OrderId}");
            Console.WriteLine("===================================================");
            foreach (var item in prod)
            {
                Console.WriteLine($"{item.Name} -- {item.Cost} -- {item.Number} -- {item.Sum}");
            }

            Console.WriteLine($"Total : {res.Total}");
            Console.WriteLine(string.Empty);
            return res;
        }
    }
}
