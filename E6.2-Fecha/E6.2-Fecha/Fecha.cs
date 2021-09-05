using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6._2_Fecha
{
    class Fecha
    {
        private int _intDia, _intMes, _intAño;

        //contructor
        public Fecha()
        {
            _intDia = 04;
            _intMes = 03;
            _intAño = 2021;
        }

        //contructor con parametros
        public Fecha(int intDia, int intMes, int intAño)
        {
            _intDia = intDia;
            _intMes = intMes;
            _intAño = intAño;
        }

        //mutator dia
        public void ModificarDia(int intDia)
        {
            
            _intDia = intDia;
        }
        //mutator mes
        public void ModificarMes(int intMes)
        {
            
            _intMes = intMes;
            
        }
        //mutator
        public void ModificarAño( int intAño)
        {
         
            _intAño = intAño;
        }

        public string ConsultarFecha()
        {
            return (_intDia.ToString() + "/" + _intMes.ToString() + "/" + _intAño.ToString());
        }

        
        public string ConsultarFechaEnLetra()
        {
            string strMes;
            
            strMes = _intMes.ToString();
            switch (strMes)
            {
                case "1": return (_intDia.ToString() + " de enero del " + _intAño.ToString());

                case "2": return (_intDia.ToString() + " de febrero del " + _intAño.ToString());
                case "3": return (_intDia.ToString() + " de marzo del " + _intAño.ToString());
                case "4": return (_intDia.ToString() + " de abril del " + _intAño.ToString());
                case "5": return (_intDia.ToString() + " de mayo del " + _intAño.ToString());
                case "6": return (_intDia.ToString() + " de junio del " + _intAño.ToString());
                case "7": return (_intDia.ToString() + " de julio del " + _intAño.ToString());
                case "8": return (_intDia.ToString() + " de agosto del " + _intAño.ToString());
                case "9": return (_intDia.ToString() + " de septiembre del " + _intAño.ToString());
                case "10": return (_intDia.ToString() + " de octubre del " + _intAño.ToString());
                case "11": return (_intDia.ToString() + " de noviembre del " + _intAño.ToString());
                case "12": return (_intDia.ToString() + " de diciembre del " + _intAño.ToString());

            }
            return (" ");
        }


        /*public string ConsultarFechaConLetra()
        {
            string strMes;
            strMes=_intMes.ToString();

            if(strMes=="1")
            {
                return (_intDia.ToString() + "de enero del" + _intAño.ToString());
            }*/
            /*switch (strMes)
            {
                case "1": return (_intDia.ToString() + "de enero del" + _intAño.ToString());
                 
                case "2": return (_intDia.ToString() + "de febrero del" + _intAño.ToString());
                case "3": return (_intDia.ToString() + "de marzo del" + _intAño.ToString()); 
                case "4": return (_intDia.ToString() + "de abril del" + _intAño.ToString());
                case "5": return (_intDia.ToString() + "de mayo del" + _intAño.ToString()); 
                case "6": return (_intDia.ToString() + "de junio del" + _intAño.ToString()); 
                case "7": return (_intDia.ToString() + "de julio del" + _intAño.ToString()); 
                case "8": return (_intDia.ToString() + "de agosto del" + _intAño.ToString()); 
                case "9": return (_intDia.ToString() + "de septiembre del" + _intAño.ToString());
                case "10": return (_intDia.ToString() + "de octubre del" + _intAño.ToString()); 
                case "11": return (_intDia.ToString() + "de noviembre del" + _intAño.ToString()); 
                case "12": return (_intDia.ToString() + "de diciembre del" + _intAño.ToString()); 
            }*/

        //}
    }
}
