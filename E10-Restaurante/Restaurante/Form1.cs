using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Form1 : Form

    {
        Restaurante miMesaUno = new Restaurante();
        Restaurante miMesaDos = new Restaurante();
        Restaurante miMesaTres = new Restaurante();
        Restaurante miMesaCuatro = new Restaurante();
        Restaurante miMesaCinco= new Restaurante();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcularCuenta_Click(object sender, EventArgs e)
        {
            if(cboMesas.SelectedItem.ToString()=="Mesa 1")
            MessageBox.Show("Su importe a pagar es: " + miMesaUno.CalcularImporte().ToString("C"));

            if (cboMesas.SelectedItem.ToString() == "Mesa 2")
                MessageBox.Show("Su importe a pagar es: " +miMesaDos.CalcularImporte().ToString("C"));

            if (cboMesas.SelectedItem.ToString() == "Mesa 3")
                MessageBox.Show("Su importe a pagar es: "+miMesaTres.CalcularImporte().ToString("C"));

            if (cboMesas.SelectedItem.ToString() == "Mesa 4")
                MessageBox.Show("Su importe a pagar es: "+miMesaCuatro.CalcularImporte().ToString("C"));

            if (cboMesas.SelectedItem.ToString() == "Mesa 5")
                MessageBox.Show("Su importe a pagar es: "+miMesaCinco.CalcularImporte().ToString("C"));

        }

        private void btnCapturarOrden_Click(object sender, EventArgs e)
        {
            if (cboMesas.SelectedItem.ToString() == "Mesa 1")
            {
                miMesaUno.CantidadDeHamburguesasSencillas = int.Parse(txtHamburguesa1.Text);
                miMesaUno.CantidadDeHamburguesasQueso = int.Parse(txtHamburguesa2.Text);
                miMesaUno.CantidadDeHambursasEspecial = int.Parse(txtHamburguesa3.Text);
                miMesaUno.CantidadDePapas = int.Parse(txtPapas.Text);
                miMesaUno.CantidadRefresco = int.Parse(txtRefresco.Text);
                miMesaUno.CantidadPostre = int.Parse(txtPostre.Text);
                MessageBox.Show("Se Capturó su orden, gracias");
            }

            if (cboMesas.SelectedItem.ToString() == "Mesa 2")

            {
                miMesaDos.CantidadDeHamburguesasSencillas = int.Parse(txtHamburguesa1.Text);
                miMesaDos.CantidadDeHamburguesasQueso = int.Parse(txtHamburguesa2.Text);
                miMesaDos.CantidadDeHambursasEspecial = int.Parse(txtHamburguesa3.Text);
                miMesaDos.CantidadDePapas = int.Parse(txtPapas.Text);
                miMesaDos.CantidadRefresco = int.Parse(txtRefresco.Text);
                miMesaDos.CantidadPostre = int.Parse(txtPostre.Text);
                MessageBox.Show("Se Capturó su orden, gracias");
            }

            if (cboMesas.SelectedItem.ToString() == "Mesa 3")
            {
                miMesaTres.CantidadDeHamburguesasSencillas = int.Parse(txtHamburguesa1.Text);
                miMesaTres.CantidadDeHamburguesasQueso = int.Parse(txtHamburguesa2.Text);
                miMesaTres.CantidadDeHambursasEspecial = int.Parse(txtHamburguesa3.Text);
                miMesaTres.CantidadDePapas = int.Parse(txtPapas.Text);
                miMesaTres.CantidadRefresco = int.Parse(txtRefresco.Text);
                miMesaTres.CantidadPostre = int.Parse(txtPostre.Text);
                MessageBox.Show("Se Capturó su orden, gracias");
            }

            if (cboMesas.SelectedItem.ToString() == "Mesa 4")
            {


                miMesaCuatro.CantidadDeHamburguesasSencillas = int.Parse(txtHamburguesa1.Text);
                miMesaCuatro.CantidadDeHamburguesasQueso = int.Parse(txtHamburguesa2.Text);
                miMesaCuatro.CantidadDeHambursasEspecial = int.Parse(txtHamburguesa3.Text);
                miMesaCuatro.CantidadDePapas = int.Parse(txtPapas.Text);
                miMesaCuatro.CantidadRefresco = int.Parse(txtRefresco.Text);
                miMesaCuatro.CantidadPostre = int.Parse(txtPostre.Text);
                MessageBox.Show("Se Capturó su orden, gracias");
            }

            if (cboMesas.SelectedItem.ToString() == "Mesa 5")
            {
                miMesaDos.CantidadDeHamburguesasSencillas = int.Parse(txtHamburguesa1.Text);
                miMesaCinco.CantidadDeHamburguesasQueso = int.Parse(txtHamburguesa2.Text);
                miMesaCinco.CantidadDeHambursasEspecial = int.Parse(txtHamburguesa3.Text);
                miMesaCinco.CantidadDePapas = int.Parse(txtPapas.Text);
                miMesaCinco.CantidadRefresco = int.Parse(txtRefresco.Text);
                miMesaCinco.CantidadPostre = int.Parse(txtPostre.Text);
                MessageBox.Show("Se Capturó su orden, gracias");
            }

            else
            
            {
                MessageBox.Show("Seleccione a que mesa pertenece");
            }

        }
    }
}
