using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Segundo_ejercicio_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Control ControlMain { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            ControlMain = new Control();
        }

        private void buttonConfigurar_Click(object sender, RoutedEventArgs e)
        {
            VentanaConfigurar ventanaConfigurar = new VentanaConfigurar(ControlMain);
            ventanaConfigurar.ShowDialog();
        }

        private void buttonEmpezarJuego_Click(object sender, RoutedEventArgs e)
        {
            VentanaJugar ventanaJugar = new VentanaJugar(ControlMain);
            ventanaJugar.ShowDialog();
        }
    }
}