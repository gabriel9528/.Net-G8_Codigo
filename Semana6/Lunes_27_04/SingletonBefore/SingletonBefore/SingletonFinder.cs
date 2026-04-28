namespace SingletonBefore
{
    public class SingletonFinder
    {
        public int GetPopulation(IEnumerable<string> listaCapitales)
        {
            int total = 0;
            foreach(var poblacion in listaCapitales)
            {
                total += SingletonContainer.Instance.GetPopulation(poblacion);
            }
            return total;
        }
    }
}
