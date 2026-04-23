using static System.Console;

namespace PizzeriaBefore
{
    #region Producto abstracto
    public abstract class Pizza
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

    #endregion

    #region Productos concretos

        #region Arequipa Pizza

        internal class ArequipaPeperoniPizza : Pizza
        {
            public ArequipaPeperoniPizza()
            {
                Nombre = "Arequipa Peperoni";
                Masa = "Delgada";
                Salsas = "Salsa de Tomate";
                Extras.Add("Salsa de Peperoni");
            }
        }

        internal class ArequipaNapolitanaPizza : Pizza
        {
            public ArequipaNapolitanaPizza()
            {
                Nombre = "Arequipa Napolitana";
                Masa = "Delgada";
                Salsas = "Salsa de Tomate";
                Extras.Add("Salsa de Naploitana");
                Extras.Add("Extra de queso mozarela");
            }
        }

        internal class ArequipaVegetarianaPizza : Pizza
        {
            public ArequipaVegetarianaPizza()
            {
                Nombre = "Arequipa Vegetariana";
                Masa = "Delgada";
                Salsas = "Marinada";
                Extras.Add("Aceite de oliva");
                Extras.Add("Salsa de ajo");
            }
        }

        #endregion

        #region Lima Pizza

        internal class LimaPeperoniPizza : Pizza
        {
            public LimaPeperoniPizza()
            {
                Nombre = "Lima Peperoni";
                Masa = "Delgada";
                Salsas = "Salsa de Tomate";
                Extras.Add("Salsa de Peperoni");
            }
        }

        internal class LimaNapolitanaPizza : Pizza
        {
            public LimaNapolitanaPizza()
            {
                Nombre = "Lima Napolitana";
                Masa = "Delgada";
                Salsas = "Salsa de Tomate";
                Extras.Add("Salsa de Naploitana");
                Extras.Add("Extra de queso mozarela");
            }
        }

        internal class LimaVegetarianaPizza : Pizza
        {
            public LimaVegetarianaPizza()
            {
                Nombre = "Lima Vegetariana";
                Masa = "Delgada";
                Salsas = "Marinada";
                Extras.Add("Aceite de oliva");
                Extras.Add("Salsa de ajo");
            }
        }

    #endregion

    #endregion

    #region Creador Abstracto

    public abstract class PizzaStoreFactory
    {
        public abstract Pizza CreatePizza(string name);
        public Pizza OrderPizza(string name)
        {
            Pizza pizza = CreatePizza(name);
            

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

    #endregion

    #region Creador Concreto

    public class ArequipaPizzaStore : PizzaStoreFactory
    {
        public override Pizza CreatePizza(string name)
        {
            switch(name)
            {
                case "Peperoni":
                    return new ArequipaPeperoniPizza();
                case "Napolitana":
                    return new ArequipaNapolitanaPizza();
                case "Vegetariana":
                    return new ArequipaVegetarianaPizza();
                default:
                    return null;
            }
        }
    }

    public class LimaPizzaStore : PizzaStoreFactory
    {
        public override Pizza CreatePizza(string name)
        {
            switch (name)
            {
                case "Peperoni":
                    return new LimaPeperoniPizza();
                case "Napolitana":
                    return new LimaNapolitanaPizza();
                case "Vegetariana":
                    return new LimaVegetarianaPizza();
                default:
                    return null;
            }
        }
    }

    #endregion


    class Program
    {
        static void Main(string[] args)
        {
            PizzaStoreFactory arequipaStore = new ArequipaPizzaStore();
            Pizza pizza = arequipaStore.OrderPizza("Peperoni");
            Console.WriteLine($"Pizza: {pizza.Nombre} lista para ser entregada");
            Console.ReadLine();
        }
    }
}
