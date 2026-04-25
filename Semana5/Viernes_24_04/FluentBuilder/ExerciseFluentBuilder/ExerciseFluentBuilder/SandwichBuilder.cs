namespace ExerciseFluentBuilder
{
    public class SandwichBuilder
    {
        protected Sandwich _sandwich = new Sandwich();

        public SandwichBuilder AgregarPan()
        {
            _sandwich.Proteinas = "Pan de molde";
            return this;
        }

        public SandwichBuilder AgregarVerduras()
        {
            _sandwich.Proteinas = "Lechuga, tomate";
            return this;
        }

        public SandwichBuilder AgregarProteina()
        {
            _sandwich.Proteinas = "Proteina de carne";
            return this;
        }

        public SandwichBuilder AgregarCondimentos()
        {
            _sandwich.Proteinas = "Mayonesa, Mostaza";
            return this;
        }

        public SandwichBuilder AgregarQueso()
        {
            _sandwich.Proteinas = "Queso Cheedar";
            return this;
        }

        public Sandwich Build()
        {
            return _sandwich;
        }
    }
}
