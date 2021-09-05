using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3_Rectangulo
{
    public partial class Form1 : Form
    {
        Rectangulo unaVentana = new Rectangulo();
        Rectangulo unaPared = new Rectangulo();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCapturarDatos_Click(object sender, EventArgs e)
        {
            if (radPared.Checked)
            {
                unaPared.ModificarLargo(double.Parse(txtLargo.Text));
                unaPared.ModificarAncho(double.Parse(txtAncho.Text));
                MessageBox.Show("Se han capturado los datos de la pared");
            }
            if(radVentana.Checked)
            {
                unaVentana.ModificarLargo(double.Parse(txtLargo.Text));
                unaVentana.ModificarAncho(double.Parse(txtAncho.Text));
                MessageBox.Show("Se han capturado los datos de la ventana");
                txtLargo.Text = "";
                txtAncho.Text = "";
            
            }
        }

        private void btnTiempo_Click(object sender, EventArgs e)
        {
            double dblTiempo;
            dblTiempo = (unaPared.CalcularArea() - unaVentana.CalcularArea()) * 10;


            MessageBox.Show("el tiempo es de: "+ dblTiempo+ " minutos");
        }
    }
}
