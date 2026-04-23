
class Program
{
    public class User
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Country { get; private set; }

        public User(string name, string email, string country)
        {
            Name = name;
            Email = email;
            Country = "Peru";
        }

        public User(string name, string email)
        {
            Name = name;
            Email = email;
            Country = "Peru";
        }
    }

    public static void Main(string[] args)
    {
        //Forma tradicional
        var user = new User("Gabriel", "gabrielsxf@gmail.com", "Peru");
        Console.WriteLine($"Usuario: {user.Name}, Email: {user.Email}, Pais: {user.Country}");
    }
}