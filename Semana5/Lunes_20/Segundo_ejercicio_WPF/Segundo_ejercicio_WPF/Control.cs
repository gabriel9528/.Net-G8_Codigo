namespace Segundo_ejercicio_WPF
{
    public class Control
    {
        public List<Region> listRegions;
        public int puntos;
        public List<int> preguntasDadas = new List<int>();

        public Control()
        {
            listRegions = new List<Region>();
            CargarRegiones();
        }

        private void CargarRegiones()
        {
            listRegions.Add(new Region("Argentina", "Buenos Aires"));
            listRegions.Add(new Region("Brasil", "Brasilia"));
            listRegions.Add(new Region("Chile", "Santiago de Chile"));
            listRegions.Add(new Region("Uruguay", "Montevideo"));
            listRegions.Add(new Region("Paraguay", "Asuncion"));
            listRegions.Add(new Region("Bolivia", "La Paz"));
            listRegions.Add(new Region("Peru", "Lima"));
            listRegions.Add(new Region("Ecuador", "Quito"));
            listRegions.Add(new Region("Colombia", "Bogota"));
            listRegions.Add(new Region("Venezuela", "Caracas"));
        }

        public void ReiniciarSistema()
        {
            puntos = 0;
            preguntasDadas = new List<int>();
        }

        public Region DarPregunta()
        {
            try
            {
                Random random = new Random();
                int indiceAleatorio = random.Next(0, listRegions.Count);

                if(preguntasDadas.Count >= listRegions.Count)
                {
                    Console.WriteLine($"Todas las preguntas ya han sido realizadas. " +
                        $"Puntaje acumulado: {puntos}");
                    return null;
                }
                else
                {
                    foreach(int index in preguntasDadas)
                    {
                        if(index == indiceAleatorio)
                        {
                            return DarPregunta();
                        }
                    }
                }

                preguntasDadas.Add(indiceAleatorio);
                return listRegions[indiceAleatorio];

            }
            catch(Exception e)
            {
                throw new Exception("Error: " + e);
            }
        }
    }
}
