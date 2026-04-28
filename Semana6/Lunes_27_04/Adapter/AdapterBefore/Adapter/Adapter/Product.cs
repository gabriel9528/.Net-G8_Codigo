namespace Adapter
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Product(string nombre, int precio)
        {
            Name = nombre;
            Price = precio;
        }
    }
}
