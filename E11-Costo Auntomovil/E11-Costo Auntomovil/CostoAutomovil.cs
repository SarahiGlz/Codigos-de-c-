using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E11_Costo_Auntomovil
{
    class CostoAutomovil
    {
        private double _dblCostoDelVehiculo;

        public double CostoDelVehiculo
        {
            get { return _dblCostoDelVehiculo; }
            set { _dblCostoDelVehiculo = value; }
        }


        public double CalcularCostoTotal()
        {
            return ((CostoDelVehiculo*12/100)+(CostoDelVehiculo*6/100)+CostoDelVehiculo);
        }
    }
}
