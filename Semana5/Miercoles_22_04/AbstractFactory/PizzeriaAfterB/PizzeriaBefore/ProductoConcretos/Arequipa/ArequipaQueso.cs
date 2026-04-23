using PizzeriaBefore.ProductoAbstracto.Interfaces;

namespace PizzeriaBefore.ProductoConcretos.Arequipa
{
    public class ArequipaQueso : IQueso
    {
        public void QuesoParmesano()
        {
            Console.WriteLine("Agregando queso parmesano - Arequipa " + Environment.NewLine);
        }
    }
}
