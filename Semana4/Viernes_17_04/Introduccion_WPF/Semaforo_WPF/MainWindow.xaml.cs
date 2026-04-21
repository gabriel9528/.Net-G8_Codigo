using System.Windows;

namespace Semaforo_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            ElipseRoja.Visibility = Visibility.Visible;
            ElipseAmarilla.Visibility = Visibility.Hidden;
            ElipseVerde.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            ElipseRoja.Visibility = Visibility.Hidden;
            ElipseAmarilla.Visibility = Visibility.Visible;
            ElipseVerde.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            ElipseRoja.Visibility = Visibility.Hidden;
            ElipseAmarilla.Visibility = Visibility.Hidden;
            ElipseVerde.Visibility = Visibility.Visible;
        }
    }
}