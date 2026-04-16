namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double Number1 = 0;
        private double Number2 = 0;
        private Char Operator;
        public Form1()
        {
            InitializeComponent();
        }

        private void AgregarNumero(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (textBoxResultado.Text == "0")
            {
                textBoxResultado.Text = "";
            }

            textBoxResultado.Text += button.Text;
        }

        private void AgregarOperador(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Number1 = double.Parse(textBoxResultado.Text);

            Operator = Convert.ToChar(button.Tag);

            if (Operator == '²')
            {
                Number1 = Math.Pow(Number1, 2);
            }
            else if (Operator == '√')
            {
                Number1 = Math.Sqrt(Number1);
            }
            else
            {
                textBoxResultado.Text = "0";
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonBorrarUltimo_Click(object sender, EventArgs e)
        {

        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            Number2 = double.Parse((string)textBoxResultado.Text);
            if(Operator == '+')
            {
                textBoxResultado.Text = (Number1+Number2).ToString();
                Number1 = Convert.ToDouble(textBoxResultado.Text);
            }
            else if(Operator == '-')
            {
                textBoxResultado.Text = (Number1-Number2).ToString();
                Number1 = Convert.ToDouble((string)textBoxResultado.Text);
            }
            else if(Operator == 'x')
            {
                textBoxResultado.Text = (Number1*Number2).ToString();
                Number1 = Convert.ToDouble((string)textBoxResultado.Text);
            }
            else if(Operator == '/')
            {
                if(textBoxResultado.Text != "0")
                {
                    textBoxResultado.Text = (Number1/Number2).ToString();
                }
                else
                {
                    textBoxResultado.Text = "Error";
                }
            }
        }
    }
}
