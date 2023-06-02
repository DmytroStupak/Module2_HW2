using System;
namespace Module2HW2
{
    public class Client
    {
        public Client()
        {
            Basket = new Basket();
        }

        public Basket Basket { get; set; }

        public void TakeBasket()
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            var list = Product.GetListProd();
            Basket.AddToBasket(new Product(list[rand.Next(0, list.Count)], rand.Next(1, 10)));
            Basket.AddToBasket(new Product(list[rand.Next(0, list.Count)], rand.Next(1, 10)));
            Basket.AddToBasket(new Product(list[rand.Next(0, list.Count)], rand.Next(1, 10)));
            Basket.AddToBasket(new Product(list[rand.Next(0, list.Count)], rand.Next(1, 10)));
        }

        public Order GetOrder(Basket list)
        {
            Order res = new Order(list);
            list.CleanBasket();
            Console.WriteLine("===================================================");
            Console.WriteLine($"Order with ID {res.OrderId}");
            Console.WriteLine("===================================================");
            foreach (var item in res.ProdInOrder)
            {
                if (item == null)
                {
                    continue;
                }

                Console.WriteLine($"{item.Name} -- {item.Cost} -- {item.Number} -- {item.Sum}");
            }

            Console.WriteLine($"Total : {res.Total}");
            Console.WriteLine(string.Empty);
            return res;
        }
    }
}
