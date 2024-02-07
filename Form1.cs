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
        string operacao = "";
        decimal numero_um = 0;
        decimal numero_dois = 0;

        bool precisaLimparTela = false;

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
            // Pega o valor do campo de texto
            decimal valor = decimal.Parse(txtResultado.Text);

            // Se o valor for zero, deve limpar o visor
            if (valor == 0 || precisaLimparTela)
            {
                // Limpa o campo de texto
                precisaLimparTela = false;
                txtResultado.Clear();
            }

            // Pega o texto do visor e adiciona o novo numero
            txtResultado.Text = txtResultado.Text + numero.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            AdicionaNumeroVisor(2);
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            AdicionaNumeroVisor(3);
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            AdicionaNumeroVisor(4);
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            AdicionaNumeroVisor(5);
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            AdicionaNumeroVisor(6);
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            AdicionaNumeroVisor(7);
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            AdicionaNumeroVisor(8);
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            AdicionaNumeroVisor(9);
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            decimal resultado = 0;
            numero_dois = decimal.Parse(txtResultado.Text);

            if (operacao == "+")
            {
                resultado = numero_um + numero_dois;
            } 
            else if (operacao == "-")
            {
                resultado = numero_um - numero_dois;
            } 
            else if (operacao == "*")
            {
                resultado = numero_um * numero_dois;
            }
            else if (operacao == "/")
            {
                if (numero_dois == 0)
                {
                    return;
                }

                resultado = numero_um / numero_dois;
            }

            // Converte o resultado em texto e coloca no visor
            txtResultado.Text = resultado.ToString();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            SelecionaOperacao("+");
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            SelecionaOperacao("-");
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            SelecionaOperacao("*");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            SelecionaOperacao("/");
        }

        private void SelecionaOperacao(string operador)
        {
            // Guarda a operação
            operacao = operador;

            // Converte o numero do visor para decimal e guarda
            numero_um = decimal.Parse(txtResultado.Text);

            // Marca que a tela precisa ser limpa
            precisaLimparTela = true;
        }
    }
}
