using System.Windows;

namespace Segundo_ejercicio_WPF
{
    /// <summary>
    /// Lógica de interacción para VentanaConfigurar.xaml
    /// </summary>
    public partial class VentanaConfigurar : Window
    {
        public Control Control;
        public VentanaConfigurar(Control control)
        {
            InitializeComponent();
            Control = control;
            MostrarRegiones();
        }

        private void buttonIngresar_Click(object sender, RoutedEventArgs e)
        {
            Control.listRegions.Add(new Region(textBoxPais.Text, textBoxCapital.Text));
            listBoxRegiones.Items.Add(textBoxPais.Text + " - " +  textBoxCapital.Text);
            textBoxPais.Text = "";
            textBoxCapital.Text = "";
        }

        private void MostrarRegiones()
        {
            foreach(Region region in Control.listRegions)
            {
                listBoxRegiones.Items.Add(region.Pais + " - " +  region.Capital);
            }
        }

        private void buttonVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonJugar_Click(object sender, RoutedEventArgs e)
        {
            VentanaJugar ventanaJugar = new VentanaJugar(Control);
            ventanaJugar.Show();
        }
    }
}
