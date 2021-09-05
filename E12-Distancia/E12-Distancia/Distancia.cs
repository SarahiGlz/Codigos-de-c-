using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E12_Distancia
{
    class Distancia
    {
        private double _dblPuntoXUno, _dblPuntoYUno, _dblPuntoXDos, _dblPuntoYDos;
        //accesor x1
        public double ConsultarPuntoXUno()
        {
            return (_dblPuntoXUno);
        }
        //accesor y1
        public double ConsultarPuntoYUno()
        {
            return (_dblPuntoYUno);
        }
        //accesor x2
        public double ConsultarPuntoXDos()
        {
            return (_dblPuntoXDos);
        }
        //accesor y2
        public double ConsultarPuntoYDos()
        {
            return (_dblPuntoYDos);
        }

        //mutator x1
        public void ModificarPuntoXUno(double dblPuntoXUno)
        {
            _dblPuntoXUno = dblPuntoXUno;
        }
        //mutator y1
        public void ModificarPuntoYUno(double dblPuntoYUno)
        {
            _dblPuntoYUno = dblPuntoYUno;
        }
        //mutator x2
        public void ModificarPuntoXDos(double dblPuntoXDos)
        {
            _dblPuntoXDos = dblPuntoXDos;
        }
        //mutator y2
        public void ModificarPuntoYDos(double dblPuntoYDos)
        {
            _dblPuntoYDos = dblPuntoYDos;
        }

        //constructor 
        public Distancia(double dblPuntoXUno, double dblPuntoYUno, double dblPuntoXDos, double dblPuntoYDos)
        {
            _dblPuntoXUno = dblPuntoXUno;
            _dblPuntoYUno = dblPuntoYUno;
            _dblPuntoXDos = dblPuntoXDos;
            _dblPuntoYDos = dblPuntoYDos;
        }

        //metodo
        public double CalcularDistancia()
        {
            return (Math.Sqrt(         (Math.Pow((_dblPuntoXDos-_dblPuntoXUno),2))     +    (Math.Pow((_dblPuntoYDos-_dblPuntoYUno),2))   ));
            //return (_dblPuntoXUno+_dblPuntoXDos+_dblPuntoYUno+_dblPuntoYDos);
        }






    }
}
