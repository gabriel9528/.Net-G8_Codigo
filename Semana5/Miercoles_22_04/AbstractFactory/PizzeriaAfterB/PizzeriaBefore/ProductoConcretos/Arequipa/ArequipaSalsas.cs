using PizzeriaBefore.ProductoAbstracto.Interfaces;

namespace PizzeriaBefore.ProductoConcretos.Arequipa
{
    public class ArequipaSalsas : ISalsas
    {
        public void SalsaMarinada()
        {
            Console.WriteLine("Agregando salsa marinada - Arequipa" + Environment.NewLine);
        }
    }
}
