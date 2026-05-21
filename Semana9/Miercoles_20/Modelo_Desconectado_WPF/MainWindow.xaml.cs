using Modelo_Desconectado_WPF.DataSet1TableAdapters;
using System.Data;
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

            RefreshDataGridFlight();
            LoadUniqueAirplaneTypes();
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

        private void LoadUniqueAirplaneTypes()
        {

            listAirPlaneTypes.Clear();

            flightInfoTableAdapter.Fill(dataSet1.FlightInfo);

            var uniqueTypes = dataSet1.FlightInfo
                .Where(row => !string.IsNullOrEmpty(row.air_plane_type))
                .Select(row => row.air_plane_type)
                .Distinct()
                .ToList();

            foreach (var type in uniqueTypes)
            {
                listAirPlaneTypes.Add(type);
            }

            comboBoxAirPlaneType.ItemsSource = null;
            comboBoxAirPlaneType.Items.Clear();
            comboBoxAirPlaneType.ItemsSource = listAirPlaneTypes;
        }
        private void btnAddFlight_Click(object sender, RoutedEventArgs e)
        {
            DataSet1.FlightInfoRow flightInfoRow = dataSet1.FlightInfo.NewFlightInfoRow();

            flightInfoRow.airline = txtAirline.Text;
            flightInfoRow.flight_number = txtFlightNumber.Text;
            flightInfoRow.destination = txtDestination.Text;
            flightInfoRow.air_plane_type = comboBoxAirPlaneType.SelectedItem.ToString();

            dataSet1.FlightInfo.Rows.Add(flightInfoRow);
            flightInfoTableAdapter.Update(dataSet1.FlightInfo);

            RefreshDataGridFlight();
        }

        private void btnUpdateFlight_Click(object sender, RoutedEventArgs e)
        {
            int selected = Convert.ToInt32(comboBoxFlights.SelectedValue);
            DataRow[] dataRows = dataSet1.FlightInfo.Select("id=" + selected);

            dataRows[0]["airline"] = txtAirline.Text;
            dataRows[0]["flight_number"] = txtFlightNumber.Text;
            dataRows[0]["destination"] = txtDestination.Text;
            dataRows[0]["air_plane_type"] = comboBoxAirPlaneType.SelectedItem.ToString();

            flightInfoTableAdapter.Update(dataSet1.FlightInfo);

            RefreshDataGridFlight();

        }

        private void btnDeleteFlight_Click(object sender, RoutedEventArgs e)
        {
            int selected = Convert.ToInt32(comboBoxFlights.SelectedValue);
            DataRow[] dataRows = dataSet1.FlightInfo.Select("id=" + selected);
            if(dataRows.Length > 0)
            {
                dataRows[0].Delete();
                flightInfoTableAdapter.Update(dataSet1.FlightInfo);
                RefreshDataGridFlight();

            }

        }

        private void comboBoxFlights_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selected = Convert.ToInt32(comboBoxFlights.SelectedValue);
            DataRow[] dataRows = dataSet1.FlightInfo.Select("id=" + selected);

            if (dataRows.Length > 0)
            {
                DataRow dataRow = dataRows[0];

                txtAirline.Text = dataRow["airline"].ToString();
                txtFlightNumber.Text = dataRow["flight_number"].ToString();
                txtDestination.Text = dataRow["destination"].ToString();
                comboBoxAirPlaneType.SelectedItem = dataRow["air_plane_type"].ToString();
            }
        }

        #endregion

        #region Users
        #endregion



        private void comboBoxUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}