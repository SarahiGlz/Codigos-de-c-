using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_Fecha
{
    class Fecha
    {
        private int _intDia, _intMes, _intAño;

        //contructor
        Fecha()
        {
            _dblDia = 04;
            _intMes = 03;
            _intAño = 2021;
        }

        //contructor con parametros
        Fecha(int intDia, int intMes, int intAño)
        {
            _intDia = intDia;
            _intMes = intMes;
            _intAño = intAño;
        }

        //mutator
        ModificarFecha(int intDia, int intMes, int intAño)
        {
            intDia = intDia;
            _intMes = intMes;
            _intAño = intAño;
        }

        string ConsultarFecha()
        {
            return (_intDia.ToString()+"/"+_intMes.ToString()+"/"+_intAño.ToString());
        }

        string ConsultarFechaConLetra()
        {
            string strMes;
            switch(strMes)
            {
                case 1: return (_intDia.ToString() + "de enero del" + _intAño.ToString()); break;
                case 2: return (_intDia.ToString() + "de febrero del" + _intAño.ToString()); break;
                case 3: return (_intDia.ToString() + "de marzo del" + _intAño.ToString()); break;
                case 4: return (_intDia.ToString() + "de abril del" + _intAño.ToString()); break;
                case 5: return (_intDia.ToString() + "de mayo del" + _intAño.ToString()); break;
                case 6: return (_intDia.ToString() + "de junio del" + _intAño.ToString()); break;
                case 7: return (_intDia.ToString() + "de julio del" + _intAño.ToString()); break;
                case 8: return (_intDia.ToString() + "de agosto del" + _intAño.ToString()); break;
                case 9: return (_intDia.ToString() + "de septiembre del" + _intAño.ToString()); break;
                case 10: return (_intDia.ToString() + "de octubre del" + _intAño.ToString()); break;
                case 11: return (_intDia.ToString() + "de noviembre del" + _intAño.ToString()); break;
                case 12: return (_intDia.ToString() + "de diciembre del" + _intAño.ToString()); break;
            }

        }
        



    }
}
