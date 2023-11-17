using Microsoft.VisualBasic;

namespace ConversorParImpar
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            txtNumber.KeyPress += txtNumber_KeyPress;

        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            if (txtNumber.Text == "")
            {
                MessageBox.Show("Informe um número!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                char lastDigit;
                string response;

                response = txtNumber.Text;

                lastDigit = response.ToString()[^1];

                if (lastDigit == '1' || lastDigit == '3' || lastDigit == '5' || lastDigit == '7' || lastDigit == '9')
                {
                    MessageBox.Show("Algarismo Impar");
                }
                else
                {
                    MessageBox.Show("Algarismo Par");
                }
            }
        }
    }
}