namespace Module2HW2
{
    public class Basket
    {
        private Product[] _prodInBasket;
        private int i = 0;

        public Basket()
        {
           _prodInBasket = new Product[1];
        }

        public void AddToBasket(Product item)
        {
            _prodInBasket[i] = item;
            i++;
            Array.Resize(ref _prodInBasket, i + 1);
        }

        public void DeleteFromBasket(Product item)
        {
            var res = new List<Product>(i);
            res = _prodInBasket.ToList();
            for (int i = 0; i < res.Count; i++)
            {
                if (_prodInBasket[i].Name == item.Name)
                {
                    res.RemoveAt(i);
                }
            }

            _prodInBasket = res.ToArray();
        }

        public Product[] GetBasket()
        {
            return _prodInBasket;
        }

        public void CleanBasket()
        {
           _prodInBasket = new Product[1];
        }
    }
}