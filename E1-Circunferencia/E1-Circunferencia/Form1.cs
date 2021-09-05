using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E1_Circunferencia
{
    public partial class Form1 : Form
    {
        Circunferencia unaRueda = new Circunferencia(10.2);
        Circunferencia unaMoneda = new Circunferencia(1.4);

        public Form1()
        {
            InitializeComponent();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCapturarRadio_Click(object sender, EventArgs e)
        {
            if(radMoneda.Checked)
            {
                unaMoneda.ModificarRadio(double.Parse(txtRadio.Text));
                MessageBox.Show("El radio de la moneda fue modificado :)");
            }
            if(radRueda.Checked)
            {
                unaRueda.ModificarRadio(double.Parse(txtRadio.Text));
                MessageBox.Show("El radio de la rueda fue modificadio :)");
            }
        }

        private void btnCalcularPerimetro_Click(object sender, EventArgs e)
        {
            if(radMoneda.Checked)
            {
                MessageBox.Show("El perimetro de la Moneda es: "+unaMoneda.CalcularPerimetro().ToString("N2"));
            }
            if(radRueda.Checked)
            {
                MessageBox.Show("El perimetro de la rueda es: " + unaRueda.CalcularPerimetro().ToString("N2"));
            }
        }

        private void btnCalcularArea_Click(object sender, EventArgs e)
        {
            if(radMoneda.Checked)
            {
                MessageBox.Show("El area de la moneda es: " + unaMoneda.CalcularArea().ToString("N2"));
            }
            if(radRueda.Checked)
            {
                MessageBox.Show("El area de la rueda es: " + unaRueda.CalcularArea().ToString("N2"));
            }
        }
    }
}
