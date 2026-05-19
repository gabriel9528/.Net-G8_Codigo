using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Model_Connected
{
    public partial class Form1 : Form
    {
        private SqlConnection connection = new SqlConnection();
        private string connectionString = @"Data Source=DESKTOP-D3JOOFI;
                                    Initial Catalog=G8_modelo_conectado;
                                    Integrated Security=true";

        private SqlCommand command;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDataFlight();
            RefreshDataFlightAirPlaneType();
        }

        private void RefreshDataFlight()
        {
            connection.ConnectionString = connectionString;
            command = connection.CreateCommand();

            try
            {
                connection.Open();

                command.CommandText = "select * from FlightInfo";
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    dataGridView1.DataSource = dataTable;

                    comboBox_select.DataSource = dataTable;
                    comboBox_select.DisplayMember = "flight_number";
                    comboBox_select.ValueMember = "id";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                command.Dispose();
                connection.Close();
            }
        }

        private void RefreshDataFlightAirPlaneType()
        {
            connection.ConnectionString = connectionString;
            command = connection.CreateCommand();

            try
            {
                connection.Open();

                command.CommandText = "select * from FlightInfo";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    comboBox_air_plane_type.DataSource = dataTable;
                    comboBox_air_plane_type.DisplayMember = "air_plane_type";
                    comboBox_air_plane_type.ValueMember = "id";

                    reader.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                command.Dispose();
                connection.Close();
            }

        }
    }
}
