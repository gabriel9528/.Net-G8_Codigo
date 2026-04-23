using PizzeriaBefore.FabricaAbstracta;

namespace PizzeriaBefore.Cliente
{
    public class Vegetariana : Pizza
    {
        IPizzaIngredientesFactory _ingredientesFactory;

        public Vegetariana(IPizzaIngredientesFactory ingredientesFactory)
        {
            _ingredientesFactory = ingredientesFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine($"Preparando: {Nombre}");
            Masa = _ingredientesFactory.CrearMasa();
            Queso = _ingredientesFactory.CrearQueso();
            Salsas = _ingredientesFactory.CrearSalsas();
            Verduras = _ingredientesFactory.CrearVerduras();
        }
    }
}
