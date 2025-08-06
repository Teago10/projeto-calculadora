namespace calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {

            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            //Realiza a soma dos números e exiba o resultado
            lblResultado.Text = (numero1 + numero2).ToString(); //.ToString() converte para String
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            lblResultado.Text = (numero1 - numero2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            lblResultado.Text = (numero1 / numero2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            lblResultado.Text = (numero1 * numero2).ToString();
        }
    }
}
