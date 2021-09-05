using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Hexagono
{
    public partial class Form1 : Form
    {
        Hexagono unHexagonoVerde = new Hexagono();
        Hexagono unHexagonoRojo = new Hexagono();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            if(radHexagonoVerde.Checked)
            {
                unHexagonoVerde.Lado = double.Parse(txtLado.Text);
                unHexagonoVerde.Apotema = double.Parse(txtApotema.Text);
                MessageBox.Show("Se han guardado los datos del hexágono verde");
                txtLado.Text = "";
                txtApotema.Text = "";
            }

            if(radHexagonoRojo.Checked)
            {
                unHexagonoRojo.Lado = double.Parse(txtLado.Text);
                unHexagonoRojo.Apotema = double.Parse(txtApotema.Text);
                MessageBox.Show("Se han guardado los datos del hexágono rojo");
            }
        }

        private void btnCalcularCantidadDePintura_Click(object sender, EventArgs e)
        {
            double dblCantidadDePintura;
            dblCantidadDePintura = ((unHexagonoVerde.CalcularArea() - unHexagonoRojo.CalcularArea())*0.3);
            MessageBox.Show("La cantida de pintura que se necesita para el hexágono verde es: "+dblCantidadDePintura+ "ml");
        }
    }
}
