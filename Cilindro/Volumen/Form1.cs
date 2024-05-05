using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volumen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtvol.Clear();
            txtrd.Clear();
            txth.Clear();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double h, radio;
            double volumen;

            if (string.IsNullOrEmpty(txth.Text) || string.IsNullOrEmpty(txtrd.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor en los campos en blanco", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                h = Convert.ToInt32(txth.Text);
                radio = Convert.ToInt32(txtrd.Text);
                volumen = Math.PI * Math.Pow(radio, 2) * h;
                txtvol.Text = volumen.ToString();
            }
        }
    }
}
