namespace Module2HW2
{
    public class FakeClient
    {
        public static void StartShoping1()
        {
            Client client = new Client();
            client.TakeBasket();
            client.Basket.DeleteFromBasket(client.Basket.GetBasket()[0]);
            client.GetOrder(client.Basket);
        }

        public static void StartShoping2()
        {
            Client client1 = new Client();
            client1.TakeBasket();
            client1.GetOrder(client1.Basket);
        }
    }
}