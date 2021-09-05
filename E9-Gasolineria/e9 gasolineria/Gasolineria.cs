using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e9_gasolineria
{
    class Gasolineria
    {
        private double _dblCantidadGalon, _dblPrecioPorLitro;
  


        //constructor
        public Gasolineria()
        {

            _dblPrecioPorLitro = 12.50;
            
        }

        //mutator
        public void ModificarCantidadGalon(double dblCantidadGalon)
        {
            _dblCantidadGalon = dblCantidadGalon;
        }

        //accesor
        public double ConsultarCantidadGalon()
        {
            return (_dblCantidadGalon);
        }
        public double ConsultarPrecioPorLitro()
        {
            return (_dblPrecioPorLitro);
        }


        //metodo que convierte galones a litros
        public double CalcularLitros()
        {
            
            return( _dblCantidadGalon * 3.78541);
         
        }

        //metodo que calcula el importe total
        public double CalcularImporte()
        {
            return (CalcularLitros()* _dblPrecioPorLitro);
        }
       
    }
}
