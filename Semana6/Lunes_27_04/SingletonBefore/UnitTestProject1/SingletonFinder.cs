using System.Collections.Generic;

namespace SingletonBefore
{
    public class SingletonFinder
    {
        public int GetTotalPopulation(IEnumerable<string> listaCapitales)
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
