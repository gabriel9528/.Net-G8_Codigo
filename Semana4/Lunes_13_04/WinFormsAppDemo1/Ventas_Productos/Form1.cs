using System.Collections;

namespace Ventas_Productos
{
    public partial class Form1 : Form
    {
        static string[] productos =
            { "Celular", "Laptop", "Monitor", "Televisor", "Lavadora" };

        ArrayList listProducts = new ArrayList(productos);

        Ventas ventas = new Ventas();

        double total;
        public Form1()
        {
            InitializeComponent();
            MostrarFecha();
            MostrarHora();
            LimpiarCampos();
            LlenarProductos();
        }

        private void MostrarFecha()
        {
            label_fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void MostrarHora()
        {
            label_hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void LimpiarCampos()
        {
            textBox_cliente.Text = string.Empty;
            comboBox_productos.Text = "Seleccione un producto";
            textBox_cantidad.Text = string.Empty;
            label_precio.Text = "0.0";
            textBox_cliente.Focus();
        }

        private void LlenarProductos()
        {
            foreach (var item in listProducts)
            {
                comboBox_productos.Items.Add(item);
            }
        }
        private void button_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea salir?.", "Ventas",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                LimpiarCampos();
            }
        }

        private void comboBox_productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ventas.Producto = comboBox_productos.Text;
            label_precio.Text = ventas.AsignarPrecio().ToString("c");
        }

        private void button_registrar_Click(object sender, EventArgs e)
        {
            ventas.Producto = comboBox_productos.Text;
            ventas.Cantidad = int.Parse(textBox_cantidad.Text);

            ListViewItem fila = new ListViewItem(ventas.Producto);

            fila.SubItems.Add(ventas.Cantidad.ToString());
            fila.SubItems.Add(ventas.AsignarPrecio().ToString("c"));
            fila.SubItems.Add(ventas.CalcularSubTotal().ToString("c"));
            fila.SubItems.Add(ventas.CalcularDescuento().ToString("c"));
            fila.SubItems.Add(ventas.CalcularNeto().ToString("c"));

            listViewRegistro.Items.Add(fila);

            total += ventas.CalcularNeto();

            label_total_neto.Text = total.ToString("c");

            LimpiarCampos();

        }
    }
}
