using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Área
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtarea.Clear();
            txtld1.Clear();
            txtld2.Clear();
            txtld3.Clear();
            txttipo.Clear();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double a, b, c;
            double area;
            double s;
            String tipo;

            if (string.IsNullOrEmpty(txtld1.Text) || string.IsNullOrEmpty(txtld2.Text) || string.IsNullOrEmpty(txtld3.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor para todos los lados del triángulo.", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                a = Convert.ToInt32(txtld1.Text);
                b = Convert.ToInt32(txtld2.Text);
                c = Convert.ToInt32(txtld3.Text);

                s = (a + b + c) / 2;
                area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                txtarea.Text = area.ToString();

                if (a == b && a == c && b == c)
                {
                    tipo = "Equilatero";
                    txttipo.Text = tipo.ToString();
                }
                else if (a == b || a == c || b == c)
                {
                    tipo = "Isosceles";
                    txttipo.Text = tipo.ToString();
                }
                else
                {
                    tipo = "Escaleno";
                    txttipo.Text = tipo.ToString();
                }
            }
        }
    }
}
