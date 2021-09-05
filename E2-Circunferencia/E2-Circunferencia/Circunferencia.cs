using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_Circunferencia
{
    class Circunferencia
    {
        private double _dblRadio;

        public double Radio
        {
            get { return _dblRadio; }
            set { _dblRadio = value; }
        }
        public double CalcularArea()
        {
            return (Math.PI*Math.Pow(_dblRadio,2));
        }

        public double CalcularPerimetro()
        {
            return (2*Math.PI * _dblRadio);
        }


    }
}
