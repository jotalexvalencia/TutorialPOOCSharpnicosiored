using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa06_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // clases abstractas y métodos abstractos

            // no podemos instanciar clase abstracta directamente
            //CProducto miProducto = new CProducto("Bicicleta",3500);

            CProductoImportado miProdImp = new CProductoImportado("Motocicleta", 350000, 0.15);
            CProductoDetenido miProdDet = new CProductoDetenido("Motocicleta", 350000, 0.15,0.30);

            miProdImp.CalculaPrecio();
            miProdDet.CalculaPrecio();

            miProdImp.MuestraVenta();
            miProdDet.MuestraVenta();
        }

    }
}
