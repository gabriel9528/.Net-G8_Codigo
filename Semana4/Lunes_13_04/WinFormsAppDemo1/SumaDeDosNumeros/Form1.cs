namespace SumaDeDosNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            textBox_primer.Text = string.Empty;
            textBox_segundo.Text = "";

            label_resultado.Text = string.Empty;
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            int first_number = Convert.ToInt32(textBox_primer.Text);
            int second_number = Convert.ToInt32(textBox_segundo.Text);

            int result = first_number + second_number;
            label_resultado.Text = result.ToString();
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
