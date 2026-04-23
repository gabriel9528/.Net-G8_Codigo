using PizzeriaBefore.FabricaAbstracta;
using PizzeriaBefore.ProductoAbstracto.Interfaces;
using PizzeriaBefore.ProductoConcretos.Arequipa;

namespace PizzeriaBefore.FabricaConcreta
{
    public class ArequipaPizzaIngredientesFactory : IPizzaIngredientesFactory
    {
        public IMasa CrearMasa()
        {
            return new ArequipaMasa();
        }

        public IQueso CrearQueso()
        {
            return new ArequipaQueso();
        }

        public ISalsas CrearSalsas()
        {
            return new ArequipaSalsas();
        }

        public List<IVerduras> CrearVerduras()
        {
            return new List<IVerduras>();
        }
    }
}
