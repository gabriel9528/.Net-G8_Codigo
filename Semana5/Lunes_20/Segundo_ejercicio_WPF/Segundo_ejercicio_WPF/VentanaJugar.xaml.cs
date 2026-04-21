using System.Windows;

namespace Segundo_ejercicio_WPF
{
    /// <summary>
    /// Lógica de interacción para VentanaJugar.xaml
    /// </summary>
    public partial class VentanaJugar : Window
    {
        Control ControlMain;
        Region RegionTemporal;
        int Contador;
        public VentanaJugar(Control control)
        {
            InitializeComponent();
            ControlMain = control;
            RegionTemporal = ControlMain.DarPregunta();

            if(RegionTemporal != null)
            {
                labelPregunta.Content = RegionTemporal.Pais;
            }
            else
            {
                MessageBox.Show("No hay mas preguntas");
                this.Close();
            }
        }

        private void buttonConsultar_Click(object sender, RoutedEventArgs e)
        {
            if(RegionTemporal == null)
            {
                MessageBox.Show("No hay mas preguntas disponibles");
                return;
            }
            if(textBoxRespuesta.Text == RegionTemporal.Capital)
            {
                ControlMain.puntos += 10;
            }
            if(Contador < 5)
            {
                RegionTemporal = ControlMain.DarPregunta();
                if(RegionTemporal != null)
                {
                    labelPregunta.Content = RegionTemporal.Pais;
                }
                else
                {
                    MessageBox.Show($"Fin del juego. Puntos: {ControlMain.puntos}");
                    buttonConsultar.IsEnabled = false;
                }
            }
            else
            {
                MessageBox.Show($"Fin del juego. Puntos: {ControlMain.puntos}");
                buttonConsultar.IsEnabled = false;
            }

            textBoxRespuesta.Text = "";
            Contador++;
        }

        private void buttonVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
