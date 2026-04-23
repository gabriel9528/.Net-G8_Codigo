using PizzeriaBefore.ProductoAbstracto.Interfaces;

namespace PizzeriaBefore.ProductoConcretos.Arequipa
{
    public class LimaMasa : IMasa
    {
        public void MasaDelgada()
        {
            Console.WriteLine("Agragando masa delgada - Lima" + Environment.NewLine);
        }
    }
}
