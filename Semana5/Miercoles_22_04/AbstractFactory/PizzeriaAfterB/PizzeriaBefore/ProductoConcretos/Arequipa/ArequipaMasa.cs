using PizzeriaBefore.ProductoAbstracto.Interfaces;

namespace PizzeriaBefore.ProductoConcretos.Arequipa
{
    public class ArequipaMasa : IMasa
    {
        public void MasaDelgada()
        {
            Console.WriteLine("Agragando masa delgada - Arequipa" + Environment.NewLine);
        }
    }
}
