using PizzeriaBefore.FabricaAbstracta;
using PizzeriaBefore.ProductoAbstracto.Interfaces;
using PizzeriaBefore.ProductoConcretos.Arequipa;

namespace PizzeriaBefore.FabricaConcreta
{
    public class LimaPizzaIngredientesFactory : IPizzaIngredientesFactory
    {
        public IMasa CrearMasa()
        {
            return new LimaMasa();
        }

        public IQueso CrearQueso()
        {
            return new LimaQueso();
        }

        public ISalsas CrearSalsas()
        {
            return new LimaSalsas();
        }

        public List<IVerduras> CrearVerduras()
        {
            return new List<IVerduras>();
        }
    }
}
