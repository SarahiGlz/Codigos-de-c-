using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1_Circunferencia
{
    class Circunferencia
    {
        private double _dblRadio;

        //accesor
        public double ConsultarRadio()
        {
            return (_dblRadio);
        }

        //mutator
        public void ModificarRadio(double dblRadio)
        {
            _dblRadio = dblRadio;
        }

        //constructor
        public Circunferencia(double dblRadio)
        {
            _dblRadio = dblRadio;
        }

        //metodos
        public double CalcularArea()
        {
            return (Math.PI*Math.Pow(_dblRadio, 2));
        }
        public double CalcularPerimetro()
        {
            return (2 * Math.PI * _dblRadio);
        }

    }
}
