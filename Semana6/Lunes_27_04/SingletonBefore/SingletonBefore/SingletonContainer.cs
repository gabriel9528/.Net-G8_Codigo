namespace SingletonBefore
{
    public class SingletonContainer
    {
        private Dictionary<string, Double> _capitales = new Dictionary<string, Double>();

        private SingletonContainer()
        {
            Console.WriteLine("Inicializando Singleton");

            var elements = File.ReadAllLines("Capitales.txt");

            for (int i = 0; i < elements.Length; i += 2)
            {
                string ciudad = elements[i];

                string poblacionStr = elements[i + 1].Replace(",", "");
                double poblacion = double.Parse(poblacionStr);

                _capitales.Add(ciudad, poblacion);
            }
        }

        private static Lazy<SingletonContainer> _instance = 
            new Lazy<SingletonContainer>(() => new SingletonContainer());

        public static SingletonContainer Instance => _instance.Value;
        public int GetPopulation(string name)
        {
            return (int)_capitales[name];
        }
    }
}
