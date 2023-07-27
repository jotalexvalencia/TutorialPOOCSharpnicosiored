using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa06_01
{
    class CProducto
    {
        private string descripcion;
        protected double precioCompra;
        protected double precioVenta;

        public CProducto(string pDescripcion, double pPrecioCompra)
        {
            descripcion = pDescripcion;
            precioCompra = pPrecioCompra;
            precioVenta = 0.0;
        }

        // cuando las clases hijas necesiten modificar el método lo colocamos virtual
        public virtual void CalculaPrecio()
        {
            Console.WriteLine("Calcula precio de producto");
            precioVenta = precioCompra * 1.3;
        }
        
        public void MuestraVenta() {
            Console.WriteLine("{0} se vende en {1}", descripcion,precioVenta));
        }
    }
}
