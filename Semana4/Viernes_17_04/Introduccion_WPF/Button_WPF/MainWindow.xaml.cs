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

namespace Button_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Grid myGrid = new Grid();
            this.Content = myGrid;

            Button myButton = new Button();
            myButton.Width = 200;
            myButton.Height = 100;
            myButton.Background = Brushes.LightBlue;

            WrapPanel myWrapPanel = new WrapPanel();

            TextBlock myTextBlock1 = new TextBlock();
            myTextBlock1.Text = "Hello";
            myTextBlock1.Foreground = Brushes.LightGreen;
            myWrapPanel.Children.Add(myTextBlock1);

            TextBlock myTextBlock2 = new TextBlock();
            myTextBlock2.Text = " World";
            myTextBlock2.Foreground = Brushes.Red;
            myWrapPanel.Children.Add(myTextBlock2);

            TextBlock myTextBlock3 = new TextBlock();
            myTextBlock3.Text = " WPF";
            myTextBlock3.Foreground = Brushes.Yellow;
            myWrapPanel.Children.Add(myTextBlock3);

            myButton.Content = myWrapPanel;

            myGrid.Children.Add(myButton);

        }
    }
}