using static System.Console;

namespace PizzeriaBefore
{
    public class Pizza
    {
        public string Nombre { get; set; }
        protected string Masa { get; set; }
        protected string Salsas { get; set; }
        protected List<string> Extras { get; set; } = new List<string>();

        public void Prepare()
        {
            WriteLine($"Preparando: {Nombre}");
            WriteLine($"Colocando masa: {Masa}");
            WriteLine($"Agregando salsas: {Salsas}");
            WriteLine($"Agregando capas: {string.Join(",", Extras)}");
        }

        public void Cocinar() => WriteLine($"Cocinar por 20 min");
        public void Cortar() => WriteLine($"Pizza fue cortada en partes iguales");
        public void Encajar() => WriteLine($"Pizza colocada en la caja oficial");
    }

    public class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = null;
            switch (type)
            {
                case "Peperoni":
                    pizza = new PeperoniPizza();
                    break;
                case "Napolitana":
                    pizza = new NapolitanaPizza();
                    break;
                case "Vegetariana":
                    pizza = new VegetarianaPizza();
                    break;
            }

            if (pizza != null)
            {
                pizza.Prepare();
                pizza.Cocinar();
                pizza.Cortar();
                pizza.Encajar();
            }

            return pizza;
        }
    }

    internal class PeperoniPizza : Pizza
    {
        public PeperoniPizza()
        {
            Nombre = "Peperoni";
            Masa = "Delgada";
            Salsas = "Salsa de Tomate";
            Extras.Add("Salsa de Peperoni");
        }
    }

    internal class NapolitanaPizza : Pizza
    {
        public NapolitanaPizza()
        {
            Nombre = "Napolitana";
            Masa = "Delgada";
            Salsas = "Salsa de Tomate";
            Extras.Add("Salsa de Naploitana");
            Extras.Add("Extra de queso mozarela");
        }
    }

    internal class VegetarianaPizza : Pizza
    {
        public VegetarianaPizza()
        {
            Nombre = "Vegetariana";
            Masa = "Delgada";
            Salsas = "Marinada";
            Extras.Add("Aceite de oliva");
            Extras.Add("Salsa de ajo");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore myStore = new PizzaStore();
            Pizza pizza = myStore.OrderPizza("Peperoni");
            Console.WriteLine($"Pizza: {pizza.Nombre} lista para ser entregada");
            Console.ReadLine();
        }
    }
}
