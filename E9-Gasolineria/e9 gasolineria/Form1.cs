using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e9_gasolineria
{
    public partial class Form1 : Form
    {
        Gasolineria miGasolineria = new Gasolineria();

        public Form1()
        {
            InitializeComponent();
        }


        //salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

  

        private void btnCapurarGalones_Click(object sender, EventArgs e)
        {
            miGasolineria.ModificarCantidadGalon(double.Parse(txtGalones.Text));
            MessageBox.Show("Se Capturó la cantidad de galones");
            //limpiar textbox
            txtGalones.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su importe por la compra de "+ miGasolineria.ConsultarCantidadGalon() +" galones es: "+ miGasolineria.CalcularImporte().ToString("C"));
        }

        private void btnCalcularLitros_Click(object sender, EventArgs e)
        {
            MessageBox.Show(miGasolineria.ConsultarCantidadGalon() +" galones=  " + miGasolineria.CalcularLitros().ToString("N2")+" litros");
           
        }

       
    }
}
