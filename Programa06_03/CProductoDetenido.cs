using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa06_03
{
    class CProductoDetenido : CProducto
    {
        private double multa;
        private double impuesto;

        public CProductoDetenido(string pDescripcion, double pPrecioCompra, double pMulta, double pImpuesto) 
            : base(pDescripcion, pPrecioCompra)
        {
            multa = pMulta;
            impuesto = pImpuesto;
        }

        public override void CalculaPrecio()
        {
            Console.WriteLine("Calcula precio de importado con multa");
            precioVenta = ((precioCompra * (1 + impuesto)) * 1.30) + multa;
        }

        public override void MuestraVenta()
        {
            Console.WriteLine("El producto en aduana {0} tiene un costo de {1}", descripcion, precioVenta);
        }
    }
}
