using PizzeriaBefore.ProductoAbstracto.Interfaces;

namespace PizzeriaBefore.FabricaAbstracta
{
    public interface IPizzaIngredientesFactory
    {
        IMasa CrearMasa();
        ISalsas CrearSalsas();
        IQueso CrearQueso();
        List<IVerduras> CrearVerduras();
    }
}
