namespace Module2HW2
{
    public class Product
    {
        public Product(NameProduct product, decimal number)
        {
            Name = product.Name;
            Cost = product.Cost;
            Number = number;
            Sum = product.Cost * number;
        }

        public string Name { get; set; }
        public decimal Cost { get; set; }
        public decimal Number { get; set; }
        public decimal Sum { get; set; }
        public static List<NameProduct> GetListProd()
        {
            var listProd = new List<NameProduct>
            {
                new NameProduct("Bread", 5.0m),
                new NameProduct("Butter", 7.0m),
                new NameProduct("Meat", 10.0m),
                new NameProduct("Fish", 9.0m),
                new NameProduct("Cakes", 4.0m),
                new NameProduct("Cheese", 6.0m),
                new NameProduct("Onion", 1.0m),
                new NameProduct("Tomato", 3.0m),
                new NameProduct("Apple", 4.0m),
                new NameProduct("Cherry", 3.0m),
                new NameProduct("Ice Cream", 2.0m),
                new NameProduct("Pasta", 4.0m),
                new NameProduct("Tea", 2.0m),
                new NameProduct("Coffee", 3.0m),
                new NameProduct("Milk", 1.0m)
            };

            return listProd;
        }
    }
}