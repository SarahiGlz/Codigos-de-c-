using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E12_Distancia
{
    public partial class Form1 : Form
    {
        Distancia miPuntoUno = new Distancia(0,0,0,0);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCapturarCoordenada_Click(object sender, EventArgs e)
        {
            if(radPuntoUno.Checked)
            {
                miPuntoUno.ModificarPuntoXUno(double.Parse(txtCoordenadaX.Text));
                miPuntoUno.ModificarPuntoYUno(double.Parse(txtCoordenadaY.Text));
                MessageBox.Show("Se han capturado las coordenadas del punto 1");
                txtCoordenadaX.Text = "";
                
                txtCoordenadaY.Text = "";
                
            }
            

            else
            {
               

                miPuntoUno.ModificarPuntoXDos(double.Parse(txtCoordenadaX.Text));
                miPuntoUno.ModificarPuntoYDos(double.Parse(txtCoordenadaY.Text));
                MessageBox.Show("Se han capturado las coordenadas del punto 2");
            }
        }

        private void btnCalcularDistancia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La distancia de estos dos puntos es: " + miPuntoUno.CalcularDistancia().ToString("N2"));
        }
    }
}
