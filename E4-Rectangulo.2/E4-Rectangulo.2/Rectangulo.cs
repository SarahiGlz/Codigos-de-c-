using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_Rectangulo._2
{
    class Rectangulo
    {
        private double _dblAncho;

        public double Ancho
        {
            get { return _dblAncho; }
            set { _dblAncho = value; }
        }

        private double _dblLargo;

        public double Largo
        {
            get { return _dblLargo; }
            set { _dblLargo = value; }
        }


        public double CalcularArea()
        {
            return (Ancho * Largo);
        }



    }
}
