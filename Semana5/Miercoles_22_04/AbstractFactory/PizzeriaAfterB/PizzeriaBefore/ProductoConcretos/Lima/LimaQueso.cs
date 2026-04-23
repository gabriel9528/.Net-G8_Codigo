using PizzeriaBefore.ProductoAbstracto.Interfaces;

namespace PizzeriaBefore.ProductoConcretos.Arequipa
{
    public class LimaQueso : IQueso
    {
        public void QuesoParmesano()
        {
            Console.WriteLine("Agregando queso parmesano - Lima " + Environment.NewLine);
        }
    }
}
