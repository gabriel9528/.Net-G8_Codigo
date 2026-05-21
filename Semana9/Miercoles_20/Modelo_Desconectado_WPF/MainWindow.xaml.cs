using Modelo_Desconectado_WPF.DataSet1TableAdapters;
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

namespace Modelo_Desconectado_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> listAirPlaneTypes = new List<string>();

        DataSet1 dataSet1 = new DataSet1();
        //-------------------------------------**FlightInfo**-------------------------------------------
        //Un tableAdapter es una clase que facilita la interaccion entre la aplicacion y la base de datos
        //Se encarga de llenar la tabla con los datos de la bd y tambien enviar los cambios de vuelta
        FlightInfoTableAdapter flightInfoTableAdapter = new FlightInfoTableAdapter();

        //Es una tabla en memoria destinada a almacenar los datos relacionados con la tabla FlightInfo
        DataSet1.FlightInfoDataTable flightInfoDataTable = new DataSet1.FlightInfoDataTable();

        //-------------------------------------**UserInfo**-------------------------------------------
        UserInfoTableAdapter userInfoTableAdapter = new UserInfoTableAdapter();

        DataSet1.UserInfoDataTable userInfoDataTable = new DataSet1.UserInfoDataTable();

        public MainWindow()
        {
            InitializeComponent();
            listAirPlaneTypes.Clear();
            listAirPlaneTypes.Add("Boeing 737");
            listAirPlaneTypes.Add("Boeing 747");
            listAirPlaneTypes.Add("Boeing 757");
            listAirPlaneTypes.Add("Boeing 767");
            listAirPlaneTypes.Add("Boeing 777");
            listAirPlaneTypes.Add("AirBus 123");
            listAirPlaneTypes.Add("AirBus 500");
            listAirPlaneTypes.Add("AirBus 900");

            RefreshDataGridFlight();
        }

        private void RefreshDataGridFlight()
        {
            //ejecutar una consulta SQl en la bd para obtener los registros y llenar la tabla correspondiente
            //dentro del dataSet1 con esos datos.
            flightInfoTableAdapter.Fill(dataSet1.FlightInfo);

            flightInfoTableAdapter.Fill(flightInfoDataTable);
            dataGridFlights.ItemsSource = flightInfoDataTable;

            comboBoxFlights.ItemsSource = flightInfoDataTable;
            comboBoxFlights.DisplayMemberPath = "flight_number";
            comboBoxFlights.SelectedValuePath = "id";

    
        }


        #region Flights
        #endregion

        #region Users
        #endregion

        private void comboBoxFlights_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}