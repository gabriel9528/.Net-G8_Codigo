using PizzeriaBefore.ProductoAbstracto.Interfaces;
using static System.Console;

namespace PizzeriaBefore
{
    public abstract class Pizza
    {
        public string Nombre { get; set; }
        protected IMasa Masa { get; set; }
        protected ISalsas Salsas { get; set; }
        protected IQueso Queso { get; set; }
        protected List<IVerduras> Verduras { get; set; } = new List<IVerduras>();

        public abstract void Prepare();

        public void Cocinar() => WriteLine($"Cocinar por 20 min");
        public void Cortar() => WriteLine($"Pizza fue cortada en partes iguales");
        public void Encajar() => WriteLine($"Pizza colocada en la caja oficial");
    }
}
