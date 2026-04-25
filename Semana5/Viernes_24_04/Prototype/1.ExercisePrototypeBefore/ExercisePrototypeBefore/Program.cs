
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

        Product iphone = notebook;
        iphone.Name = "New Iphone";
        Console.WriteLine(notebook);
        Console.WriteLine("----------------------------------------");
        Console.WriteLine(iphone);
        Console.ReadLine();
    }
}