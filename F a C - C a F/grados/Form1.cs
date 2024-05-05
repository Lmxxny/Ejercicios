using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtn.Clear();
            txtfac.Clear();
            txtcaf.Clear(); 
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
                MessageBox.Show("Por favor, ingresa un valor para x.", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                n = Convert.ToDouble(txtn.Text);


                if (rdfac.Checked)
                {
                    resultado = (n - 32) * 5 / 9;
                    txtfac.Text = resultado.ToString();
                    txtcaf.Text = n.ToString();
                }
                else if (rdcaf.Checked)
                {
                    resultado = (n * 9 / 5) + 32;
                    txtcaf.Text = resultado.ToString();
                    txtfac.Text = n.ToString();
                }
            }

        }
    }
}
