using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E15_Llamada_Telefonica
{
    public partial class Form1 : Form
    {
        LlamadaTelefonica unaLlamadatelefonica = new LlamadaTelefonica();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            unaLlamadatelefonica.Minutos = int.Parse(txtCantidadDeMinutos.Text);
            txtCantidadDeMinutos.Text = "";
           
            MessageBox.Show("su tarifa por la llamada es: "+unaLlamadatelefonica.CalcularCosto().ToString("C"));

        }
    }
}
