using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraXtreme5000ProMaxBeta5
{
    public partial class FormularioCalculadora : Form
    {
        public FormularioCalculadora()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            AdicionaNumeroVisor(0);
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            AdicionaNumeroVisor(1);
        }

        private void AdicionaNumeroVisor(int numero)
        {
            decimal valor = decimal.Parse(txtResultado.Text);

            if (valor == 0)
            {
                // Limpa o campo de texto
                txtResultado.Clear();
            }

            txtResultado.Text = txtResultado.Text + numero.ToString();
        }
    }
}
