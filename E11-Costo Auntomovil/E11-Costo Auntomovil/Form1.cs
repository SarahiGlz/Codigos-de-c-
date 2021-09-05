using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E11_Costo_Auntomovil
{
    public partial class Form1 : Form
    {
        CostoAutomovil unAutomovil = new CostoAutomovil();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcularCostoTotal_Click(object sender, EventArgs e)
        {
            unAutomovil.CostoDelVehiculo = double.Parse(txtCostoDelVehiculo.Text);
            MessageBox.Show("El costo total del vehiculo incluyendo impuestos es: " + unAutomovil.CalcularCostoTotal().ToString("C"));

        }
    }
}
