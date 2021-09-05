using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7__Grados_centigrados_a_F
{
    class Temperatura
    {
        private double _dblGradosCentigrados;

        public double GradosCentigrados
        {
            get { return _dblGradosCentigrados; }
            set { _dblGradosCentigrados = value; }
        }

        //contructor

        public Temperatura(double dblGradosCentigrados)
        {
            _dblGradosCentigrados = dblGradosCentigrados;
        }

        //metodo
        public double ConvertirAFarenheit()
        {
            return ((_dblGradosCentigrados*1.8)+32);
        }

    }
}
