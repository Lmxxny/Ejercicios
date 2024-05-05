using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Determinar_y
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtx.Clear();
            txty1.Clear();
            txty2.Clear();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            int x1 = 2, x2;
            int y1, y2;
            double c = 2.5;

            if (string.IsNullOrEmpty(txtx.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor para x.", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                x2 = Convert.ToInt32(txtx.Text);

                y1 = (int)(x1 * c - 2);
                txty1.Text = y1.ToString();

                y2 = (int)(x2 * c - 2);
                txty2.Text = y2.ToString();
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txty1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
