namespace E6_Articulo
{
    class Articulo
    {
        private int _intClave;

        public int Clave
        {
            get { return _intClave; }
            set { _intClave = value; }
        }

        private string _strDescripcion;

        public string Descripcion
        {
            get { return _strDescripcion; }
            set { _strDescripcion = value; }
        }

        private double _dblPrecio;

        public double Precio
        {
            get { return _dblPrecio; }
            set { _dblPrecio = value; }
        }

        private int _intCantidad;

        public int Cantidad
        {
            get { return _intCantidad; }
            set { _intCantidad = value; }
        }



        //constructor
        public Articulo(int intClave, string strDescripcion, double dblPrecio, int intCantidad)
        {
            _intClave = intClave;
            _strDescripcion = strDescripcion;
            _dblPrecio = dblPrecio;
            _intCantidad = intCantidad;
        }

        //metodo
        public double CalcularIva()
        {
            return (0.08*Precio);
        }


    }
}
