using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E2_Circunferencia
{
    public partial class Form1 : Form
    {
        //declaracion de objetos, con su inicializacion
        Circunferencia unaRueda = new Circunferencia();
        Circunferencia unaMoneda = new Circunferencia();
        public Form1()
        {
            InitializeComponent();
        }

        //codigo del boton "salir"
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //codigo del boton calcular area
        private void btnCalcularArea_Click(object sender, EventArgs e)
        {
           
            if(radRueda.Checked)
            {
                unaRueda.Radio = double.Parse(txtRadio.Text);
                MessageBox.Show("El Area de la rueda es: "+ unaRueda.CalcularArea().ToString("N2"));
            }
            if (RadMoneda.Checked)
            {
                unaMoneda.Radio = double.Parse(txtRadio.Text);
                MessageBox.Show("El Area de la moneda es: " + unaMoneda.CalcularArea().ToString("N2"));

            }
            //limpia el textbox del radio
            txtRadio.Text = "";
            //coloca el cursor en el textbox y lo prepara para capturar
            txtRadio.Focus();


        }

        private void btnCalcularPerimetro_Click(object sender, EventArgs e)
        {

            if (radRueda.Checked)
            {
                unaRueda.Radio = double.Parse(txtRadio.Text);
                MessageBox.Show("El Perimetro de la rueda es: " + unaRueda.CalcularPerimetro().ToString("N2"));
            }
            if (RadMoneda.Checked)
            {
                unaMoneda.Radio = double.Parse(txtRadio.Text);
                MessageBox.Show("El Perimetro de la moneda es: " + unaMoneda.CalcularPerimetro().ToString("N2"));

            }
            //limpia el textbox del radio
            txtRadio.Text = "";
            //coloca el cursor en el textbox y lo prepara para capturar
            txtRadio.Focus();
        }

     
    }
}
