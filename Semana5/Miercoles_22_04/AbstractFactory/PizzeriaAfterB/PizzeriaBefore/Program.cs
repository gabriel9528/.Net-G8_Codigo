using PizzeriaBefore.Cliente;
using PizzeriaBefore.FabricaAbstracta;
using PizzeriaBefore.FabricaConcreta;

namespace PizzeriaBefore
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizzaIngredientesFactory pizzaIngredientesFactory = new LimaPizzaIngredientesFactory();
            Napolitana napolitana = new Napolitana(pizzaIngredientesFactory);
            napolitana.Cocinar();
            napolitana.Prepare();
            napolitana.Cortar();
            napolitana.Encajar();
        }
    }
}
