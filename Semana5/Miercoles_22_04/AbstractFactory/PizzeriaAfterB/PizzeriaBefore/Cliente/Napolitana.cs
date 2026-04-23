using PizzeriaBefore.FabricaAbstracta;
using PizzeriaBefore.ProductoAbstracto.Interfaces;

namespace PizzeriaBefore.Cliente
{
    public class Napolitana : Pizza
    {
        private readonly IMasa _masa;
        private readonly ISalsas _salsas;
        private readonly IQueso _queso;
        private readonly List<IVerduras> _versuras;

        public Napolitana(IPizzaIngredientesFactory ingredientesFactory)
        {
            _masa = ingredientesFactory.CrearMasa();
            _salsas = ingredientesFactory.CrearSalsas();
            _queso = ingredientesFactory.CrearQueso();
            _versuras = ingredientesFactory.CrearVerduras();
        }
        public override void Prepare()
        {
            Console.WriteLine($"Preparando: {Nombre}");
            _masa.MasaDelgada();
            _queso.QuesoParmesano();
            _salsas.SalsaMarinada();
        }
    }
}
