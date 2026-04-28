namespace Adapter
{
    public class ProductDataProvider
    {
        public static List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product("Iphone 13", 1500),
                new Product("Samsung Galaxy A-15", 2500),
                new Product("Xiomi", 1000),
                new Product("Huawei", 800),
                new Product("Motorola", 700),
            };
        }
    }
}
