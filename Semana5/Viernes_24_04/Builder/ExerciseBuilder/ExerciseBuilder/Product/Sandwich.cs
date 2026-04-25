namespace ExerciseBuilder.Product
{
    public class Sandwich
    {
        public string Pan {  get; set; }
        public string Verduras { get; set; }
        public string Proteinas { get; set; }
        public string Condimentos { get; set; }
        public string Queso { get; set; }

        public Sandwich()
        {
            
        }

        public Sandwich(string pan, string verduras, string proteinas, string condimentos, string queso)
        {
            Pan = pan;
            Verduras = verduras;
            Proteinas = proteinas;
            Condimentos = condimentos;
            Queso = queso;
        }

        public override string ToString()
        {
            return $"Sandwich : \n" +
                $"- Pan: {Pan}\n" +
                $"- Verduras: {Verduras}\n" +
                $"- Proteinas: {Proteinas}\n" +
                $"- Condimentos: {Condimentos}\n" +
                $"- Queso: {Queso}\n";
        }
    }
}
