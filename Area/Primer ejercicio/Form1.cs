using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            int altura, bas;
            int area;
            altura = Convert.ToInt32(txtaltura.Text);
            bas = Convert.ToInt32(txtbase.Text);

            area = altura * bas;
            txtarea.Text = area.ToString();
            txtb.Text = bas.ToString();
            txth.Text = altura.ToString();

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txth.Clear();
            txtb.Clear();
            txtarea.Clear();
            txtaltura.Clear();
            txtbase.Clear();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
