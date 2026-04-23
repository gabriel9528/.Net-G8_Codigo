using PizzeriaBefore.FabricaAbstracta;
using PizzeriaBefore.ProductoAbstracto.Interfaces;

namespace PizzeriaBefore.Cliente
{
    public class Peperoni : Pizza
    {
        IPizzaIngredientesFactory _ingredientesFactory;

        public Peperoni(IPizzaIngredientesFactory ingredientesFactory)
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
