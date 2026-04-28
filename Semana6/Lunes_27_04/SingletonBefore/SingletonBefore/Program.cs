using SingletonBefore;

class Program
{
    static void Main(string[] args)
    {
        var capitales = SingletonContainer.Instance;
        var capitales1 = SingletonContainer.Instance;
        var capitales2 = SingletonContainer.Instance;
        Console.WriteLine($"Los habitantes son: {capitales.GetPopulation("Buenos Aires")}");
        Console.ReadLine();
    }
}

