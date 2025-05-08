using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP6_GRUPO_24
{
    public class Producto
    {

        private int _idProducto;
        private string _nombreProducto;
        private string _cantidadPorUnidad; // esta propiedad es string, no int, porque en la bd es nvarchar. g.
        private decimal _precioUnidad;

        
        public Producto()
        {
            /// CONSTRUCTOR por defecto o vacío
        }

        public Producto(int idProducto)
        {
            _idProducto = idProducto;
        }

        /*
        public Producto(int idProducto, string nombreProducto, int cantidadPorUnidad)
        {
            _idProducto = idProducto;
            _nombreProducto = nombreProducto;
            _cantidadPorUnidad = cantidadPorUnidad;
        }*/

        public Producto(int idProducto, string nombreProducto, string cantidadPorUnidad, decimal precioUnidad)
        {
            _idProducto = idProducto;
            _nombreProducto = nombreProducto;
            _cantidadPorUnidad = cantidadPorUnidad;
            _precioUnidad = precioUnidad;
        }






        public int IdProducto
        {
            get
            {
                return _idProducto;
            }
            set
            {
                _idProducto = value;
            }
        }
        public string NombreProducto
        {
            get
            {
                return _nombreProducto;
            }
            set
            {
                _nombreProducto = value;
            }
        }
        public string CantidadPorUnidad 
        {
            get
            {
                return _cantidadPorUnidad;
            }
            set
            {
                _cantidadPorUnidad = value;
            }
        }
        public decimal PrecioUnidad
        {
            get
            {
                return _precioUnidad;
            }
            set
            {
                _precioUnidad = value;
            }
        }
    }

}