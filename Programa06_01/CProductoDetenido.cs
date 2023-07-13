using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa06_01
{
    class CProductoDetenido : CProductoImportado
    {
        private double multa;

        public CProductoDetenido(string pDescripcion, double pPrecioCompra, double pImpuesto, double pMulta) 
            : base(pDescripcion, pPrecioCompra, pImpuesto)
        {
            multa = pMulta;
        }

        //public override void CalculaPrecio()
        //{
        //    Console.WriteLine("Calcula precio de importado con multa");
        //    precioVenta = ((precioCompra * (1 + impuesto)) * 1.30) + multa;
        //}
    }
}
