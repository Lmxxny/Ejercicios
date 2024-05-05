using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circulo
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
            txtrad.Clear();
            txtperi.Clear();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            int radio;
            double perimetro;
            double area;
            radio = Convert.ToInt32(txtrad.Text);

           perimetro = 2 * Math.PI * radio;
            area = Math.PI * Math.Pow(radio, 2);
            txtperi.Text = perimetro.ToString();
            txtarea.Text = area.ToString(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
