using ExerciseBuilder.Builder;
using ExerciseBuilder.Product;

namespace ExerciseBuilder.Director
{
    public class SandwichAssembly
    {
        private SandwichBuilder _sandwichBuilder;

        public void SetBuilder(SandwichBuilder builder)
        {
            _sandwichBuilder = builder;
        }

        public void Assembly()
        {
            _sandwichBuilder.AgregarPan();
            _sandwichBuilder.AgregarQueso();
            _sandwichBuilder.AgregarVerdura();
            _sandwichBuilder.AgregarCondimento();
        }

        public Sandwich GetSandwich()
        {
            return _sandwichBuilder.GetSandwich();
        }
    }
}
