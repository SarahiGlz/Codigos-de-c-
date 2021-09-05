using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_Rectangulo
{
    class Rectangulo
    {
        private double _dblLargo, _dblAncho;


        //mutator
        public void ModificarLargo(double dblLargo)
        {
            _dblLargo = dblLargo;
        }

        public void ModificarAncho(double dblAncho)
        {
            _dblAncho = dblAncho;
        }

        //accesor
        public double ConsultarLargo()
        {
            return _dblLargo;
        }

        public double ConsultarAncho()
        {
            return _dblAncho;
        }

        //metodo
        public double CalcularArea()
        {
            return (_dblAncho * _dblLargo);
        }











    }



}
