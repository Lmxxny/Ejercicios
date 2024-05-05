using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Función_5
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

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double x1 = 1, x2;
            double y1, y2;

            if (string.IsNullOrEmpty(txtx.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor para x.", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                x2 = Convert.ToInt32(txtx.Text);

                y1 = 5 * Math.Pow(x1, 4) + 2 * Math.Pow(x1, 3) + 3 * Math.Pow(x1, 2) + 7;
                txty1.Text = y1.ToString();

                y2 = 5 * Math.Pow(x2, 4) + 2 * Math.Pow(x2, 3) + 3 * Math.Pow(x2, 2) + 7;
                txty2.Text = y2.ToString();
            }
        }
    }
}
