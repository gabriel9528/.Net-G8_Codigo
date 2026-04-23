
class Program
{

    public static class UserFactory
    {
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

    }

    public static void Main(string[] args)
    {

        var user = UserFactory.CreateWithDefaultCountry("Gabriel", "gabrielsxf@gmail.com");
        Console.WriteLine($"Usuario: {user.Name}, Email: {user.Email}, Pais: {user.Country}");
        Console.ReadLine();
    }
}