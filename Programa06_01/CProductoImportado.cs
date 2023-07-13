using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa06_01
{
    class CProductoImportado:CProducto
    {
        protected double impuesto;

        public CProductoImportado(string pDescripcion, double pPrecioCompra, double pImpuesto) : base(pDescripcion, pPrecioCompra)
        {
            impuesto = pImpuesto;
        }

        public sealed override void CalculaPrecio()
        {
            Console.WriteLine("CalcUla precio de importado");
            precioVenta = (precioCompra * (1+impuesto)) *1.30;
        }
    }
}
