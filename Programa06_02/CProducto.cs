using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa06_02
{
    class CProducto
    {
        protected string descripcion;
        protected double precioCompra;
        protected double precioVenta;

        public CProducto(string pDescripcion, double pPrecioCompra)
        {                       
            descripcion = pDescripcion;
            precioCompra = pPrecioCompra;
            precioVenta = 0.0;
        }

        public virtual void CalculaPrecio()
        {
            Console.WriteLine("Calcula precio de producto");
            precioVenta = precioCompra * 1.3;
                
        }

        public void MuestraVenta() 
        {
            Console.WriteLine("{0} se vende en {1}",descripcion, precioVenta);
        }
    }
}
