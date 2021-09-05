using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E6._2_Fecha
{
    public partial class Form1 : Form
    {
        Fecha unaFecha = new Fecha();// en letra
        Fecha otraFecha = new Fecha(0,0,0);//D/M/A

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnMostrarFormatoDMA_Click(object sender, EventArgs e)
        {
            
            otraFecha.ModificarDia(int.Parse(txtDia.Text));
            otraFecha.ModificarMes(int.Parse(txtMes.Text));
            otraFecha.ModificarAño(int.Parse(txtAño.Text));

            MessageBox.Show(otraFecha.ConsultarFecha());

        }

        private void btnFechaEnLetra_Click(object sender, EventArgs e)
        {
            unaFecha.ModificarDia(int.Parse(txtDia.Text));
            unaFecha.ModificarMes(int.Parse(txtMes.Text));
            unaFecha.ModificarAño(int.Parse(txtAño.Text));
            MessageBox.Show(unaFecha.ConsultarFechaEnLetra());
        }
    }
}
