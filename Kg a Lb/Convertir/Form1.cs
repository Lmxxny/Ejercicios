using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtkal.Clear();
            txtlak.Clear();
            txtn.Clear();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double n;
            double resultado;

            if (string.IsNullOrEmpty(txtn.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor para n.", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { 
                n = Convert.ToDouble(txtn.Text);

            
                if (rdkal.Checked)
                {
                    resultado = n * 2.20462;
                    txtkal.Text = resultado.ToString();
                    txtlak.Text = n.ToString();
                }
                else if (rdlak.Checked)
                {
                    resultado = n / 2.20462;
                    txtlak .Text = resultado.ToString();
                    txtkal .Text = n.ToString();
                }
            }
        }
    }
}
