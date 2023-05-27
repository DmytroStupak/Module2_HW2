namespace Module2HW2
{
    public class FakeClient
    {
        public static void StartShoping1()
        {
            Client client = new Client();
            client.TakeBasket();
            client.Bas.DeleteFromBasket(client.Bas.GetBasket()[0]);
            client.GetOrder(client.Bas);
        }

        public static void StartShoping2()
        {
            Client client1 = new Client();
            client1.TakeBasket();
            client1.GetOrder(client1.Bas);
        }
    }
}