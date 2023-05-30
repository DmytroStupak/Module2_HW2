namespace Module2HW2
{
    public class Order
    {
        private Product[] _prodInOrder;
        private static int _orderID = 0;
        public Order(Basket basket)
        {
            _orderID++;
            _prodInOrder = basket.GetBasket();
            foreach (var item in _prodInOrder)
            {
                if (item == null)
                {
                    continue;
                }

                Total += item.Sum;
            }
        }

        public decimal Total { get; set; }
        public Product[] ProdInOrder => _prodInOrder;
        public int OrderId => _orderID;
    }
}