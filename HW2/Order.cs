namespace Module2HW2
{
    public class Order
    {
        private List<Product> _prodInOrder = new List<Product>() { };
        private static int _orderID = 0;
        public Order(Basket item)
        {
            _orderID++;
            _prodInOrder = item.GetBasket();
            Total = _prodInOrder.Select(x => x.Sum).Sum();
        }

        public decimal Total { get; set; }
        public List<Product> ProdInOrder => _prodInOrder;
        public int OrderId => _orderID;
    }
}