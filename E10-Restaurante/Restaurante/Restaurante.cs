using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class Restaurante
    {
        private int _intCantidadDeHamburguesasSencillas;

        public int CantidadDeHamburguesasSencillas
        {
            get { return _intCantidadDeHamburguesasSencillas; }
            set { _intCantidadDeHamburguesasSencillas = value; }
        }

        private int _intCantidadDeHamburguesasQueso;

        public int CantidadDeHamburguesasQueso
        {
            get { return _intCantidadDeHamburguesasQueso; }
            set { _intCantidadDeHamburguesasQueso = value; }
        }


        private int _intCantidadDeHambursasEspecial;

        public int CantidadDeHambursasEspecial
        {
            get { return _intCantidadDeHambursasEspecial; }
            set { _intCantidadDeHambursasEspecial = value; }
        }


        private int _intCantidadDePapas;

        public int CantidadDePapas
        {
            get { return _intCantidadDePapas; }
            set { _intCantidadDePapas = value; }
        }

        private int _intCantidadRefresco;

        public int CantidadRefresco
        {
            get { return _intCantidadRefresco; }
            set { _intCantidadRefresco = value; }
        }

        private int _intCantidadPostre;

        public int CantidadPostre
        {
            get { return _intCantidadPostre; }
            set { _intCantidadPostre = value; }
        }



        //precio
        private double _dblPrecioHamburguesaSencilla;

        public  double PrecioHamburguesaSencilla
        {
            get { return _dblPrecioHamburguesaSencilla; }
            set { _dblPrecioHamburguesaSencilla = value; }
        }

        private double _dblPrecioHamburguesaQueso;

        public double PrecioHamburguesaQueso
        {
            get { return _dblPrecioHamburguesaQueso; }
            set { _dblPrecioHamburguesaQueso = value; }
        }

        private double _dblPrecioHamburguesaEspecial;

        public double PrecioHamburguesaEspecial
        {
            get { return _dblPrecioHamburguesaEspecial; }
            set { _dblPrecioHamburguesaEspecial = value; }
        }

        private double _dblPrecioPapas;

        public double PrecioPapas
        {
            get { return _dblPrecioPapas; }
            set { _dblPrecioPapas = value; }
        }

        private double _dblPrecioRefresco;

        public double PrecioRefresco
        {
            get { return _dblPrecioRefresco; }
            set { _dblPrecioRefresco = value; }
        }

        private double _dblPrecioPostre;

        public double PrecioPostre
        {
            get { return _dblPrecioPostre; }
            set { _dblPrecioPostre = value; }
        }





        public Restaurante()
        {
            PrecioHamburguesaSencilla = 15;
            PrecioHamburguesaQueso = 18;
            PrecioHamburguesaEspecial = 20;
            PrecioPapas = 8;
            PrecioPostre = 5;
            PrecioRefresco = 6;
        }

        //metodos
        public double CalcularTotalHamSen()
        {
            return (CantidadDeHamburguesasSencillas * PrecioHamburguesaSencilla);
        }

        public double CalcularTotalHamQueso()
        {
            return (CantidadDeHamburguesasQueso*PrecioHamburguesaQueso);
        }

        public double CalcularTotalHamEsp()

        {
            return (CantidadDeHamburguesasSencillas*PrecioHamburguesaSencilla);
        }

        public double CalcularTotalPapas()
        {
            return (CantidadDePapas*PrecioPapas);
        }

        public double CalcularTotalRefresco()
        {
            return (CantidadRefresco*PrecioRefresco);
        }

        public double CalcularTotalPostre()
        {
            return (CantidadPostre*PrecioPostre);
        }


        //Metodo que calcula el total TOTAL
        public double CalcularImporte()
        {
            return (CalcularTotalHamSen()+CalcularTotalHamQueso()+CalcularTotalHamEsp()+CalcularTotalPapas()+CalcularTotalRefresco()+CalcularTotalPostre());
        }



    }
}
