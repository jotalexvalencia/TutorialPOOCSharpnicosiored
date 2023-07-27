using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa06_03
{ 
    // clases abstractas no se pueden instanciar directamente
    abstract class CProducto
    {
        protected string descripcion;
        protected double precioCompra;
        protected double precioVenta;

        protected CProducto(string pDescripcion, double pPrecioCompra)
        {
            descripcion = pDescripcion;
            precioCompra = pPrecioCompra;
            precioVenta = 0.0;  
        }

        public virtual void CalculaPrecio()
        {
            Console.WriteLine("Calcula precio de prodcuto");
            precioVenta = precioCompra * 1.3;
        }

        // método abstractos no tienen cuerpo es responsabilidad de las clases hijas
        public abstract void MuestraVenta();
    }
}
