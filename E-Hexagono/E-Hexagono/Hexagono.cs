using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Hexagono
{
    class Hexagono
    {
        private double _dblLado;

        public double Lado
        {
            get { return _dblLado; }
            set { _dblLado = value; }
        }


        private double _dblApotema;

        public double Apotema
        {
            get { return _dblApotema; }
            set { _dblApotema = value; }
        }


        //Metodo
        public double CalcularArea()
        {
            return ((Lado*6)*Apotema/2);
        }


    }
}
