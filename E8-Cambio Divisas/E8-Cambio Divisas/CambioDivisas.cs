using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E8_Cambio_Divisas
{
    class CambioDivisas
    {
        private double _dblPesos;

        public double Pesos
        {
            get { return _dblPesos; }
            set { _dblPesos = value; }
        }

        private double _dblTipoDeCambio;

        public double TipoDeCambio
        {
            get { return _dblTipoDeCambio; }
            set { _dblTipoDeCambio = value; }
        }

        //contructor
        public CambioDivisas(double dblTipoCambio=20.50)
        {
            _dblTipoDeCambio = dblTipoCambio;
        }

        //metodo
        public double ConvertirADolares()
        {
            return (Pesos/_dblTipoDeCambio);
        }

    }
}
