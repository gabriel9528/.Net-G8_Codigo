using ExerciseBuilder.Builder;
using ExerciseBuilder.Product;

namespace ExerciseBuilder.ConcreteBuilder
{
    public class CheeseBurger : SandwichBuilder
    {
        protected Sandwich _sandwich = new Sandwich();

        public CheeseBurger()
        {
            _sandwich = new Sandwich();
        }

        public override void AgregarCondimento()
        {
            _sandwich.Condimentos = "Ketchup, Mostaza";
        }

        public override void AgregarPan()
        {
            _sandwich.Pan = "Pan de Hamburgesa";
        }

        public override void AgregarProteina()
        {
            _sandwich.Proteinas = "Carne de Hamburguesa";
        }

        public override void AgregarQueso()
        {
            _sandwich.Queso = "Queso Cheedar";
        }

        public override void AgregarVerdura()
        {
            _sandwich.Verduras = "Lechuga, Tomate";
        }

        public override Sandwich GetSandwich()
        {
            return _sandwich;
        }
    }
}
