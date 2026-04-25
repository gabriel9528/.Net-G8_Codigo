namespace ExerciseFluentBuilder
{
    public class SandwichBuilder
    {
        protected Sandwich _sandwich = new Sandwich();

        public SandwichBuilder AgregarPan()
        {
            _sandwich.Pan = "Pan de molde";
            return this;
        }

        public SandwichBuilder AgregarVerduras()
        {
            _sandwich.Verduras = "Lechuga, tomate";
            return this;
        }

        public SandwichBuilder AgregarProteina()
        {
            _sandwich.Proteinas = "Proteina de carne";
            return this;
        }

        public SandwichBuilder AgregarCondimentos()
        {
            _sandwich.Condimentos = "Mayonesa, Mostaza";
            return this;
        }

        public SandwichBuilder AgregarQueso()
        {
            _sandwich.Queso = "Queso Cheedar";
            return this;
        }

        public Sandwich Build()
        {
            return _sandwich;
        }
    }
}
