using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E6_Articulo
{
    public partial class Supermercado : Form
    {
        public Supermercado()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularIva_Click(object sender, EventArgs e)
        {
            Articulo unArticulo = new Articulo(int.Parse(txtClave.Text), txtDescripcion.Text, double.Parse(txtPrecio.Text), int.Parse(txtCantidad.Text));
            MessageBox.Show("El Iva del articulo es: " + unArticulo.CalcularIva().ToString("C"));
        }






    }
}
    
