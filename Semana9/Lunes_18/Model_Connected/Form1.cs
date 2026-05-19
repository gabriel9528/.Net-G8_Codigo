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

        private void button_refresh_Click(object sender, EventArgs e)
        {
            RefreshDataFlight();
        }

        private void LoadFlightDetails(int id)
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.ConnectionString = connectionString;
            }

            command = connection.CreateCommand();

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "select * from FlightInfo where id = @FlightId";
                command.CommandText = query;
                command.Parameters.AddWithValue("@FlightId", id);

                using(SqlDataReader reader = command.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        textBox_airline.Text = reader["airline"].ToString();
                        textBox_flight_number.Text = reader["flight_number"].ToString();
                        textBox_destination.Text = reader["destination"].ToString();

                        string airplanetype = reader["air_plane_type"].ToString();
                        comboBox_air_plane_type.SelectedValue = airplanetype;
                    }

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

        private bool isAirPlaneTypeSelectionChanging = false;

        private void comboBox_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isAirPlaneTypeSelectionChanging)
            {
                DataRowView selectedRow = comboBox_select.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    int selectedFlightById = Convert.ToInt32(selectedRow["id"]);
                    if (selectedFlightById > 0)
                    {
                        LoadFlightDetails(selectedFlightById);

                        string airplanetype = selectedRow["air_plane_type"].ToString();

                        for (int i = 0; i < comboBox_air_plane_type.Items.Count; i++)
                        {
                            var item = comboBox_air_plane_type.Items[i];

                            if (item is DataRowView dataRowView)
                            {
                                if (dataRowView["air_plane_type"].ToString() == airplanetype)
                                {
                                    isAirPlaneTypeSelectionChanging = true;
                                    comboBox_air_plane_type.SelectedIndex = i;
                                    isAirPlaneTypeSelectionChanging = false;
                                    break;
                                }
                            }
                            
                            else if (item is string str && str == airplanetype)
                            {
                                isAirPlaneTypeSelectionChanging = true;
                                comboBox_air_plane_type.SelectedIndex = i;
                                isAirPlaneTypeSelectionChanging = false;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string airline = textBox_airline.Text;
            string flightNumber = textBox_flight_number.Text;
            string destination  = textBox_destination.Text;
            string airplanetype = "";
            DataRowView selectedRow = (DataRowView)comboBox_air_plane_type.SelectedItem;
            if(selectedRow != null)
            {
                airplanetype = selectedRow["air_plane_type"].ToString();
            }
            

            if(string.IsNullOrEmpty(airline) || string.IsNullOrEmpty(flightNumber)
                || string.IsNullOrEmpty(destination) || string.IsNullOrEmpty(airplanetype) )
            {
                MessageBox.Show("Es obligatorio llenar todos los campos");
            }

            connection.ConnectionString = connectionString;
            command = new SqlCommand("insert into FlightInfo (airline, flight_number, destination, air_plane_type)"
                + "values (@Airline, @FlightNumber, @Destination, @AirPlaneType)", connection);

            command.Parameters.AddWithValue("@Airline", airline);
            command.Parameters.AddWithValue("@FlightNumber", flightNumber);
            command.Parameters.AddWithValue("@Destination", destination);
            command.Parameters.AddWithValue("@AirPlaneType", airplanetype);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Vuelo agregado exitosamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                command.Dispose();
                connection.Close();
                RefreshDataFlight();
            }

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if(comboBox_select.SelectedValue == null) { return; }

            int id = Convert.ToInt32(comboBox_select.SelectedValue);
            string airline = textBox_airline.Text;
            string flightNumber = textBox_flight_number.Text;
            string destination = textBox_destination.Text;
            string airplanetype = "";
            DataRowView selectedRow = (DataRowView)comboBox_air_plane_type.SelectedItem;
            if (selectedRow != null)
            {
                airplanetype = selectedRow["air_plane_type"].ToString();
            }

            if (string.IsNullOrEmpty(airline) || string.IsNullOrEmpty(flightNumber)
                || string.IsNullOrEmpty(destination) || string.IsNullOrEmpty(airplanetype))
            {
                MessageBox.Show("Es obligatorio llenar todos los campos");
            }

            connection.ConnectionString = connectionString;
            command = new SqlCommand("update FlightInfo set airline = @Airline, flight_number = @FlightNumber, " +
                "destination = @Destination, air_plane_type = @AirPlaneType where id = @Id", connection);

            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Airline", airline);
            command.Parameters.AddWithValue("@FlightNumber", flightNumber);
            command.Parameters.AddWithValue("@Destination", destination);
            command.Parameters.AddWithValue("@AirPlaneType", airplanetype);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Vuelo actualizado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                command.Dispose();
                connection.Close();
                RefreshDataFlight();
            }

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (comboBox_select.SelectedValue == null) { return; }

            int id = Convert.ToInt32(comboBox_select.SelectedValue);

            connection.ConnectionString = connectionString;
            command = new SqlCommand("delete from FlightInfo where id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Vuelo eliminado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                command.Dispose();
                connection.Close();
                RefreshDataFlight();
            }

        }
    }
}
