using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E8_Cambio_Divisas
{
    public partial class Form1 : Form
    {
        CambioDivisas unCambioDeDivisas = new CambioDivisas();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConvertirADolares_Click(object sender, EventArgs e)
        {
            unCambioDeDivisas.Pesos = Double.Parse(txtPesos.Text);
            MessageBox.Show(unCambioDeDivisas.Pesos.ToString("C") + " = "+ unCambioDeDivisas.ConvertirADolares().ToString("C")+ " dolares");

        }
    }
}
