using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E7__Grados_centigrados_a_F
{
    public partial class Form1 : Form
    {
        Temperatura miTemperatura = new Temperatura(0.0);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConvertirAFarenheit_Click(object sender, EventArgs e)
        {
            miTemperatura.GradosCentigrados = double.Parse(txtGradosCentigrados.Text);
            MessageBox.Show(miTemperatura.GradosCentigrados+" grados = " + miTemperatura.ConvertirAFarenheit()+ " farenheit ");
        }
    }
}
