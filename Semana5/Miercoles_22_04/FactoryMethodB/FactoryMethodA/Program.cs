
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
            Country = country;
        }

        //Crear un metodo para que por defecto nos cree el Pais
        public static User CreateWithDefaultCountry(string name, string email)
        {
            return new User(name, email, "Peru");
        }

        //Crear un metodo para que por defecto sea un email statico
        public static User CreateWithDefaultEmail(string name, string country)
        {
            return new User(name, "gabrielsxf@gmail.com", country);
        }

    }

    public static void Main(string[] args)
    {
        //Forma tradicional
        //var user = new User("Gabriel", "gabrielsxf@gmail.com", "Peru");
        //Console.WriteLine($"Usuario: {user.Name}, Email: {user.Email}, Pais: {user.Country}");

        var user = User.CreateWithDefaultCountry("Gabriel", "gabrielsxf@gmail.com");
        Console.WriteLine($"Usuario: {user.Name}, Email: {user.Email}, Pais: {user.Country}");
        Console.ReadLine();
    }
}