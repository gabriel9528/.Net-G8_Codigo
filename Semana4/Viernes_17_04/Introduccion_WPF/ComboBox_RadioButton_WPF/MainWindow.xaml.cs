using System.Windows;

namespace ComboBox_RadioButton_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Capitales> listCapitales = new List<Capitales>();
            listCapitales.Add(new Capitales { NombreCapital = "Lima"});
            listCapitales.Add(new Capitales { NombreCapital = "Bogota"});
            listCapitales.Add(new Capitales { NombreCapital = "Quito"});
            listCapitales.Add(new Capitales { NombreCapital = "Santiago"});

            Capitales.ItemsSource = listCapitales;
        }

        private void Individual_Checked(object sender, EventArgs e)
        {
            if(Madrid.IsChecked == true 
                &&  Bogota.IsChecked == true 
                && Lima.IsChecked == true
                &&Santiago.IsChecked == true)
            {
                TodasCapitales.IsChecked = true;
            }
            else
            {
                TodasCapitales.IsChecked=null;
            }
        }

        private void Individual_UnChecked(object sender, EventArgs e)
        {
            if (Madrid.IsChecked == false
                && Bogota.IsChecked == false
                && Lima.IsChecked == false
                && Santiago.IsChecked == false)
            {
                TodasCapitales.IsChecked = false;
            }
            else
            {
                TodasCapitales.IsChecked = null;
            }
        }

        private void Todas_Checked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = true;
            Bogota.IsChecked = true;
            Lima.IsChecked = true;
            Santiago.IsChecked = true;
        }

        private void Todas_UnChecked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = false;
            Bogota.IsChecked = false;
            Lima.IsChecked = false;
            Santiago.IsChecked = false;
        }


    }
}