using System.Text.Json;

namespace DeepCopy
{
    public static class ExtensionMethos
    {
        public static T DeepCopy<T>(this T source)
        {
            if(source == null)
            {
                throw new ArgumentNullException(nameof(source), "La fuente a copiar no puede estar vacia");
            }
            var options = new JsonSerializerOptions
            {
                WriteIndented = false,
                IncludeFields = true,
            };

            var jsonString = JsonSerializer.Serialize(source, options);

            //Deserializarlo
            return JsonSerializer.Deserialize<T>(jsonString, options);
        }
    }

    public class Category
    {
        public string Name { get; set; }
        public Category(string name)
        {
            Name = name;
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public Product(string name, Category category)
        {
            Name = name;
            Category = category;
        }
        public override string ToString()
        {
            return $"Producto: {Name}, Categoria: {Category.Name}";
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            Product notebook = new Product("MacBook Pro", new Category("Computers"));

            Product iphone = notebook.DeepCopy();
            iphone.Name = "New Iphone";
            iphone.Category.Name = "Cellphones";

            Console.WriteLine(notebook);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(iphone);
            Console.ReadLine();
        }
    }
}