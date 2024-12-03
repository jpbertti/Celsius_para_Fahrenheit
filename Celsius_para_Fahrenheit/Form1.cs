using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celsius_para_Fahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCelsius.Clear();
            txtFahrenheit.Clear();
            txtCelsius.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double celsius;
            double fahrenheit;

            // Verifica se o valor inserido no TextBox é um número válido
            if (double.TryParse(txtCelsius.Text, out celsius))
            {
                // Converte de Celsius para Fahrenheit
                fahrenheit = (celsius * 1.8) + 32;

                // Exibe o resultado no TextBox de Fahrenheit
                txtFahrenheit.Text = fahrenheit.ToString();
            }
            else
            {
                // Caso o valor não seja válido
                MessageBox.Show("Por favor, insira um valor numérico válido para Celsius.");
            }
        }
    }
}
