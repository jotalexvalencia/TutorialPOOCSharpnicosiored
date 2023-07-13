using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa06_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Funcion virtual y override con sealed

            // Creamos producto
            CProducto uno = new CProducto("Bicicleta", 2500.35);

            uno.CalculaPrecio();
            uno.MuestraVenta();

            Console.WriteLine("---------");

            // creamos producto importado
            CProductoImportado dos = new CProductoImportado("Bicicleta importada", 2500.35, 0.15);
            dos.CalculaPrecio();
            dos.MuestraVenta();

            Console.WriteLine("---------");

            // cramos producto con multa
            CProductoDetenido tres = new CProductoDetenido("Bici detenida", 2500.35, 0.15, 500.8);
            tres.CalculaPrecio();
            tres.MuestraVenta();

        }
    }
}
