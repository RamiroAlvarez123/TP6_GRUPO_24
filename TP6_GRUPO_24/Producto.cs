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
        private int _cantidadPorUnidad;
        private decimal _precioPorUnidad;

        
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
        }

        public Producto(int idProducto, string nombreProducto, int cantidadPorUnidad, decimal precioPorUnidad)
        {
            _idProducto = idProducto;
            _nombreProducto = nombreProducto;
            _cantidadPorUnidad = cantidadPorUnidad;
            _precioPorUnidad = precioPorUnidad;
        }
        */





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
        public int CantidadPorUnidad
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
        public decimal PrecioPorUnidad
        {
            get
            {
                return _precioPorUnidad;
            }
            set
            {
                _precioPorUnidad = value;
            }
        }
    }

}