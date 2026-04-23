using PizzeriaBefore.ProductoAbstracto.Interfaces;

namespace PizzeriaBefore.ProductoConcretos.Arequipa
{
    public class LimaSalsas : ISalsas
    {
        public void SalsaMarinada()
        {
            Console.WriteLine("Agregando salsa marinada - Lima" + Environment.NewLine);
        }
    }
}
