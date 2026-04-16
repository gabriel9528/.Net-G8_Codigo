namespace WinFormsAppDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boton clickeado");
        }

        private void button_demo_DataContextChanged(object sender, EventArgs e)
        {

        }
    }
}
