using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E15_Llamada_Telefonica
{
    class LlamadaTelefonica
    {
        private int _intMinutos;

        public int Minutos
        {
            get { return _intMinutos; }
            set{ _intMinutos = value; }
            
        }

      



        public int CalcularCosto()
        {
            
            if (Minutos <= 3)
            {
                return (5);
            }

            if (Minutos > 3)
            {
                return (5 + ((Minutos - 3) * 3));
            }

            return (0);
            
        }

    }
}
